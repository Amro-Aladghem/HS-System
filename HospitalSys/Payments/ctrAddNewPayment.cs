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
    public partial class ctrAddNewPayment : UserControl
    {
        enum eMode { Payment=1, Invoice=2}
        eMode Mode = eMode.Payment;

        List<int> TestIDs=new List<int>();
        List<int> SurgeryIDs = new List<int>();


        int PatientID;
        decimal TotalPrice =0;

        int NumberOfDays = 0;

        private  void _LoadDataToGridViews()
        {
            if(!clsPatientRecords.IsPatientHasAnActiveRecord(PatientID))
            {
                MessageBox.Show("This Patient Does not have an active Record", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

          
           var data1 = clsPateints.GetAllTestForPatientThatIsNotPaid(PatientID);
           var data2 = clsPateints.GetAllSurgeryProcederForPatientThatIsNotPaid(PatientID);
           var data3 = clsPateints.GetPatientRecord(PatientID);
          
          
          
           dataGridView1.DataSource = data1;
           dataGridView2.DataSource = data2;
           dataGridView3.DataSource = data3;
               

            if (string.IsNullOrEmpty(dataGridView3.Rows[0].Cells[8].Value.ToString()))
            {
                NumberOfDays = 0;
            }
            else
            {
                NumberOfDays = ((DateTime.Now.Date - ((DateTime)dataGridView3.Rows[0].Cells[2].Value).Date)).Days+1;
            }

            lbTotalNotPaidTest.Text = dataGridView1.Rows.Count.ToString();
            lbSurgeryProcedure.Text = dataGridView2.Rows.Count.ToString();

            lbNumberOfDaysInRoom.Text = NumberOfDays.ToString();

            btnCalculate.Enabled = true;
        }


        private void ChangePaidStauts()
        {
            for(int i=0;i<=dataGridView1.Rows.Count-1;i++)
            {
                TestIDs.Add((int)dataGridView1.Rows[i].Cells[0].Value);
            }

            for(int i=0;i<=dataGridView2.Rows.Count-1;i++)
            {
                SurgeryIDs.Add((int)dataGridView2.Rows[i].Cells[0].Value);
            }

            clsPateints.MakeTestsPaidForPatient(TestIDs);
            clsPateints.MakeSurgeysPaidForPatient(SurgeryIDs);
        }

        private bool Calculate()
        {
            decimal TestTotal = 0;
            decimal SurgeryTotal = 0;
            decimal RoomTotal = 0;

            TestTotal=clsPateints.GetTotalTestsCostForPatient(PatientID);
            SurgeryTotal = clsPateints.GetTotalSurgeryProcedureCostForPatient(PatientID);
            RoomTotal = NumberOfDays * 75;

            TotalPrice = TestTotal + SurgeryTotal + RoomTotal;

            if(TotalPrice==0)
            {
                return false;
            }

            lbTestAmount.Text = TestTotal.ToString() + "JD";
            lbSurgeryAmount.Text = SurgeryTotal.ToString() + "JD";
            lbRoomAmount.Text = RoomTotal.ToString() + "JD";

            lbTotalAmount.Text = TotalPrice.ToString() + "JD";
            return true;
        }

        public void SetInvoiceMode()
        {
            Mode = eMode.Invoice;
        }

        public ctrAddNewPayment()
        {
            InitializeComponent();
        }

        public ctrAddNewPayment(bool IsInvoice)
        {
            InitializeComponent();
            Mode = eMode.Invoice;
        }

        private void ctrAddNewPayment_Load(object sender, EventArgs e)
        {

        }


        private void txtPatientID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtPatientID.Text=="")
            {
                MessageBox.Show("You must Fill text Box!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            clsPateints Patient = clsPateints.FindPatientByID(Convert.ToInt32(txtPatientID.Text));
            if(Patient==null)
            {
                MessageBox.Show("No Patient with this ID!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            PatientID = Patient.PatinetID;
            _LoadDataToGridViews();

           
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (Calculate())
            {
                btnCalculate.Enabled = false;
                if (Mode == eMode.Invoice)
                {
                    btnMakeInvoice.Visible = true;
                    return;
                }

                btnPay.Enabled = true;

              
            }
            else
            {
                MessageBox.Show("This Patient does not have any Charg And Amount To Pay!\nYou can go to Patients Record and discharge it", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }


        private void btnPay_Click(object sender, EventArgs e)
        {
            DischargPay frm = new DischargPay(TotalPrice, PatientID);
            frm.ShowDialog();

            btnPay.Enabled = false;

            ChangePaidStauts();

            clsPatientRecords Record=clsPatientRecords.FindTheMostUpdateRecordForPatient(PatientID);
            clsPatientRecords.DischargePatient(Record.RecordID);
        }

        private void btnMakeInvoice_Click(object sender, EventArgs e)
        {
            clsInvoices Invoice = new clsInvoices();
            clsPatientRecords Record = clsPatientRecords.FindTheMostUpdateRecordForPatient(PatientID);

            Invoice.PatientRecordID = Record.RecordID;
            Invoice.TotalAmount = TotalPrice;
            Invoice.Date = DateTime.Now;
            Invoice.IsPaid = false;

            if(!Invoice.Save())
            {
                MessageBox.Show("There is Something Error,The Process has been Cancled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            MessageBox.Show("The Process has been Done Successfully!");
            btnMakeInvoice.Enabled = false;

        }
    }
}
