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
    public partial class ctrUserInfoByFilter : UserControl
    {
        public ctrUserInfoByFilter()
        {
            InitializeComponent();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled=true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text=="")
            {
                MessageBox.Show("You must Fill Text Box!");
                return;
            }

            clsUsers User = clsUsers.FindUserByID(Convert.ToInt32(txtSearch.Text));
            if(User == null)
            {
                MessageBox.Show("No User With This ID","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            ctrUserInfo1.SetObject(User);

        }
    }
}
