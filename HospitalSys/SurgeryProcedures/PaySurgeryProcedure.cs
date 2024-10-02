using clsBusineesLayer;
using HospitalSys.Loging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static clsBusineesLayer.clsPayments;

namespace HospitalSys.SurgeryProcedures
{
    public partial class PaySurgeryProcedure : Form
    {

        int PatientID = -1;

        decimal PaidAmount = 0;
        decimal ReturnAmount = 0;

        decimal TotalAmount;

        clsPayments NewPayment = new clsPayments();
        public PaySurgeryProcedure(decimal TotalAmount,int PatientID)
        {
            InitializeComponent();
            this.PatientID = PatientID;
            this.TotalAmount = TotalAmount;
        }


        private void txtPaidAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                return;
            }

            PaidAmount = Convert.ToDecimal(txtPaidAmount.Text);

            decimal Different = PaidAmount - TotalAmount;
            if (Different > 0)
            {
                ReturnAmount = Different;
                lbReturn.Text = ReturnAmount.ToString() + "JD";
            }

            btnSave.Enabled = true;
        }

        private void PaySurgeryProcedure_Load(object sender, EventArgs e)
        {
            lbTotalAmount.Text = TotalAmount.ToString();
        }

        private void _LoadDataToObject()
        {
            NewPayment.PaidAmount = PaidAmount;
            NewPayment.ReturnAmount=ReturnAmount;
            NewPayment.PayReasonID = (int)ePayReason.Surgery;
            NewPayment.PatientID = PatientID;
            NewPayment.UserID = clsGlobal.User.UserID;
            NewPayment.Note = " ";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You sure to continue?", "Warnning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }

            _LoadDataToObject();

            if (!NewPayment.Save())
            {
                MessageBox.Show("There is somthing Error,The Process has been Cancled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("The Process has been done Successfully!");

            


            this.Close();
        }
    }
}
