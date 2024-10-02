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
    public partial class ctrFindMedicalRecordInStorage : UserControl
    {
        public ctrFindMedicalRecordInStorage()
        {
            InitializeComponent();
        }

       
        private void btnQRSearch_Click(object sender, EventArgs e)
        {
            if(!clsMedicals.IsMedicalTypeExitsInSys(txtMedicalQR.Text))
            {
                MessageBox.Show("No Medical with this QR in Sys, You must check if it exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(clsMedicals.IsMedicalHasMoreThanOneRecordWithDiffDate(txtMedicalQR.Text))
            {
                btnDateSearch.Visible= true;
                lbDate.Visible = true;
                dateProduced.Visible = true;
                btnQRSearch.Enabled = false;
                return;
            }

            clsMedicals medical = clsMedicals.FindMedicalByQR(txtMedicalQR.Text);
            if(medical==null)
            {
                MessageBox.Show("Somthing Error in connection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ctrMedicalRecordInfo1.GetObjectAndLoadData(medical);

        }

        private void btnDateSearch_Click(object sender, EventArgs e)
        {
            clsMedicals medical = clsMedicals.FindMedicalByQRAndProducedDate(txtMedicalQR.Text, dateProduced.Value.Date);
            if(medical==null)
            {
                MessageBox.Show("Somthing Error in connection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ctrMedicalRecordInfo1.GetObjectAndLoadData(medical);

            lbDate.Visible = false;
            dateProduced.Visible = false;
            btnDateSearch.Visible = false;
            btnQRSearch.Enabled = true;
        }

        private void txtMedicalID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSearchID_Click(object sender, EventArgs e)
        {
            if(txtMedicalID.Text=="")
            {
                MessageBox.Show("You must fill text Box!","Info",MessageBoxButtons.OK,MessageBoxIcon.Information); return;
            }

            clsMedicals Medical = clsMedicals.FindMedicalByID(Convert.ToInt32(txtMedicalID.Text));
            if(Medical==null)
            {
                MessageBox.Show("No Medical with this ID in Sys, You must check if it exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ctrMedicalRecordInfo1.GetObjectAndLoadData(Medical);
        }

        private void rdMedicalQR_CheckedChanged(object sender, EventArgs e)
        {
            gbQR.Visible = true;
            gbID.Visible = false;
        }

        private void ctrFindMedicalRecordInStorage_Load(object sender, EventArgs e)
        {
            rdMedicalQR.Checked = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gbID.Visible = true;
            gbQR.Visible = false;
        }
    }
}
