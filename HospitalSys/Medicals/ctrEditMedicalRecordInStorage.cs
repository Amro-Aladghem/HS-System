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
    public partial class ctrEditMedicalRecordInStorage : UserControl
    {
        clsMedicals Medical;

        public ctrEditMedicalRecordInStorage()
        {
            InitializeComponent();
        }


        public void GetObjectAndLoadForm(clsMedicals Medical)
        {
            this.Medical= Medical;
            _LoadDataToForm();
        }

        private void _LoadDataToForm()
        {
            lbMedicalID.Text = Medical.MedicalID.ToString();
            lbMedicalQR.Text = Medical.MedicalTypeQR;
            numaricQuantity.Value = (decimal)Medical.Quantity;
            numaricPrice.Value=Medical.Price;
            dateTimePicker1.Value = Medical.ProducedDate;
            dateExpired.Value = Medical.ExpiaredDate;
        }

        private void ctrEditMedicalRecordInStorage_Load(object sender, EventArgs e)
        {

        }

        private void numaricQuantity_Validating(object sender, CancelEventArgs e)
        {
            if (numaricQuantity.Value <= 0)
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
            if (numaricPrice.Value <= 0)
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

        private void _LoadDataToObject()
        {
            Medical.Price = numaricPrice.Value;
           
            Medical.Quantity=(int)numaricQuantity.Value;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!ValidateChildren())
            {
                return;
            }

            if(MessageBox.Show("Are you sure to Update this Record?","Question",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.Cancel)
            {
                return;
            }

            _LoadDataToObject();

            if(!Medical.Save())
            {
                MessageBox.Show("Somthing Error,The Process has been Cancled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("The Process has been done Successfully!/you can close this window!");
            btnSave.Enabled = false;

        }
    }
}
