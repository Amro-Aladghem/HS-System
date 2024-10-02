using clsBusineesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalSys.Nurses
{
    public partial class ctrNurseInfoWithFilter : UserControl
    {
        public ctrNurseInfoWithFilter()
        {
            InitializeComponent();
        }

        clsNurses Nurse;




        private void txtIDSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ctrNurseInfoWithFilter_Load(object sender, EventArgs e)
        {
            rdNurseID.Checked = true;
        }

        private void btnNameSearch_Click(object sender, EventArgs e)
        {
            if(txtFirstName.Text==""|| txtLastName.Text=="")
            {
                MessageBox.Show("You must Fill all of Text Box!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Nurse = clsNurses.FindNurseByName(txtFirstName.Text, txtLastName.Text);
            if(Nurse==null)
            {
                MessageBox.Show("No Nurse With this Name!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            ctrNurseInfo1.GetObjectAndLoadData(Nurse);
        }

        private void btnIDSearch_Click(object sender, EventArgs e)
        {
            if(txtIDSearch.Text=="")
            {
                MessageBox.Show("You must Fill text Box", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Nurse=clsNurses.FindNurseByID(Convert.ToInt32(txtIDSearch.Text));
            if (Nurse == null)
            {
                MessageBox.Show("No Nurse With this ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ctrNurseInfo1.GetObjectAndLoadData(Nurse);

        }

        private void rdNurseID_CheckedChanged(object sender, EventArgs e)
        {
            gbNurseID.Visible = true;
            groupBox1.Visible = false;
        }

        private void rdName_CheckedChanged(object sender, EventArgs e)
        {
            gbNurseID.Visible = false;
            groupBox1.Visible = true;
        }
    }
}
