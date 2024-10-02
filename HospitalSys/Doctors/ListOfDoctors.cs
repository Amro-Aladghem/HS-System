using clsBusineesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static clsBusineesLayer.clsPersons;

namespace HospitalSys.Doctors
{
    public partial class ListOfDoctors : Form
    {
        public ListOfDoctors()
        {
            InitializeComponent();
        }

        private void _ReffreshData()
        {
            dataGridView1.DataSource = clsDoctors.GetAllDoctorInSys();
            lbRecord.Text=dataGridView1.RowCount.ToString();    
        }

        private DataTable _LoadData()
        {
            DataTable dt = new DataTable();
            dt = clsDoctors.GetAllDoctorInSys();
            return dt;
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
            else if (cbxFilter.SelectedIndex == 5 ^ cbxFilter.SelectedIndex == 6)
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

        private void ListOfDoctors_Load(object sender, EventArgs e)
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

        private bool _CheckIfValueIsValied(string value)
        {
            if(int.TryParse(value,out int x))
            {
                return true;
            }

            return false;
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
                string filterColumn = cbxFilter.SelectedItem.ToString();
                string filterValue = txtFilter.Text;

                // تطبيق الفلترة على DataTable
                if (!string.IsNullOrEmpty(filterValue))
                {
                    if (cbxFilter.SelectedIndex == 2 || cbxFilter.SelectedIndex == 3)
                    {
                        (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", filterColumn, filterValue);
                        lbRecord.Text = dataGridView1.RowCount.ToString();
                    }
                    else
                    {

                       if (!_CheckIfValueIsValied(filterValue))
                       {
                          MessageBox.Show("The Value is not Valied!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error); return;
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

        private void updateDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsDoctors Doctor = clsDoctors.FindDoctorByID((int)dataGridView1.CurrentRow.Cells[0].Value);
            AddUpdateDoctor frm = new AddUpdateDoctor(Doctor);
            frm.ShowDialog();
            _ReffreshData();
        }

        private void doctorInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsDoctors Doctor = clsDoctors.FindDoctorByID((int)dataGridView1.CurrentRow.Cells[0].Value);
            DoctorInfo frm = new DoctorInfo(Doctor);
            frm.Show();
        }

        private void deleteDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure to delete this Doctor?","Warnning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }

            if(!clsDoctors.DeleteDoctor((int)dataGridView1.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("The Process has been Cancled ,Somting Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _ReffreshData();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUpdateDoctor frm = new AddUpdateDoctor();
            frm.ShowDialog();
            _ReffreshData();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            FindDoctor frm =new FindDoctor();
            frm.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count!=1)
            {
                MessageBox.Show("You must select 1 Doctor !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            clsDoctors Doctor = clsDoctors.FindDoctorByID((int)dataGridView1.CurrentRow.Cells[0].Value);
            AddUpdateDoctor frm = new AddUpdateDoctor(Doctor);
            frm.ShowDialog();
            _ReffreshData();

        }
    }
}
