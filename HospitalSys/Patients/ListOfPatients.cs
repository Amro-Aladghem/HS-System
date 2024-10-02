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

namespace HospitalSys.Patients
{
    public partial class ListOfPatients : Form
    {
        public ListOfPatients()
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
            dataGridView1.DataSource = clsPateints.GetAllPatientInSys();
            lbRecord.Text = dataGridView1.RowCount.ToString();
        }

        private DataTable _LoadData()
        {
            DataTable dt = new DataTable();
            dt = clsPateints.GetAllPatientInSys();
            return dt;
        }







        private void cbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxFilter.SelectedIndex == 0)
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
                if (cbxFilter.SelectedIndex == 1)
                {
                    if (!_CheckIfValueIsValied(filterValue))
                    {
                        MessageBox.Show("The Value is not Valied!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                    }


                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format($"{filterColumn}={filterValue}");
                    lbRecord.Text = dataGridView1.RowCount.ToString();

                }
                else
                { 
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", filterColumn, filterValue);
                    lbRecord.Text = dataGridView1.RowCount.ToString();
                }

            }
            else
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Empty; // إلغاء الفلتر
                lbRecord.Text = dataGridView1.RowCount.ToString();
            }
        }

        private void ListOfPatients_Load(object sender, EventArgs e)
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
            AddUpdate_Patient frm = new AddUpdate_Patient();
            frm.ShowDialog();
            _ReffreshData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count!=1)
            {
                MessageBox.Show("You must select 1 one Patient!","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

            clsPateints Patient = clsPateints.FindPatientByID((int)dataGridView1.CurrentRow.Cells[0].Value);
            AddUpdate_Patient frm = new AddUpdate_Patient(Patient);
            frm.ShowDialog();
            _ReffreshData();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            FindPatient frm = new FindPatient();
            frm.ShowDialog();
        }

        private void updatePatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsPateints Patient = clsPateints.FindPatientByID((int)dataGridView1.CurrentRow.Cells[0].Value);
            AddUpdate_Patient frm = new AddUpdate_Patient(Patient);
            frm.ShowDialog();
            _ReffreshData();

        }

        private void patientInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsPateints Patient = clsPateints.FindPatientByID((int)dataGridView1.CurrentRow.Cells[0].Value);
            PatientInfo frm = new PatientInfo(Patient);
            frm.ShowDialog();

        }

        private void deletePatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure to delete this Patient from Sys , All Information will be deleted","Warrning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2)==DialogResult.Cancel)
            {
                return;
            }

            if(MessageBox.Show("Are you sure to continue!","Warnning",MessageBoxButtons.OKCancel)==DialogResult.Cancel)
            {
                return;
            }

            if(!clsPateints.DeletePatient((int)dataGridView1.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("There is Somthing Error!,Please Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _ReffreshData();


        }
    }
}
