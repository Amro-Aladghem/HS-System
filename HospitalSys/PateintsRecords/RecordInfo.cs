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
    public partial class RecordInfo : Form
    {
        public RecordInfo(clsPatientRecords Record)
        {
            InitializeComponent();
            this.Record = Record;
        }

        clsPatientRecords Record;

        private void RecordInfo_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
              

                this.Invoke((Action)(() =>
                {
                    ctrRecordInfo1._GetObjectAndLoadData(Record);
                }));

            });
        }

        private void btnExits_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
