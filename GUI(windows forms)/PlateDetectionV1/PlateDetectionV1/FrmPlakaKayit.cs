using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlateDetectionV1.model;

namespace PlateDetectionV1
{
    public partial class FrmPlakaKayit : Form
    {
        PlateInfo _plate;

        public FrmPlakaKayit()
        {
            InitializeComponent();
            _plate = new PlateInfo();
        }
        public FrmPlakaKayit(PlateInfo plate)
        {
            InitializeComponent();
            _plate = plate;
        }

        private void FrmPlakaKayit_Load(object sender, EventArgs e)
        {
            txtplaka.Text = _plate.Plate;
        }

        private void btnkayit_Click(object sender, EventArgs e)
        {
            PlateInfo plate = new PlateInfo();
            
            plate.Plate = txtplaka.Text;
            plate.RegisterDate = DateTime.Now.Date;
            plate.OwnerName = txtad.Text;
            plate.OwnerSurname = txtsoyad.Text;

            PlateDetectDal.insertPlate(plate);
            MessageBox.Show("Plaka başarıyla kaydedildi..","Kayıt Başarılı",MessageBoxButtons.OKCancel);

        }
    }
}
