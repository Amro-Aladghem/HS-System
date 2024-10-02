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
    public partial class ctrRecordInfo : UserControl
    {
        public ctrRecordInfo()
        {
            InitializeComponent();
        }

        clsPatientRecords Record;

        public void _GetObjectAndLoadData(clsPatientRecords Record)
        {
            this.Record = Record;
            _LoadDataToForm();
        }

        private void _LoadDataToForm()
        {
            lbRecordID.Text = Record.RecordID.ToString();
            lbPatientID.Text = Record.PatientID.ToString();
            lbDateOfArraivel.Text = Record.DateOfArraivel.ToShortDateString();
            txtSymptoms.Text = Record.Symptoms;
            txtDiagnosis.Text = Record.Dignosis;
            lbDoctorID.Text = Record.DoctorAssignedID.ToString();
            lbRoomNum.Text = Record.RoomID == null ? "without" : clsHSInformation.GetRoomNumberByID((int)Record.RoomID).ToString();
            lbIsLeaved.Text = Record.IsLeaved ? "Yes" : "No";
            lbLeavedDate.Text = Record.IsLeaved ? Convert.ToDateTime(Record.DateTimeOfLeaved).ToShortDateString() : "No Yet";
            lbChanging.Visible = Record.IsLeaved ? false : true;
        }

        private void _SetNewObject(clsPatientRecords Record)
        {
            this.Record = Record;
            _LoadDataToForm();
        }


        private void ctrRecordInfo_Load(object sender, EventArgs e)
        {

        }

        private void lbChanging_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UpdatePatientRecord frm = new UpdatePatientRecord(Record);
            frm.AfterChangingDataBack += _SetNewObject;
            frm.ShowDialog();
        }
    }
}
