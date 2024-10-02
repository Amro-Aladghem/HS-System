using clsBusineesLayer;
using HospitalSys.Users;
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
    public partial class ManagersList : Form
    {
        public ManagersList()
        {
            InitializeComponent();
        }

        private void _ReffreshData()
        {
            dataGridView1.DataSource = clsManagers.GetAllManagers();
        }

        private DataTable _LoadData()
        {
            DataTable dt = new DataTable();
            dt = clsManagers.GetAllManagers();
            return dt;
        }

        private void ManagersList_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                var data = _LoadData();

                this.Invoke((Action)(() =>
                {
                    dataGridView1.DataSource = data;
                }));

            });
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void userInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsUsers User = clsUsers.FindUserByID((int)dataGridView1.CurrentRow.Cells[1].Value);
            UserInfo frm = new UserInfo(User);
            frm.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure to delete this Manager!","Warnning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.Cancel)
            {
                return;
            }

            if(!clsManagers.DeleteManager((int)dataGridView1.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("There is Somthing Error,The Process has been Cancled!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _ReffreshData();
        }
    }
}
