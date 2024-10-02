using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalSys.PateintsRecords
{
    public partial class AddNewPatientRecordHS : Form
    {

     

        public AddNewPatientRecordHS()
        {
            InitializeComponent();
        }

        public AddNewPatientRecordHS(int PatientID)
        {
            InitializeComponent();
            ctrAddNewPatientRecordHS1.GetPatientIDAndPerformSearchProcess(PatientID);
        }


        private void AddNewPatientRecordHS_Load(object sender, EventArgs e)
        {

        }

        private void ctrAddNewPatientRecordHS1_OnSaveClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrAddNewPatientRecordHS1_Load(object sender, EventArgs e)
        {

        }

        private void ctrAddNewPatientRecordHS1_AfterSaveClick(object sender, ctrAddNewPatientRecordHS.OnSaveClick e)
        {
           
        }
    }
}
