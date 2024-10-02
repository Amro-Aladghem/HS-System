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

namespace HospitalSys.Payments
{
    public partial class PaymentInfo : Form
    {
        clsPayments Payment;
        public PaymentInfo(clsPayments Payment)
        {
            InitializeComponent();
            this.Payment = Payment;
        }
        private void _LoadData()
        {
            if(Payment!= null)
            {
                lbPatientID.Text = Payment.PatientID.ToString();
                lbPaymentID.Text = Payment.PaymentID.ToString();
                lbRecordID.Text=Payment.PatientRecordID.ToString();
                lbDate.Text = Payment.DateOfPayment.ToShortDateString();
                lbPaidAmount.Text= Payment.PaidAmount.ToString();
                lbReturnAmount.Text=Payment.ReturnAmount.ToString();
                lbUserID.Text = Payment.UserID.ToString();
                
            }
        }

        private void PaymentInfo_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
    }
}
