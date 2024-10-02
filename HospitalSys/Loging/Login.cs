using clsBusineesLayer;
using HospitalSys.Properties;
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

namespace HospitalSys.Loging
{
    public partial class Login : Form
    {
        enum eShowPassword { Yes=1,No=2}
        eShowPassword ShowPassword = eShowPassword.Yes;


        public Login()
        {
            InitializeComponent();
        }

        private void PictureEyeBox_Click(object sender, EventArgs e)
        {
            if(ShowPassword==eShowPassword.Yes) 
            {
                PictureEyeBox.Image = Resources.hidden;
                txtPassword.PasswordChar = '*';
                ShowPassword = eShowPassword.No;
            }
            else
            {
                PictureEyeBox.Image = Resources.eye;
                txtPassword.PasswordChar = '\0';
                ShowPassword = eShowPassword.Yes;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text=="" || txtPassword.Text=="")
            {
                MessageBox.Show("You must Fill all Text Box After Login", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                return;
            }

            clsUsers User=clsUsers.FindUserByName(txtUserName.Text);

            if(User==null)
            {
                MessageBox.Show("UserName is not correct!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (User.IsActive == false)
            {
                MessageBox.Show("This User Not Acitve , you can't login!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Security.Decrypt(User.Password)!=txtPassword.Text)
            {                                  
                MessageBox.Show("Password is not correct!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            clsGlobal.SetCurrentUser(User);
            MainForm frm = new MainForm(this);
            this.Hide();
            frm.ShowDialog();


            if (cbRememberme.Checked)
            {
                LoginRegistry.DeleteDataFromRegsetry();
                LoginRegistry.SetDataToRegsetry(txtUserName.Text, txtPassword.Text);
            }
            else
            {
                LoginRegistry.DeleteDataFromRegsetry();
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {
            string value1="", value2="";

            LoginRegistry.GetDataFromRegsetry(ref value1, ref value2);
            if(value1!=null && value2!=null)
            {
                txtPassword.Text = value2;
                txtUserName.Text = value1;
            }

        }
    }
}
