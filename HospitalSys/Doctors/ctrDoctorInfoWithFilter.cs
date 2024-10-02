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

namespace HospitalSys.Doctors
{
    public partial class ctrDoctorInfoWithFilter : UserControl
    {
        public ctrDoctorInfoWithFilter()
        {
            InitializeComponent();
        }

        clsDoctors Doctor;

        private void txtIDSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ctrDoctorInfoWithFilter_Load(object sender, EventArgs e)
        {
            rdDoctorID.Checked = true;
        }

        private void btnIDSearch_Click(object sender, EventArgs e)
        {
            if(txtIDSearch.Text=="")
            {
                MessageBox.Show("You must Enter Somting in Text Box!");
                return;
            }

            Doctor=clsDoctors.FindDoctorByID(Convert.ToInt32(txtIDSearch.Text));
            if(Doctor==null)
            {
                MessageBox.Show("No Doctor with this ID, Pleas Try another one","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            ctrDoctorInfo1.GetObjectAndLoadData(Doctor);
        }

        private void btnNameSearch_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == ""||txtLastName.Text=="")
            {
                MessageBox.Show("You must fill all Text Boxs!");
                return;
            }

            Doctor = clsDoctors.FindDoctorByName(txtFirstName.Text, txtLastName.Text);
            if (Doctor == null)
            {
                MessageBox.Show("No Doctor with this ID, Pleas Try another one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ctrDoctorInfo1.GetObjectAndLoadData(Doctor);
        }

        private void rdDoctorID_CheckedChanged(object sender, EventArgs e)
        {
            gbDoctorID.Visible = true;
            groupBox1.Visible = false;
        }

        private void rdName_CheckedChanged(object sender, EventArgs e)
        {
            gbDoctorID.Visible = false;
            groupBox1.Visible = true;
        }
    }
}
