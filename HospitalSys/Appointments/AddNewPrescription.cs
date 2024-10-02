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
    public partial class AddNewPrescription : Form
    {
        clsAppointments Appointment;
        int PatientRecordID;
        decimal cost;

        public AddNewPrescription(clsAppointments Appointment,int PatientRecordID)
        {
            InitializeComponent();
            this.Appointment = Appointment;
            this.PatientRecordID = PatientRecordID;
        }

        private void _LoadData()
        {
            lbAppointmentID.Text = Appointment.AppointmentID.ToString();
            cost = clsAppointments.GetAppointmentCostForADoctor(Appointment.DocotrID);
            lbCost.Text = cost.ToString() + "jd";
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewPrescription_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if(!clsAppointments.AddNewPrescription(Appointment.AppointmentID,txtDiscribtion.Text))
            {
                MessageBox.Show("There is somthing Error Please Try again!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }


            QuiqPayment frm = new QuiqPayment(cost, PatientRecordID);
            frm.ShowDialog();
            this.Close();
        }
    }
}
