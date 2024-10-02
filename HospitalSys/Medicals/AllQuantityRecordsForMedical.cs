using clsBusineesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalSys.Medicals
{
    public partial class AllQuantityRecordsForMedical : Form
    {

        bool WithSpecificQR = false;

        string MedicalQR;
        public AllQuantityRecordsForMedical()
        {
            InitializeComponent();
        }


        public AllQuantityRecordsForMedical(string MedicalQR)
        {
            InitializeComponent();
            this.MedicalQR = MedicalQR;
            WithSpecificQR = true;
        }

        private void PrepareSearchingWithSpecificQR(string medicalQR)
        {
            txtMedicalQR.Text=medicalQR;
            btnSearchQR_Click(null, null);
        }


        private void _LoadDataToGridView(DataTable dt)
        {
            dataGridView1.DataSource = dt;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchQR_Click(object sender, EventArgs e)
        {
            if(txtMedicalQR.Text=="")
            {
                MessageBox.Show("You must Fill Text Box!","info",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            DataTable dt=clsMedicals.GetAllRecordsForSpecificMedicalInStorage(txtMedicalQR.Text);
            if(dt.Rows.Count==0)
            {
                MessageBox.Show("No Medical with this QR!,Please Try anotherone!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _LoadDataToGridView(dt);
            
        }

        private void AllQuantityRecordsForMedical_Load(object sender, EventArgs e)
        {
            if (WithSpecificQR)
            {
                Task.Run(() =>
                {

                    this.Invoke((Action)(() =>
                    {
                        PrepareSearchingWithSpecificQR(MedicalQR);
                    }));

                });

            }
        }
    }
}
