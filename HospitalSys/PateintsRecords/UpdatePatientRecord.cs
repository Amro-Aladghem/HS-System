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

namespace HospitalSys.PateintsRecords
{
    public partial class UpdatePatientRecord : Form
    {

        public delegate void AfterChanging(clsPatientRecords Record);
        public AfterChanging AfterChangingDataBack;

        public UpdatePatientRecord(clsPatientRecords patientRecords)
        {
            InitializeComponent();
            this.Record=patientRecords;
        }

        clsPatientRecords Record;

        private void UpdatePatientRecord_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                
                this.Invoke((Action)(() =>
                {
                    ctrUpdatePatientRecordHS1._GetObjectAndLoadData(Record);
                }));

            });
        }

        private void ctrUpdatePatientRecordHS1_OnSaveClick(object sender, ctrUpdatePatientRecordHS.clsAfterChanging e)
        {
            AfterChangingDataBack?.Invoke(Record);
            this.Close();
        }
    }
}
