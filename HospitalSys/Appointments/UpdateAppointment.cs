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
    public partial class UpdateAppointment : Form
    {
        public UpdateAppointment(clsAppointments Appointment)
        {
            InitializeComponent();
            this.Appointment = Appointment;
        }

        clsAppointments Appointment;


        private void UpdateAppointment_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {

                this.Invoke((Action)(() =>
                {
                    ctrUpdateAppointment1.GetObjectAndLoadData(Appointment);
                }));

            });
        }

        private void ctrUpdateAppointment1_OnSaveClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
