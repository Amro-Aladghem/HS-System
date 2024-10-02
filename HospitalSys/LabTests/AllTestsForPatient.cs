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

namespace HospitalSys.LabTests
{
    public partial class AllTestsForPatient : Form
    {

        int PatientID;
        public AllTestsForPatient()
        {
            InitializeComponent();
        }

        public AllTestsForPatient(int PatientID)
        {
            InitializeComponent();
            this.PatientID = PatientID;
            txtPatientID.Text=PatientID.ToString();
            btnSearch_Click(null, null);
        }

        private void txtPatientID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnExsits_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtPatientID.Text=="")
            {
                MessageBox.Show("You must fill Text Box", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataTable dt = clsLapTests.GetAllTestsForPatient(Convert.ToInt32(txtPatientID.Text));
            if(dt.Rows.Count==0)
            {
                MessageBox.Show("There is no Tests For this Paitent!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dataGridView1.DataSource = dt;
        }

        private void AllTestsForPatient_Load(object sender, EventArgs e)
        {

        }
    }
}
