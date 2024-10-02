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

namespace HospitalSys.SurgeryProcedures
{
    public partial class AllSurgeryProcedureForPaients : Form
    {
        public AllSurgeryProcedureForPaients()
        {
            InitializeComponent();
        }

        public AllSurgeryProcedureForPaients(int PatientID)
        {
            InitializeComponent();
            txtSearch.Text = PatientID.ToString();
            btnSearch_Click(null, null);
        }


        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("You must Fill Tect Box!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataTable dt = clsSurgery.GetAllSureryProcedureForPatient(Convert.ToInt32(txtSearch.Text));
            if(dt.Rows.Count==0)
            {
                MessageBox.Show("There is no Records For this Patient!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = null;
                return;
            }

            dataGridView1.DataSource = dt;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
