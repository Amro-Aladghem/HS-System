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

namespace HospitalSys.OtherEmployee
{
    public partial class ctrFindEmployee : UserControl
    {
        public ctrFindEmployee()
        {
            InitializeComponent();
        }

        clsOtherEmployee Employee;



        private void txtIDSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnIDSearch_Click(object sender, EventArgs e)
        {
            if(txtIDSearch.Text=="")
            {
                MessageBox.Show("You must fill the Text Box !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Employee = clsOtherEmployee.FindEmployeeByID(Convert.ToInt32(txtIDSearch.Text));
            if(Employee== null)
            {
                MessageBox.Show("No Employee with this ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ctrEmployeInfo1.GetObjectAndLoadDataToForm(Employee);

        }

        private void btnNameSearch_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "" || txtLastName.Text == "")
            {
                MessageBox.Show("You must Fill all of Text Box!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Employee = clsOtherEmployee.FindEmployeeByName(txtFirstName.Text, txtLastName.Text);
            if(Employee==null)
            {
                MessageBox.Show("No Employee with this Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ctrEmployeInfo1.GetObjectAndLoadDataToForm(Employee);

        }

        private void rdNurseID_CheckedChanged(object sender, EventArgs e)
        {
            gbEmployeeID.Visible = true;
            groupBox1.Visible = false;
        }

        private void rdName_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            gbEmployeeID.Visible = false;
        }

        private void ctrFindEmployee_Load(object sender, EventArgs e)
        {
            rdNurseID.Checked = true;
        }
    }
}
