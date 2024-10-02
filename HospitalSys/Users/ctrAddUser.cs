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
using SecurityLayer;

namespace HospitalSys.Users
{
    public partial class ctrAddUser : UserControl
    {

        enum ePersonType { Doctor=0,Nurse=1,OtherEmployee=2};
        ePersonType PersonType;

        int PersonID;

        clsUsers NewUser = new clsUsers();

        public ctrAddUser()
        {
            InitializeComponent();
        }


        private int GetTotalNumberofPermisions()
        {
            int Total = 0;
            int Counter = 1;

            for (int i = 0; i <= 11; i++)
            {
                if (cbPermision.GetItemChecked(i))
                {
                    Total += Counter;
                }

                Counter *= 2;
            }

            return Total;
        }

        private bool PerformSearchProcess()
        {
            int ID = Convert.ToInt32(txtEnterID.Text);

            if(PersonType == ePersonType.Doctor)
            {
                clsDoctors Doctor = clsDoctors.FindDoctorByID(ID);
                if(Doctor == null)
                {
                    return false;
                }

                PersonID = Doctor.DoctorID;
                return true;
            }
            else if(PersonType == ePersonType.Nurse)
            {
                clsNurses Nurse = clsNurses.FindNurseByID(ID);
                if(Nurse == null)
                {
                    return false;
                }

                PersonID = Nurse.NurseID;
                return true;
            }
            else
            {
                clsOtherEmployee Employee = clsOtherEmployee.FindEmployeeByID(ID);
                if(Employee==null)
                {
                    return false;
                }

                PersonID= Employee.EmployeeID;
                return true;
            }
        }

        private void txtEnterID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }



        private void ctrAddUser_Load(object sender, EventArgs e)
        {
            cbxPositions.SelectedIndex = 0;
        }

        private void cbxPositions_SelectedIndexChanged(object sender, EventArgs e)
        {
            PersonType = (ePersonType)cbxPositions.SelectedIndex;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtEnterID.Text=="")
            {
                MessageBox.Show("You must Fill the Text Box!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(!PerformSearchProcess())
            {
                MessageBox.Show("No Person with this ID,Please Try another one!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lbPerson.Text = PersonID.ToString();
            gbUser.Enabled = true;

            btnSearch.Enabled = false;

           

        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtUserName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "You must Fill it!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUserName, "");
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "You must Fill it!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPassword, "");
            }
        }

        private void _PutPersonIDValueInNewUser()
        {
            switch(PersonType)
            {
                case ePersonType.Doctor:
                    {
                        NewUser.DoctorID = PersonID; break;
                    }
                case ePersonType.Nurse:
                    {
                        NewUser.NurseID= PersonID; break;   
                    }
                case ePersonType.OtherEmployee:
                    {
                        NewUser.EmployeeID = PersonID;break;
                    }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!ValidateChildren())
            {
                return;
            }

            if(MessageBox.Show("Are You sure to Add this User In System!","Question",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.Cancel) 
            { return; }

            NewUser.UserName = txtUserName.Text;
            NewUser.Password=Security.Encrypt(txtPassword.Text);
            NewUser.IsActive = cbActive.Checked;
            NewUser.Permistion = GetTotalNumberofPermisions();
            _PutPersonIDValueInNewUser();

            if(!NewUser.Save())
            {
                MessageBox.Show("There is somthing Error!,The Process has been Canceled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btnSave.Enabled = false;
            lbUserID.Text = NewUser.UserID.ToString();

            MessageBox.Show("The Process has been done Successfully!");
        }
    }
}
