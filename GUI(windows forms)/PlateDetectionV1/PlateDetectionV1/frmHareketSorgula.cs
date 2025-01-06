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
    public partial class frmHareketSorgula : Form
    {
        PlateInfo _plate;
        public frmHareketSorgula()
        {
            InitializeComponent();
            _plate = new PlateInfo();
        }
        public frmHareketSorgula (PlateInfo plate)
        {
            InitializeComponent();
            _plate = plate;

        }

        private void frmHareketSorgula_Load(object sender, EventArgs e)
        {
            txtad.Text = _plate.OwnerName.ToString();
            txtsoyad.Text = _plate.OwnerName.ToString();
            txtplaka.Text = _plate.Plate.ToString();
            txtkayittarih.Text = _plate.RegisterDate.Date.ToString();

            frmUpdate();

        }

        private async void frmUpdate()
        {

            List<Operation> list = new List<Operation>();
            list = await PlateDetectDal.GetOperations(_plate);

            bsOperation.DataSource = list;
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
