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
    public partial class AppointmentRecordInfo : Form
    {
        public AppointmentRecordInfo(clsAppointments Appointment)
        {
            InitializeComponent();
            this.Appointment = Appointment;
        }

        clsAppointments Appointment;


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AppointmentRecordInfo_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                this.Invoke((Action)(() =>
                {
                    ctrAppointmentInfo1.GetObjectAndLoadData(Appointment);
                }));

            });
        }
    }
}
