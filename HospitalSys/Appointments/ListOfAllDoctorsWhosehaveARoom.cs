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
    public partial class ListOfAllDoctorsWhosehaveARoom : Form
    {

        int OldDoctorID = -1;

        public ListOfAllDoctorsWhosehaveARoom()
        {
            InitializeComponent();
        }


        public ListOfAllDoctorsWhosehaveARoom(int OldDoctorID)
        {
            InitializeComponent();
            this.OldDoctorID = OldDoctorID;
        }


        public delegate void AfterChoosing(int DoctorID);
        public AfterChoosing AfterChoosingDataBack;

        private DataTable _LoadData()
        {
            DataTable dt = new DataTable();
            dt = clsAppointments.GetAllDoctorsWhoseHaveARoom();
            return dt;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListOfAllDoctorsWhosehaveARoom_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                var data = _LoadData();

                this.Invoke((Action)(() =>
                {
                    dataGridView1.DataSource = data;
                }));

            });
        }

        private void chooseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if((int)dataGridView1.CurrentRow.Cells[0].Value==OldDoctorID)
            {
                MessageBox.Show("This is the current Doctor ,if You want to make change ,choose different one!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            AfterChoosingDataBack?.Invoke((int)dataGridView1.CurrentRow.Cells[0].Value);
            this.Close();
        }
    }
}
