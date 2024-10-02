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

namespace HospitalSys.Appointments
{
    public partial class ctrUpdateAppointment : UserControl
    {

        clsAppointments Appointment; 

        int NewDoctorID;

        bool IsDoctorChanged = false;

        bool IsResetClick = false;

        public event EventHandler OnSaveClick;
        public ctrUpdateAppointment()
        {
            InitializeComponent();
        }

        public void GetObjectAndLoadData(clsAppointments Appointment)
        {
            this.Appointment = Appointment;
            _LoadDataToForm();
        }

        private void _LoadDataToForm()
        {
            if(Appointment!=null)
            {
                txtFirstName.Text = Appointment.PersonFirstName;
                txtLastName.Text=Appointment.PersonLastName;
                txtPhone.Text = Appointment.PhoneNum;
                txtAddress.Text=Appointment.Address;
                lbDoctorID.Text = Appointment.DocotrID.ToString();
                dateOfAppointment.Value = Appointment.DateOfAppointment;
                TimeOfAppointment.Value = DateTime.Today.Add(Appointment.Time);
                lbAppointmentID.Text = Appointment.AppointmentID.ToString();
                cbIsActive.Checked = Appointment.IsAcitve;
            }
        }

        private void _SetNewDoctorID(int NewDoctorID)
        {
            this.NewDoctorID=NewDoctorID;
            lbDoctorID.Text = NewDoctorID.ToString();
            IsDoctorChanged = true;
            btnSave.Enabled = false;
            btnCheck.Enabled = true;
        }



        private void ctrUpdateAppointment_Load(object sender, EventArgs e)
        {
            btnCheck.Enabled = false;
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled= true;
            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if(txtPhone.Text=="")
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPhone, "You must Fill it!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPhone, "");
            }
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            if (txtAddress.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(txtAddress, "You must Fill it!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtAddress, "");
            }
        }

        private void lbChooseDoctor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ListOfAllDoctorsWhosehaveARoom frm = new ListOfAllDoctorsWhosehaveARoom(Appointment.DocotrID);
            frm.AfterChoosingDataBack += _SetNewDoctorID;
            frm.ShowDialog();
            btnCheck.Enabled = true;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                return;
            }

            TimeSpan Time = TimeOfAppointment.Value.TimeOfDay;
            DateTime Date = dateOfAppointment.Value.Date;
            int DoctorID = IsDoctorChanged ? NewDoctorID : Appointment.DocotrID;



            if (!clsAppointments.IsDoctorAvaialableForAppointment(DoctorID, Time, Date))
            {
                MessageBox.Show("This Doctor Not Available in this Date And Time", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbAppError.Visible = true;
                btnSave.Enabled = false;
                return;

            }

            lbAppError.Visible = false;
            btnSave.Enabled = true;
        }

        private void dateOfAppointment_ValueChanged(object sender, EventArgs e)
        {
            if (!IsResetClick)
            {
                btnCheck.Enabled = true;
                btnSave.Enabled = false;
            }
        }

        private void TimeOfAppointment_ValueChanged(object sender, EventArgs e)
        {
            if (!IsResetClick)
            {
                btnCheck.Enabled = true;
                btnSave.Enabled = false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            IsResetClick = true;

            NewDoctorID = default(int);
            IsDoctorChanged = false;
            lbDoctorID.Text = Appointment.DocotrID.ToString();

            dateOfAppointment.Value = Appointment.DateOfAppointment;
            TimeOfAppointment.Value = DateTime.Today.Add(Appointment.Time);

            lbAppError.Visible = false;

            btnCheck.Enabled = false;
            btnSave.Enabled = false;

        }

        private void _LoadDataToObject()
        {
            Appointment.DocotrID = IsDoctorChanged ? NewDoctorID : Appointment.DocotrID;
            Appointment.DateOfAppointment = dateOfAppointment.Value;
            Appointment.Time = TimeOfAppointment.Value.TimeOfDay;
            Appointment.PhoneNum = txtPhone.Text;
            Appointment.Address= txtAddress.Text;
            Appointment.IsAcitve = cbIsActive.Checked;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!ValidateChildren())
            {
                return;
            }

            if(MessageBox.Show("Are You sure to Update this Appointment!","Warnning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.Cancel)
            {
                MessageBox.Show("The Process has been Cancled!");
                return;
            }

            _LoadDataToObject();

            if(!Appointment.Save())
            {
                MessageBox.Show("There is somthing Error,The Process has been Cancled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("The Process has been Done Successfully!");

            btnSave.Enabled = false;
            btnCheck.Enabled = false;

            OnSaveClick?.Invoke(null, null);

        }
    }
}
