using clsBusineesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalSys.LabTests
{
    public partial class ctrAddTheResultOfTest : UserControl
    {
        clsLapTests LapTest;

        string FilePath = "";

        bool IsPaid = false;

        public ctrAddTheResultOfTest()
        {
            InitializeComponent();
        }


        private void CheckIfPaymentIsDone(bool IsDone)
        {
            if (IsDone)
            {
                this.IsPaid = true;
                btnPay.Enabled = false;
            }
        }




        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            openFileDialog.Title = "Select a PDF file";


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;

                string targetDirectory = @"C:\LabTests";
                if (!Directory.Exists(targetDirectory))
                {
                    Directory.CreateDirectory(targetDirectory);
                }

                string fileName = $"Patient_{LapTest.PatientID}_{LapTest.DateOfTest:yyyy-MM-dd}.pdf";

                string destinationFilePath = Path.Combine(targetDirectory, fileName);

                File.Copy(selectedFilePath, destinationFilePath, true);

                MessageBox.Show("File saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FilePath = destinationFilePath;
                lbFilePath.Text = FilePath;
            }
        }

        private void ctrAddTheResultOfTest_Load(object sender, EventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            decimal cost = clsLapTests.GetTestCost(LapTest.TestTypeID);
            clsPatientRecords PatientRecord = clsPatientRecords.FindRecordByID(LapTest.PatientRecordID);

            if(cost==0 || PatientRecord==null)
            {
                MessageBox.Show("There is somthing Error In Connection!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            QuiqPayment frm = new QuiqPayment(cost, PatientRecord);
            frm.IsPaymentDoneDataBack += CheckIfPaymentIsDone;
            frm.ShowDialog();
        }

        private void ctrTestLapInfoWithFilter1_OnSearchClick(object sender, ctrTestLapInfoWithFilter.AfterSearchClick e)
        {
            LapTest = e.LapTest;
            gbSetFile.Enabled = true;
            btnPay.Enabled = LapTest.IsPaid ? false : true;
            btnSave.Enabled = true;
        }

        private void _LoadDataToObject()
        {
            LapTest.IsDone = true;
            LapTest.IsPaid = btnPay.Enabled ? IsPaid : true;
            LapTest.FilePath = FilePath;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(FilePath=="")
            {
                MessageBox.Show("You must Add The File!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _LoadDataToObject();

            if(!LapTest.Save())
            {
                MessageBox.Show("There is Somthing Error!,The Process has been Cancled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("The Process has been done Successfully!");
            btnPay.Enabled = false;
            btnSave.Enabled = false;
        }

        private void lbFilePath_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (FilePath=="")
            {
                return;
            }

            try
            {
                string filePath = lbFilePath.Text;
                // Open the file using the default application
                Process.Start(filePath);
            }
            catch (Exception ex)
            {
                // Handle the case where the file cannot be opened
                MessageBox.Show($"Error opening file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
