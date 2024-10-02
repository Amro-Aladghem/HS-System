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

namespace HospitalSys
{
    public partial class QuiqPayment : Form
    {
        decimal TotalAmount = 0.0M;
        decimal ReturnAmount = 0.0M;
        decimal PaidAmount = 0.0M;
        int PatientID;

        clsPatientRecords PatientRecord;

        bool PatientIDOnly = true;

        public delegate void IsPaymentDone(bool isDone);
        public IsPaymentDone IsPaymentDoneDataBack;


        clsPayments NewPayment = new clsPayments();
        public QuiqPayment(decimal TotalAmount,clsPatientRecords PatientRecord)
        {
            InitializeComponent();
            this.TotalAmount = TotalAmount;
            this.PatientRecord = PatientRecord;
            PatientIDOnly = false;
        }

        public QuiqPayment(decimal TotalAmount, int PatientID)
        {
            InitializeComponent();
            this.TotalAmount = TotalAmount;
            this.PatientID = PatientID;
        }


        private void txtPaidAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void QuiqPayment_Load(object sender, EventArgs e)
        {
            lbTotalAmount.Text = TotalAmount.ToString() + "JD";
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

        }

        private void _LoadDataToObject()
        {

            NewPayment.PaidAmount = PaidAmount;
            NewPayment.ReturnAmount = ReturnAmount;
            NewPayment.Note = "";
            NewPayment.UserID = clsGlobal.User.UserID;

            if(PatientIDOnly)
            {
                NewPayment.PatientRecordID = null;
                NewPayment.PayReasonID = ((int)ePayReason.Appointment);
                NewPayment.PatientID = PatientID;
            }
            else
            {
                NewPayment.PatientRecordID = PatientRecord.RecordID;
                NewPayment.PayReasonID = ((int)ePayReason.LapTest);
                NewPayment.PatientID = PatientRecord.PatientID;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You sure to continue?","Warnning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.Cancel)
            {
                return;
            }

            _LoadDataToObject();

            if(!NewPayment.Save())
            {
                MessageBox.Show("There is somthing Error,The Process has been Cancled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("The Process has been done Successfully!");

            IsPaymentDoneDataBack?.Invoke(true);

            this.Close();


        }
    }
}
