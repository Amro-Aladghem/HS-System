using clsBusineesLayer;
using HospitalSys.Doctors;
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

namespace HospitalSys
{
    public partial class ListOfUsers : Form
    {
        public ListOfUsers()
        {
            InitializeComponent();
        }

        private bool _CheckIfValueIsValied(string value)
        {
            if (int.TryParse(value, out int x))
            {
                return true;
            }

            return false;
        }

        private void _ReffreshData()
        {
            dataGridView1.DataSource = clsUsers.GetAllUsersRecord();
            lbRecord.Text = dataGridView1.RowCount.ToString();
        }

        private DataTable _LoadData()
        {
            DataTable dt = new DataTable();
            dt = clsUsers.GetAllUsersRecord();
            return dt;
        }



        private void Users_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                var data = _LoadData();

                this.Invoke((Action)(() =>
                {
                    dataGridView1.DataSource = data;
                    lbRecord.Text = dataGridView1.RowCount.ToString();
                    cbxFilter.SelectedIndex = 0;
                }));

            });
        }


        private void cbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxFilter.SelectedIndex == 0)
            {
                txtFilter.Visible = false;
                txtFilter.Clear();
                cbxActive.SelectedIndex = 0;
                cbxActive.Visible = false;
            }
            else if (cbxFilter.SelectedIndex == 5 )
            {

                txtFilter.Visible = false;
                txtFilter.Clear();
                cbxActive.Visible = true;
                cbxActive.SelectedIndex = 0;
            }
            else
            {
                txtFilter.Visible = true;
                cbxActive.Visible = false;
                cbxActive.SelectedIndex = 0;
            }
        }

        private void cbxActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filterColumn = cbxFilter.SelectedItem.ToString();
            string filterValue;

            if (cbxActive.SelectedIndex == 1)
            {
                filterValue = "1";
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("{0}={1}", filterColumn, filterValue);
                lbRecord.Text = dataGridView1.RowCount.ToString();
            }
            else if (cbxActive.SelectedIndex == 2)
            {
                filterValue = "0";
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("{0}={1}", filterColumn, filterValue);
                lbRecord.Text = dataGridView1.RowCount.ToString();
            }
            else
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Empty; // إلغاء الفلتر
                lbRecord.Text = dataGridView1.RowCount.ToString();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string filterColumn = cbxFilter.SelectedItem.ToString();
            string filterValue = txtFilter.Text;

            // تطبيق الفلترة على DataTable
            if (!string.IsNullOrEmpty(filterValue))
            {
                if (cbxFilter.SelectedIndex == 2 )
                {
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", filterColumn, filterValue);
                    lbRecord.Text = dataGridView1.RowCount.ToString();
                }
                else
                {

                    if (!_CheckIfValueIsValied(filterValue))
                    {
                        MessageBox.Show("The Value is not Valied!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                    }


                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format($"{filterColumn}={filterValue}");
                    lbRecord.Text = dataGridView1.RowCount.ToString();
                }

            }
            else
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Empty; // إلغاء الفلتر
                lbRecord.Text = dataGridView1.RowCount.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNewUser frm = new AddNewUser();
            frm.ShowDialog();
            _ReffreshData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count!=1)
            {
                MessageBox.Show("You must select 1 one Person!");
                return;
            }

            clsUsers User = clsUsers.FindUserByID((int)dataGridView1.CurrentRow.Cells[0].Value);
            UpdateUser frm = new UpdateUser(User);
            frm.ShowDialog();
            _ReffreshData();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            FindUser frm = new FindUser();
            frm.ShowDialog();
            _ReffreshData();
        }

        private void updateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsUsers User = clsUsers.FindUserByID((int)dataGridView1.CurrentRow.Cells[0].Value);
            UpdateUser frm = new UpdateUser(User);
            frm.ShowDialog();
            _ReffreshData();
        }

        private void userInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsUsers User = clsUsers.FindUserByID((int)dataGridView1.CurrentRow.Cells[0].Value);
            UserInfo frm = new UserInfo(User);
            frm.ShowDialog();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You sure to delete this User?","Warnning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }

            if(!clsUsers.DeleteUser((int)dataGridView1.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("The Process has been Cancled,Somthing Error!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            _ReffreshData();
        }
    }
}
