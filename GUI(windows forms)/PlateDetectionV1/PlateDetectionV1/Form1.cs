using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using PlateDetectionV1.model;

namespace PlateDetectionV1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnHareketGoruntule_Click(object sender, EventArgs e)
        {
            PlateInfo plate = bsPlate.Current as PlateInfo;
            if (plate != null)
            {
                frmHareketSorgula frm = new frmHareketSorgula(plate);
                frm.ShowDialog();
            }
            else {
                MessageBox.Show("Lütfen Tablodan Bir plaka Seçiniz!","Uyarı",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            }
        }

        private void bsPlate_CurrentChanged(object sender, EventArgs e)
        {
            PlateInfo plate = bsPlate.Current as PlateInfo;
            
            txtKontrolAd.Text = plate.OwnerName.ToString();
            txtKontrolSoyad.Text = plate.OwnerSurname.ToString();
            txtKontrolPlaka.Text = plate.Plate.ToString();
            txtKontrolTarih.Text = plate.RegisterDate.Date.ToString();
            
        }

        private void btnoperasyon_Click(object sender, EventArgs e)
        {

            PlateInfo plate = bsPlate.Current as PlateInfo;
            if (plate != null)
            {
                FrmOperasyonDuzenle frm = new FrmOperasyonDuzenle(plate);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen Tablodan Bir plaka Seçiniz!", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void btngozat_Click(object sender, EventArgs e)
        {
            // OpenFileDialog nesnesi oluştur
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Bir resim dosyası seçin";
                openFileDialog.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp|Tüm Dosyalar|*.*";

                // Kullanıcı bir dosya seçtiyse
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Seçilen dosyanın yolunu TextBox'a yaz
                    txtfilepath.Text = openFileDialog.FileName;

                    // Seçilen resmi PictureBox'a yükle
                    picCar1.Image = Image.FromFile(openFileDialog.FileName);

                    // PictureBox içinde resmi uygun şekilde göster
                    picCar1.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }

        private async void btnsorgula_Click(object sender, EventArgs e)
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtKayitTarih.Clear();
            txtplaka.Clear();
            
            
            if (picCar1.Image == null)
            {
                MessageBox.Show("Lütfen bir resim yükleyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Resmi MemoryStream'e kaydet
            using (var memoryStream = new MemoryStream())
            {
                picCar1.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] imageBytes = memoryStream.ToArray();

                // API'ye post et
                string responseText = await PostImageAsync("http://localhost:8021/process_image", imageBytes);

                if (!string.IsNullOrEmpty(responseText))
                {
                    // Yanıtı ayrıştır
                    var jsonResponse = JObject.Parse(responseText);
                    var formattedTexts = jsonResponse["formatted_texts"]?.ToObject<string[]>();

                    if (formattedTexts != null && formattedTexts.Length > 0)
                    {
                        List<PlateInfo> list = new List<PlateInfo>();

                        string resultText = formattedTexts[0];
                        txtplaka.Text = resultText;

                        try
                        {
                            list = await PlateDetectDal.getMatchingPlate(resultText);
                            txtAd.Text = list[0].OwnerName;
                            txtSoyad.Text = list[0].OwnerSurname;
                            txtKayitTarih.Text = (list[0].RegisterDate).ToString();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Plaka Kaydı bulunamadı... Kayıt işlemi başlıyor", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            PlateInfo plate = new PlateInfo();
                            plate.Plate = txtplaka.Text;
                            
                            FrmPlakaKayit frm = new FrmPlakaKayit(plate);
                            frm.ShowDialog();
                            
                            UpdateBsPlate();

                        }
                        


                    }
                    else
                    {
                        MessageBox.Show("Servisten beklenen yanıt alınamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }
        private async Task<string> PostImageAsync(string url, byte[] imageBytes)
        {
            using (var client = new HttpClient())
            using (var content = new MultipartFormDataContent())
            {
                // Resmi form-data'ya ekle
                var imageContent = new ByteArrayContent(imageBytes);
                imageContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("image/jpeg");
                content.Add(imageContent, "file", "image.jpg");

                // İsteği gönder
                HttpResponseMessage response = await client.PostAsync(url, content);
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    MessageBox.Show($"İstek başarısız oldu: {response.StatusCode}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }






        private async void Form1_Load(object sender, EventArgs e)
        {

            UpdateBsPlate();
        }
        private async void UpdateBsPlate()
        {
            List<PlateInfo> list = new List<PlateInfo>();
            list = await PlateDetectDal.getPlates();

            bsPlate.DataSource = list;
        }
        
    }
}
