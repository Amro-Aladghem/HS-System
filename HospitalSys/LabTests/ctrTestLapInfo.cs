using clsBusineesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace HospitalSys.LabTests
{
    public partial class ctrTestLapInfo : UserControl
    {
        clsLapTests LapTest;

        bool IsHasFilePath = false;
        public ctrTestLapInfo()
        {
            InitializeComponent();
        }

        public void GetObjectAndLoadData(clsLapTests LapTest)
        {
            this.LapTest = LapTest;
            _LoadData();
        }

        private void _LoadData()
        {
            if(LapTest!=null)
            {
                lbTestID.Text = LapTest.TestID.ToString();
                lbPatientRecordID.Text = LapTest.PatientRecordID.ToString();
                lbPatientID.Text = LapTest.PatientID.ToString();
                lbTestType.Text = clsLapTests.GetTestTypeName(LapTest.TestTypeID);
                lbIsPaid.Text = LapTest.IsPaid ? "Yes" : "No";
                lbDate.Text = LapTest.DateOfTest.ToShortDateString();
                lbIsDone.Text=LapTest.IsDone ? "Yes" : "No";
                lbFilePath.Text = LapTest.FilePath == "" ? "No Set Yet" : LapTest.FilePath; 
                if(LapTest.FilePath!="")
                {
                    IsHasFilePath = true;
                }
            }
        }


        private void ctrTestLapInfo_Load(object sender, EventArgs e)
        {

        }

        private void lbFilePath_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(IsHasFilePath==false)
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
