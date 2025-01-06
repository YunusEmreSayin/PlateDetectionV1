using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PlateDetectionV1.model;

namespace PlateDetectionV1
{
    public partial class FrmOperasyonDuzenle : Form
    {
        private PlateInfo _plate;

        public FrmOperasyonDuzenle()
        {
            InitializeComponent();
            _plate = new PlateInfo();
        }
        public FrmOperasyonDuzenle(PlateInfo plate)
        {
            InitializeComponent();
            _plate = plate;
        }



        private async void FrmOperasyonDuzenle_Load(object sender, EventArgs e)
        {
            // Menü seçeneğinin düzenlenme özelleiğini kapatma ve varsayılan değer ataması
            cmbOpCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOpCategory.SelectedIndex = 0;


            txtad.Text = _plate.OwnerName.ToString();
            txtsoyad.Text = _plate.OwnerName.ToString();
            txtplaka.Text = _plate.Plate.ToString();
            txtkayittarih.Text = _plate.RegisterDate.Date.ToString();


            FormUpdate();

        }

        private async void FormUpdate()
        {
            List<Operation> operations = new List<Operation>();

            operations = await PlateDetectDal.GetOperations(_plate);

            bsOperation.DataSource = operations;
        }

        private void btnoperation_Click(object sender, EventArgs e)
        {
            Operation operation = new Operation();
            operation.PlateId = _plate.PlateId;
            operation.OperationDate = DateTime.Now.Date;
            operation.OperationCategory = cmbOpCategory.Text;

            PlateDetectDal.InsertOperation(operation);
            MessageBox.Show("Kayıt eklendi");
            FormUpdate();

        }
    }
}
