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

namespace HospitalSys.Users
{
    public partial class ctrUpdateUser : UserControl
    {
        public ctrUpdateUser()
        {
            InitializeComponent();
        }

        clsUsers User;

        private int _GetPersonID()
        {
            if(User.DoctorID!=null)
            {
                return (int)User.DoctorID;
            }
            else if(User.NurseID!=null)
            {
                return (int)User.NurseID;
            }
            else
            {
                return(int)User.EmployeeID;
            }

        }

        private void CheckedThePermisionList()
        {
            int Counter = 1;

            for (int i = 0; i <= 11; i++)
            {
                if ((Counter & User.Permistion) == Counter)
                {
                    cbPermision.SetItemChecked(i, true);
                }

                Counter *= 2;
            }
        }

        private int GetTotalNumberofPermisions()
        {
            int Total = 0;
            int Counter = 1;

            for (int i = 0; i <=11; i++)
            {
                if (cbPermision.GetItemChecked(i))
                {
                    Total += Counter;
                }

                Counter *= 2;
            }

            return Total;
        }


        public void GetObjectAndLoad(clsUsers User)
        {
            this.User= User;
            _LoadDataToForm();
        }

        private void _LoadDataToForm()
        {
            if(User!=null)
            {
                txtUserName.Text = User.UserName;
                lbUserID.Text=User.UserID.ToString();
                txtPassword.Text = "*******";
                lbPerson.Text = _GetPersonID().ToString();
                cbActive.Checked = User.IsActive;
                CheckedThePermisionList();
            }
        }



        private void ctrUpdateUser_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                MessageBox.Show("You must Fill UserName Text Box!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are You sure to Udpate this User In System!", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            { return; }

            User.UserName= txtUserName.Text;
            User.IsActive = cbActive.Checked;
            User.Permistion = GetTotalNumberofPermisions();

            if(!User.Save())
            {
                MessageBox.Show("There is somthing Error!,The Process has been Canceled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("The Process has been done Successfully!", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void lbChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UpdatePaswords frm = new UpdatePaswords(User);
            frm.ShowDialog();
        }
    }
}
