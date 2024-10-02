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

namespace HospitalSys.Managers
{
    public partial class AddNewManager : Form
    {
        int UserID;
        int SectionID;

        clsManagers Manager = new clsManagers();
        public AddNewManager()
        {
            InitializeComponent();
        }


        private void LoadDataToCbx(DataTable dt)
        {
            foreach(DataRow dr in dt.Rows)
            {
                cbxSections.Items.Add(dr[0]);
            }

            cbxSections.SelectedIndex = 0;
        }



        private void txtUserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text == "")
            {
                MessageBox.Show("You must Fill Text Box!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            clsUsers User=clsUsers.FindUserByID(Convert.ToInt32(txtUserID.Text));
            if(User == null)
            {
                MessageBox.Show("No User with This ID","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            groupBox2.Enabled = true;
            UserID = User.UserID;
            btnSave.Enabled = true;

        }

        private void AddNewManager_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                var data = clsHSInformation.GetAllSectionsInSys();

                this.Invoke((Action)(() =>
                {
                    LoadDataToCbx(data);
                }));

            });
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to add this Manager!", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.Cancel)
            {
                return;
            }

            Manager.UserID = UserID;
            Manager.SectionID = SectionID;
            if(!Manager.Save())
            {
                MessageBox.Show("There is Something Error,Please Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("The Process has been Done Successfully!");
            btnSave.Enabled = false;
        }

        private void cbxSections_SelectedIndexChanged(object sender, EventArgs e)
        {
            SectionID = clsHSInformation.GetSectionTypeIDByName(cbxSections.Text);
        }
    }
}
