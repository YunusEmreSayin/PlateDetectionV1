using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlateDetectionV1.model;
using Newtonsoft.Json;
using System.Net.Http;
using System.Windows.Forms;

namespace PlateDetectionV1
{
    public static class PlateDetectDal
    {

        public async static Task<bool> insertPlate(PlateInfo plate)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string json = JsonConvert.SerializeObject(plate);
                    StringContent content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync("http://localhost:8003/api/PlateDetectMain/insertplateinfo", content);
                    return response.IsSuccessStatusCode;
                }
            }
            catch (HttpRequestException httpRequestException)
            {
                // Ağ hatalarını MessageBox ile göster
                MessageBox.Show($"Request error: {httpRequestException.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                // Diğer hatalar için genel bir exception handling ve MessageBox
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
       


        public static async Task<bool> InsertOperation(Operation operation)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string json = JsonConvert.SerializeObject(operation);
                    StringContent content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync("http://localhost:8003/api/PlateDetectMain/insertoperation", content);
                    return response.IsSuccessStatusCode;
                }
            }
            catch (HttpRequestException httpRequestException)
            {
                // Ağ hatalarını MessageBox ile göster
                MessageBox.Show($"Request error: {httpRequestException.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                // Diğer hatalar için genel exception handling ve MessageBox
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        public static async Task<List<PlateInfo>> getMatchingPlate(string plate)
        {
            // HttpClient örneği oluşturuluyor
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Dinamik URL oluşturuluyor
                    string url = $"http://localhost:8003/api/PlateDetectMain/getPlateByID?userPlate={Uri.EscapeDataString(plate)}";

                    // GET isteği gönderiliyor
                    HttpResponseMessage response = await client.GetAsync(url);

                    // Başarılı bir yanıt alındıysa
                    if (response.IsSuccessStatusCode)
                    {
                        string jsonData = await response.Content.ReadAsStringAsync();
                        return JsonConvert.DeserializeObject<List<PlateInfo>>(jsonData);
                    }
                    else
                    {
                        // Hata durumunda null döndürülüyor veya özel bir hata işleme mekanizması kullanılabilir
                        System.Windows.Forms.MessageBox.Show("Hata oluştu");
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    // Hata yakalanır ve yönetilir
                    System.Windows.Forms.MessageBox.Show($"Hata oluştu: {ex.Message}");
                    return null;
                }
            }
        }

        public static async Task<List<PlateInfo>> getPlates()
        {
            using (HttpClient client = new HttpClient()) 
            { HttpResponseMessage response = await client.GetAsync("http://localhost:8003/api/PlateDetectMain/getPlates");
                if (response.IsSuccessStatusCode) 
                { 
                    string jsonData = await response.Content.ReadAsStringAsync(); 
                    return JsonConvert.DeserializeObject<List<PlateInfo>>(jsonData);
                }
                else
                {
                    return null;
                }
            }
        }
        public static async Task<List<Operation>> GetOperations(PlateInfo plate)
        {

            using (HttpClient client = new HttpClient())
            {
                try
                {

                    // API URL'si ve PlateId parametresi ekleniyor
                    string json  = JsonConvert.SerializeObject(plate);
                    StringContent content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                    string url = $"http://localhost:8003/api/PlateDetectMain/getOperations";

                    // GET isteği gönderiliyor
                    HttpResponseMessage response = await client.PostAsync(url,content);

                    if (response.IsSuccessStatusCode)
                    {
                        // Başarılı yanıt alındığında, JSON verisini okuma
                        string responseBody = await response.Content.ReadAsStringAsync();

                        // JSON verisini PlateInfo listesine dönüştürme
                        return JsonConvert.DeserializeObject<List<Operation>>(responseBody);
                    }
                    else
                    {
                        // Başarısız istek durumunda hata mesajı
                        System.Windows.Forms.MessageBox.Show($"API isteği başarısız oldu. Hata kodu: {response.StatusCode}");
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    // Hata durumunda
                    System.Windows.Forms.MessageBox.Show($"Hata oluştu: {ex.Message}");
                    return null;
                }

            }

        }

    }
}
