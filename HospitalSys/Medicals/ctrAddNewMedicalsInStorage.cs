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
    public partial class ctrAddNewMedicalsInStorage : UserControl
    {
        private string MedicalQR;

        clsMedicals NewMedicalQuantity = new clsMedicals();

        public ctrAddNewMedicalsInStorage()
        {
            InitializeComponent();
        }


        private void ctrAddNewMedicalsInStorage_Load(object sender, EventArgs e)
        {

        }

        private void _LoadDataToObject()
        {
            NewMedicalQuantity.MedicalTypeQR = MedicalQR;
            NewMedicalQuantity.Quantity = (int)numaricQuantity.Value;
            NewMedicalQuantity.Price = numaricPrice.Value;
            NewMedicalQuantity.ProducedDate = dateTimePicker1.Value.Date;
            NewMedicalQuantity.ExpiaredDate = dateExpired.Value.Date;
        }


        private void btnMedicalQR_Click(object sender, EventArgs e)
        {
            if (txtMedicalQR.Text == "")
            {
                MessageBox.Show("You must Fill Text Box!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!clsMedicals.IsMedicalTypeExitsInSys(txtMedicalQR.Text))
            {
                MessageBox.Show("No Medical with this QR,Please Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MedicalQR = txtMedicalQR.Text;
            gbRecordInfo.Enabled = true;
            lbMedicalQR.Text = MedicalQR;


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!ValidateChildren())
            {
                return;
            }

            if(MessageBox.Show("Are You Sure to Add this Quantity of this Medical In Storage?","Question",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2)==DialogResult.Cancel)
            {
                return;
            }

            _LoadDataToObject();

            if(!NewMedicalQuantity.Save())
            {
                MessageBox.Show("Somthing Error,The Process has been Cancled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("The Process has been done successfully!/ you close this window now");
            lbMedicalID.Text = NewMedicalQuantity.MedicalID.ToString();
            btnSave.Enabled = false;

        }


        //Valedations----------------------------------------------------------------
        private void numaricQuantity_Validating(object sender, CancelEventArgs e)
        {
            if(numaricQuantity.Value <=0)
            {
                e.Cancel = true;
                errorProvider1.SetError(numaricQuantity, "The Quantity should above 0");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(numaricQuantity, "");
            }
        }

        private void numaricPrice_Validating(object sender, CancelEventArgs e)
        {
            if(numaricPrice.Value<=0)
            {
                e.Cancel = true;
                errorProvider1.SetError(numaricPrice, "The Price must be above 0 JD!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(numaricPrice, "");
            }
        }

        private void dateTimePicker1_Validating(object sender, CancelEventArgs e)
        {
            if(dateTimePicker1.Value.Date>=DateTime.Now.Date)
            {
                e.Cancel = true;
                errorProvider1.SetError(dateTimePicker1, "The Date is not valied!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(dateTimePicker1, "");
            }
        }

        private void dateExpired_Validating(object sender, CancelEventArgs e)
        {
            if(dateExpired.Value.Date<=dateTimePicker1.Value)
            {
                e.Cancel = true;
                errorProvider1.SetError(dateExpired, "The Expired Date must be bigger than ProducedDate!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(dateExpired, "");
            }
        }

        private void gbRecordInfo_Enter(object sender, EventArgs e)
        {

        }

        private void lbAddNewMedical_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddUpdateMedicalInSys frm = new AddUpdateMedicalInSys();
            frm.ShowDialog();
        }
    }
}
