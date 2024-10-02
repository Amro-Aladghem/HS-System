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
using static clsBusineesLayer.clsPersons;

namespace HospitalSys.Patients
{
    public partial class PatientInfo : Form
    {
        clsPateints Patient;
        public PatientInfo(clsPateints pateint)
        {
            InitializeComponent();
            this.Patient = pateint;
        }

        private void PatientInfo_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {


                this.Invoke((Action)(() =>
                {
                    ctrPatientInfo1.GetObjectAndLoadData(Patient); 
                }));

            });
        }

        private void btnExits_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
