using clsBusineesLayer;
using SecurityLayer;
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
    public partial class ChangePassword : UserControl
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        clsUsers User;

        public void SetUser(clsUsers User)
        {
            this.User = User;
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void txtOldPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtOldPassword.Text != Security.Decrypt(User.Password))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtOldPassword, "This Passoword Not Correct!");
            }
            else
            {
                txtNewPassword.Enabled = true;
                txtConfirmPassword.Enabled = true;
                e.Cancel = false;
                errorProvider1.SetError(txtOldPassword, "");
                btnSave.Enabled = true;
            }
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            txtConfirmPassword.Clear();
        }

        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNewPassword, "You must fill it!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNewPassword, "");
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "You must Fill it!");
            }
            else if (txtConfirmPassword.Text != txtNewPassword.Text)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "The Password does not match!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtConfirmPassword, "");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                return;
            }

            if(txtConfirmPassword.Text!=txtNewPassword.Text)
            {
                MessageBox.Show("The Password does not match!");
                return;
            }


            if(!clsUsers.ChangePassword(User.UserID,txtNewPassword.Text))
            {
                MessageBox.Show("Somting Error,The Process has been Cancled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("The Process has been done Successfully!");
            btnSave.Enabled = false;


        }
    }
}
