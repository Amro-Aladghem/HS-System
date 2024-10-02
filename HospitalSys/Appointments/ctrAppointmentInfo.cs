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
    public partial class ctrAppointmentInfo : UserControl
    {
        clsAppointments Appointment;
        public ctrAppointmentInfo()
        {
            InitializeComponent();
        }

        public void GetObjectAndLoadData(clsAppointments Appointment)
        {
            this.Appointment= Appointment;
            _LoadDataToFrom();
        }

        private void _LoadDataToFrom()
        {
            if(Appointment != null)
            {
                lbAppointmentID.Text = Appointment.AppointmentID.ToString();
                lbPersonName.Text = Appointment.PersonFirstName + " " + Appointment.PersonLastName;
                lbDoctorID.Text=Appointment.DocotrID.ToString();
                lbIsActive.Text = Appointment.IsAcitve ? "Yes" : "No";
                lbDate.Text = Appointment.DateOfAppointment.ToShortDateString();
                lbTime.Text = Appointment.Time.ToString();
                txtAddress.Text = Appointment.Address;
                lbPhonNum.Text = Appointment.PhoneNum;
            }
        }

        private void ctrAppointmentInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
