using clsBusineesLayer;
using HospitalSys.Doctors;
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
    public partial class ctrAddNewPatientRecordHS : UserControl
    {

        bool IsDoctorChoosen = false;

        int? RoomID;
        int DoctorID;
        int PatientID;

        clsPatientRecords NewRecord=new clsPatientRecords();

        public class OnSaveClick : EventArgs
        {
            public clsPatientRecords PatientReocrd { get; set; }

            public OnSaveClick(clsPatientRecords patientReocrd)
            {
                PatientReocrd = patientReocrd;
            }
        }


        public event EventHandler<OnSaveClick> AfterSaveClick;

        public ctrAddNewPatientRecordHS()
        {
            InitializeComponent();
        }

        private void _SetRoomID()
        {
            RoomID = clsHSInformation.GetRoomIDByRoomNumber(Convert.ToInt32(cbxRoomNum.Text));
        }

        private void _LoadDataToCbxRoom()
        {
            DataTable dt =new DataTable();
            dt = clsHSInformation.GetAllAvailableRoomForPatients();

            foreach(DataRow dr in dt.Rows)
            {
                cbxRoomNum.Items.Add(dr["RoomNumber"]);
            }

            cbxRoomNum.SelectedIndex = 0;
        }

        private void _SetDoctorID(int DoctorID)
        {
            this.DoctorID = DoctorID;
            lbDoctorID.Text = DoctorID.ToString();
        }

        public void GetPatientIDAndPerformSearchProcess(int PatientID)
        {
            txtPatientID.Text=PatientID.ToString();
            btnSearch_Click(null, null);
        }


        private void txtPatientID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSymptoms_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtSymptoms.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtSymptoms, "You must Fill it!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtSymptoms, "");
            }
        }

        private void ctrAddNewPatientRecordHS_Load(object sender, EventArgs e)
        {

        }

        private void lbDoctorID_Validating(object sender, CancelEventArgs e)
        {
            if(lbDoctorID.Text=="N/A")
            {
                e.Cancel = true;
                errorProvider1.SetError(lbDoctorID, "You must Choose Doctor");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(lbDoctorID, "");
            }
        }

        private void cbWithRoom_CheckedChanged(object sender, EventArgs e)
        {
            if(cbWithRoom.Checked)
            {
                gbRoom.Enabled = true;
                if(cbxRoomNum.Items.Count==0)
                {
                    _LoadDataToCbxRoom();
                }
            }
            else
            {
                gbRoom.Enabled = false;
                RoomID = null;
            }
        }

        private void lbChoosingDoctor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AllAvailableDoctor frm = new AllAvailableDoctor();
            frm.AfterChoosingDataBack += _SetDoctorID;
            frm.ShowDialog();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtPatientID.Text=="")
            {
                MessageBox.Show("You must fill text Box!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
            }

            clsPateints Patient = clsPateints.FindPatientByID(Convert.ToInt32(txtPatientID.Text));
            if(Patient==null)
            {
                MessageBox.Show("No Patient With This ID!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error); 
                gbInformations.Enabled = false;
                gbRoom.Enabled =false;
                btnSave.Enabled = false;
                return;
            }

            if (clsPatientRecords.IsPatientHasAnActiveRecord(Patient.PatinetID))
            {
                MessageBox.Show("This Patient Has already an avtive Record , You Can't Add New", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                gbInformations.Enabled = false;
                gbRoom.Enabled = false;
                btnSave.Enabled = false;
                return; 
            }

            ctrPatientInfo1.GetObjectAndLoadData(Patient);
            gbInformations.Enabled = true;
          
            btnSave.Enabled = true;

            this.PatientID = Patient.PatinetID;
            btnSearch.Enabled = false;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!ValidateChildren())
            {
                return;
            }

            if(IsDoctorChoosen==false)
            {
                MessageBox.Show("You must select The Assigned Doctor!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if(MessageBox.Show("Are You sure to Add New Record For this Patient!","Warnning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.Cancel)
            {
                return;
            }

            NewRecord.PatientID = PatientID;
            NewRecord.Symptoms = txtSymptoms.Text;
            NewRecord.Dignosis = txtDiagnosis.Text;
            NewRecord.DoctorAssignedID = DoctorID;
            NewRecord.RoomID = RoomID;

            if(!NewRecord.Save())
            {
                MessageBox.Show("There is Somthin Error,The Process has been cancled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("The Process has been done Successfully!");


            AfterSaveClick?.Invoke(sender, new OnSaveClick(NewRecord));
        }

       

        private void cbxRoomNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SetRoomID();
        }

        private void lbDoctorID_TextChanged(object sender, EventArgs e)
        {
            IsDoctorChoosen = true;
        }
    }
}
