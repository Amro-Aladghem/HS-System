using clsBusineesLayer;
using HospitalSys.Doctors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalSys.PateintsRecords
{
    public partial class ctrUpdatePatientRecordHS : UserControl
    {

        public class clsAfterChanging:EventArgs
        {
            public clsPatientRecords Record { get; set; }

            public clsAfterChanging(clsPatientRecords record)
            {
                Record = record;
            }
        }

        public event EventHandler<clsAfterChanging> OnSaveClick;



        public ctrUpdatePatientRecordHS()
        {
            InitializeComponent();
        }

        int DoctorID;
        int? RoomID;

        clsPatientRecords Record;


        private void _SetDoctorID(int DoctorID)
        {
            this.DoctorID = DoctorID;
            lbDoctorID.Text = DoctorID.ToString();
        }

        private void _LoadDataToCbxRoom()
        {
            DataTable dt = new DataTable();
            dt = clsHSInformation.GetAllAvailableRoomForPatients();

            cbxRoomsNumber.Items.Add("None");
            foreach (DataRow dr in dt.Rows)
            {
                cbxRoomsNumber.Items.Add(dr["RoomNumber"]);
            }

             cbxRoomsNumber.SelectedIndex = 0;
        }

        private void _SetRoomID()
        {
            RoomID = clsHSInformation.GetRoomIDByRoomNumber(Convert.ToInt32(cbxRoomsNumber.Text));
        }

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
            lbRoomNum.Text =Record.RoomID==null?"without": clsHSInformation.GetRoomNumberByID((int)Record.RoomID).ToString();
            DoctorID = (int)Record.DoctorAssignedID;
            RoomID = Record.RoomID == null ? null : Record.RoomID;
        }


        private void txtSymptoms_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtSymptoms.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtSymptoms, "You must fill it!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtSymptoms, "");
            }
        }

        private void txtDiagnosis_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtDiagnosis.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtDiagnosis, "You must Fill it!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtDiagnosis, "");
            }
        }

        private void ctrUpdatePatientRecordHS_Load(object sender, EventArgs e)
        {

        }

        private void lbChangingDoctor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AllAvailableDoctor frm =new AllAvailableDoctor();
            frm.AfterChoosingDataBack += _SetDoctorID;
            frm.ShowDialog();
        }

        private void cbChangeRoom_CheckedChanged(object sender, EventArgs e)
        {

            if (cbChangeRoom.Checked)
            {
                cbxRoomsNumber.Enabled = true;
                if (cbxRoomsNumber.Items.Count == 0)
                {
                    _LoadDataToCbxRoom();
                }
            }
            else
            {
                cbxRoomsNumber.Enabled = false;
                RoomID = Record.RoomID;
            }
        }

        private void cbxRoomsNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxRoomsNumber.SelectedIndex==0)
            {
                RoomID = null;
                return;
            }

            _SetRoomID();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!ValidateChildren())
            {
                return;
            }

            if(MessageBox.Show("Are you sure to Update this Reocrd?","Question",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.Cancel) 
            {
                MessageBox.Show("The Process has been Cancled!");
                return;
            }

            Record.Symptoms = txtSymptoms.Text;
            Record.Dignosis = txtDiagnosis.Text;
            Record.DoctorAssignedID = DoctorID;
            Record.RoomID = RoomID;
            Record.IsLeaved = cbIsLeaved.Checked;

            if(!Record.Save())
            {
                MessageBox.Show("There is Somthin Error,The Process has been cancled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("The Updating Process has been done Successfully!");
            OnSaveClick?.Invoke(sender, new clsAfterChanging(Record));

        }
    }
}
