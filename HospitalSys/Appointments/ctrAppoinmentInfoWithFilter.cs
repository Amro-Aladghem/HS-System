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
    public partial class ctrAppoinmentInfoWithFilter : UserControl
    {
        public ctrAppoinmentInfoWithFilter()
        {
            InitializeComponent();
        }

    



        private void rdName_CheckedChanged(object sender, EventArgs e)
        {
            gbSearchID.Visible = false;
            groupBox1.Visible = true;
        }

        private void rdID_CheckedChanged(object sender, EventArgs e)
        {
            gbSearchID.Visible = true;
            groupBox1.Visible = false;
        }

        private void txtAppoinmentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAppointmentID_Click(object sender, EventArgs e)
        {
            if(txtAppoinmentID.Text=="")
            {
                MessageBox.Show("You must Fill the text box!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            clsAppointments Appointment = clsAppointments.FindAppointmentByID(Convert.ToInt32(txtAppoinmentID.Text));
            if(Appointment == null)
            {
                MessageBox.Show("No Appointment with this ID","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ctrAppointmentInfo1.GetObjectAndLoadData(Appointment);
        }

        private void btnSearchName_Click(object sender, EventArgs e)
        {
            if(txtFirstName.Text=="" || txtLastName.Text=="")
            {
                MessageBox.Show("You must Fill all text Box!");
                return;
            }

            clsAppointments Appointment = clsAppointments.FindAppointmentByPersonName(txtFirstName.Text, txtLastName.Text);
            if(Appointment==null)
            {
                MessageBox.Show("No Appointment with this Person Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ctrAppointmentInfo1.GetObjectAndLoadData(Appointment);
        }
    }
}
