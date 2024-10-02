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
    public partial class ctrBookANewLabTest : UserControl
    {
        clsLapTests NewLapTest = new clsLapTests();
        clsPatientRecords PatientRecord;

        bool IsPaid = false;

        public ctrBookANewLabTest()
        {
            InitializeComponent();
        }


        public void LoadDataToCbx(DataTable Data)
        {
            foreach(DataRow row in  Data.Rows)
            {
                cbxTestsTypes.Items.Add(row["LabTestName"]);
            }

            cbxTestsTypes.SelectedIndex = 0;
        }

        private void CheckIfPaymentIsDone(bool IsDone)
        {
            if(IsDone)
            {
                this.IsPaid = true;
                lbIsPaid.Text = "Yes";
                btnPay.Enabled = false;
            }
        }

        private void gbLapTest_Enter(object sender, EventArgs e)
        {

        }

        private void txtPatientRecordID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnRecordIDSearch_Click(object sender, EventArgs e)
        {
            if(txtPatientRecordID.Text=="")
            {
                MessageBox.Show("You must Fill Patient Record ID Text Box!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            PatientRecord = clsPatientRecords.FindRecordByID(Convert.ToInt32(txtPatientRecordID.Text));
            if(PatientRecord==null)
            {
                MessageBox.Show("No Record With This ID,Pleas Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            gbLapTest.Enabled = true;
            lbPaitentRecordID.Text = PatientRecord.RecordID.ToString();
            lbPatientID.Text = PatientRecord.PatientID.ToString();
            btnRecordIDSearch.Enabled = false;
        }

        private void ctrBookANewLabTest_Load(object sender, EventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            decimal cost = clsLapTests.GetTestCostByName(cbxTestsTypes.Text);
            if(cost==0)
            {
                MessageBox.Show("There is somthing Error In Connection!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            QuiqPayment frm = new QuiqPayment(cost, PatientRecord);
            frm.IsPaymentDoneDataBack += CheckIfPaymentIsDone;
            frm.ShowDialog();
        }

        private void _LoadDataToObject()
        {
            NewLapTest.PatientRecordID = PatientRecord.RecordID;
            NewLapTest.PatientID = PatientRecord.PatientID;
            NewLapTest.TestTypeID=clsLapTests.GetTestTypeIDByName(cbxTestsTypes.Text);
            NewLapTest.IsPaid = IsPaid;
            NewLapTest.DateOfTest = dateRequirdDate.Value;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You sure to continue?","Question:",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)==DialogResult.No)
            {
                return;
            }

            _LoadDataToObject();

            if(!NewLapTest.Save())
            {
                MessageBox.Show("There is somthing Error,The Process has been Cancled!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("The Process has been done successfully!");
            btnPay.Enabled = false;
            btnSave.Enabled = false;

        }
    }
}
