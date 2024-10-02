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
    public partial class ListOfAllActiveAppointmentForDoctor : Form
    {
        int DoctorID = -1;

        public ListOfAllActiveAppointmentForDoctor()
        {
            InitializeComponent();
        }

        public ListOfAllActiveAppointmentForDoctor(int DoctorID)
        {
            InitializeComponent();
            this.DoctorID= DoctorID;    
        }


        private void txtDoctorID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled= true;    
            }
        }

        private void ListOfAllActiveAppointmentForDoctor_Load(object sender, EventArgs e)
        {
            if(DoctorID!=-1)
            {
                Task.Run(() =>
                {
                    this.Invoke((Action)(() =>
                    {
                        txtDoctorID.Text = DoctorID.ToString();
                        btnSearch_Click(null, null);
                    }));

                });
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtDoctorID.Text=="")
            {
                MessageBox.Show("You must Fill The Text Box!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataTable dt = clsAppointments.GetAllActiveAppointmentForDoctor(Convert.ToInt32(txtDoctorID.Text));
            if(dt.Rows.Count==0)
            {
                MessageBox.Show("There is no Active Appointemnt for this Doctor!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataGridView1.DataSource = dt;
        }
    }
}
