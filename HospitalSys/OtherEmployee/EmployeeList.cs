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
    public partial class EmployeeList : Form
    {
        public EmployeeList()
        {
            InitializeComponent();
        }


        private void _ReffreshData()
        {
            dataGridView1.DataSource = clsOtherEmployee.GetAllEmployeesInSys();
            lbRecord.Text = dataGridView1.RowCount.ToString();
        }

        private DataTable _LoadData()
        {
            DataTable dt = new DataTable();
            dt =clsOtherEmployee.GetAllEmployeesInSys();
            return dt;
        }


        private void cbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxFilter.SelectedIndex== 0)
            {
                txtFilter.Visible = false;
                txtFilter.Clear();
            }
            else
            {
                txtFilter.Visible = true;
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string filterColumn = cbxFilter.SelectedItem.ToString();
            string filterValue = txtFilter.Text;

            // تطبيق الفلترة على DataTable
            if (!string.IsNullOrEmpty(filterValue))
            {
              (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", filterColumn, filterValue);
              lbRecord.Text = dataGridView1.RowCount.ToString();
                
            }
            else
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Empty; // إلغاء الفلتر
                lbRecord.Text = dataGridView1.RowCount.ToString();
            }

        }

        private void EmployeeList_Load(object sender, EventArgs e)
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUpdateEmployee frm = new AddUpdateEmployee();
            frm.ShowDialog();
            _ReffreshData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count!=1)
            {
                MessageBox.Show("You must select 1 one Employee!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            clsOtherEmployee Employee = clsOtherEmployee.FindEmployeeByID((int)dataGridView1.CurrentRow.Cells[0].Value);
            AddUpdateEmployee frm = new AddUpdateEmployee(Employee);
            frm.ShowDialog();
            _ReffreshData();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            FindEmployee frm = new FindEmployee();
            frm.Show();
            _ReffreshData();
        }

        private void updateEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsOtherEmployee Employee = clsOtherEmployee.FindEmployeeByID((int)dataGridView1.CurrentRow.Cells[0].Value);
            AddUpdateEmployee frm = new AddUpdateEmployee(Employee);
            frm.ShowDialog();
            _ReffreshData();
        }

        private void employeeInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsOtherEmployee Employee = clsOtherEmployee.FindEmployeeByID((int)dataGridView1.CurrentRow.Cells[0].Value);

            EmployeeInfo frm = new EmployeeInfo(Employee);
            frm.ShowDialog();
        }

        private void deleteEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this Nurse?", "Warnning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }

            if (!clsOtherEmployee.DeleteEmployee((int)dataGridView1.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("The Process has been Cancled ,Somting Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _ReffreshData();
        }
    }
}
