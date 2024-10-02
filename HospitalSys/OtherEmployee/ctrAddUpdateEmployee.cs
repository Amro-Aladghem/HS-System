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
    public partial class ctrAddUpdateEmployee : UserControl
    {
        enum eMode { AddNew=1,Update=2};
        eMode Mode;

        public class clsAfterSave : EventArgs
        {
            public clsOtherEmployee Employee { get; set; }
            public clsAfterSave(clsOtherEmployee employee)
            {
                Employee = employee;
            }


        }

        public event EventHandler<clsAfterSave> OnSaveClick;


        clsOtherEmployee Employee;


        public ctrAddUpdateEmployee()
        {
            InitializeComponent();
            Mode = eMode.AddNew;
            Employee=new clsOtherEmployee();
        }

        private void _PerformCbxSections(DataTable dt)
        {
            foreach (DataRow dr in dt.Rows)
            {
                cbSection.Items.Add(dr["SectionName"]);
            }

            cbSection.SelectedIndex = 0;
        }

        private void _PerformCbxJobRole(DataTable dt)
        {
            foreach (DataRow dr in dt.Rows)
            {
                cbJobType.Items.Add(dr["RoleName"]);
            }

            cbJobType.SelectedIndex = 0;
        }

        public void LoadDataToCbxs(DataTable cbxSectionData, DataTable cbxJobRoleData)
        {
            _PerformCbxSections(cbxSectionData);
            _PerformCbxJobRole(cbxJobRoleData);
        }

        private void _LoadDataToForm()
        {
            if(Employee!=null)
            {
                lbEmployeeID.Text = Employee.EmployeeID.ToString();
                txtFirstName.Text = Employee.Firstname;
                txtSecondName.Text = Employee.SecondName;
                txtLastName.Text = Employee.LastName;
                txtPhone.Text = Employee.PhoneNum;
                txtEmail.Text = Employee.Email;
                txtNationalNum.Text = Employee.NationalNum;
                dateTimeBirth.Value = Employee.DateOfBirth;
                numaricSalary.Value = Employee.Salary;

                cbJobType.Text = clsHSInformation.GetJobRoleNameByID(Employee.RolesJobID);
                rdMale.Checked =Employee.Gendor==false?true:false;
                rdFemale.Checked = Employee.Gendor ? true : false;
                cbSection.Text = clsHSInformation.GetSectionNameByID(Employee.SectionTypeID);

                gbFullName.Enabled = false;
                dateTimeBirth.Enabled = false;
                rdFemale.Enabled = false;
                rdMale.Enabled = false;
                txtNationalNum.ReadOnly = true;

            }

        }

        public void GetObjectAndLoadData(clsOtherEmployee Employee)
        {
            this.Employee = Employee;
            Mode = eMode.Update;
            _LoadDataToForm();
        }


        private void _LoadDataToObject()
        {
            if (Mode == eMode.AddNew)
            {
                Employee.Firstname = txtFirstName.Text;
                Employee.SecondName = txtSecondName.Text;
                Employee.LastName = txtLastName.Text;
                Employee.NationalNum = txtNationalNum.Text;
                Employee.DateOfBirth = dateTimeBirth.Value;
                Employee.Gendor = rdMale.Checked ? false : true;
            }

            Employee.PhoneNum = txtPhone.Text;
            Employee.Email = txtEmail.Text;
            Employee.SectionTypeID = clsHSInformation.GetSectionTypeIDByName(cbSection.Text);
            Employee.Salary = numaricSalary.Value;
            Employee.RolesJobID = clsHSInformation.GetJobRoleIDByName(cbJobType.Text);
        }


        private void ctrAddUpdateEmployee_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                return;
            }

            if (MessageBox.Show("Are You Sure to Add/Update this Doctor?", "Warnning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                MessageBox.Show("The Procedss Cancled!");
                return;
            }

            _LoadDataToObject();

            if (!Employee.Save())
            {
                MessageBox.Show("Somting Error , The Process has been Cancled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("The Process has been Done Successsfully!");
            Mode = eMode.Update;
            lbEmployeeID.Text = Employee.EmployeeID.ToString();

            OnSaveClick?.Invoke(sender, new clsAfterSave(Employee));

            gbFullName.Enabled = false;
            dateTimeBirth.Enabled = false;
            rdFemale.Enabled = false;
            rdMale.Enabled = false;
            txtNationalNum.ReadOnly = true;
        }





        //Valideation Stage------------------------------------------------------

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSecondName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFirstName, "You must Fill it!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFirstName, "");
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtLastName, "You must Fill it!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtLastName, "");
            }
        }

        private void txtPhone_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPhone, "You must Fill it!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPhone, "");
            }
        }

        private void txtNationalNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNationalNum_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNationalNum.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNationalNum, "You must Fill it!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNationalNum, "");
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!txtEmail.Text.Contains("@gmail.com") && txtEmail.Text != "")
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "This Email Not valied!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtEmail, "");
            }
        }

        private void dateTimeBirth_Validating_1(object sender, CancelEventArgs e)
        {
            if ((DateTime.Now.Year - dateTimeBirth.Value.Year) < 24)
            {
                e.Cancel = true;
                errorProvider1.SetError(dateTimeBirth, "Invalied Date, The Age must at least 24 and above!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(dateTimeBirth, "");
            }
        }

        private void numaricSalary_Validating_1(object sender, CancelEventArgs e)
        {
            if (numaricSalary.Value == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(numaricSalary, "The Salary must be above 0 JO");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(numaricSalary, "");
            }
        }




    }
}
