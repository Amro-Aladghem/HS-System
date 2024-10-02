using clsBusineesLayer;
using HospitalSys.Doctors;
using HospitalSys.PateintsRecords;
using HospitalSys.Patients;
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
    public partial class PatientsRecordsList : Form
    {
        public PatientsRecordsList()
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
            dataGridView1.DataSource = clsPatientRecords.GetAllPatientsRecordsInSys();
            lbRecords.Text = dataGridView1.RowCount.ToString();
        }

        private DataTable _LoadData()
        {
            DataTable dt = new DataTable();
            dt = clsPatientRecords.GetAllPatientsRecordsInSys();
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
            else if (cbxFilter.SelectedIndex == 8)
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
                lbRecords.Text = dataGridView1.RowCount.ToString();
            }
            else if (cbxActive.SelectedIndex == 2)
            {
                filterValue = "0";
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("{0}={1}", filterColumn, filterValue);
                lbRecords.Text = dataGridView1.RowCount.ToString();
            }
            else
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Empty; // إلغاء الفلتر
                lbRecords.Text = dataGridView1.RowCount.ToString();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string filterColumn = cbxFilter.SelectedItem.ToString();
            string filterValue = txtFilter.Text;

            // تطبيق الفلترة على DataTable
            if (!string.IsNullOrEmpty(filterValue))
            {
                if (cbxFilter.SelectedIndex>3)
                {
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", filterColumn, filterValue);
                    lbRecords.Text = dataGridView1.RowCount.ToString();
                }
                else
                {

                    if (!_CheckIfValueIsValied(filterValue))
                    {
                        MessageBox.Show("The Value is not Valied!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                    }


                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format($"{filterColumn}={filterValue}");
                    lbRecords.Text = dataGridView1.RowCount.ToString();
                }

            }
            else
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Empty; // إلغاء الفلتر
                lbRecords.Text = dataGridView1.RowCount.ToString();
            }
        }

        private void PatientsRecords_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                var data = _LoadData();

                this.Invoke((Action)(() =>
                {
                    dataGridView1.DataSource = data;
                    lbRecords.Text = dataGridView1.RowCount.ToString();
                    cbxFilter.SelectedIndex = 0;
                }));

            });
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNewPatientRecordHS frm = new AddNewPatientRecordHS();
            frm.ShowDialog();
            _ReffreshData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count!=1)
            {
                MessageBox.Show("You must Choose 1 one Record!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
            }

            clsPatientRecords Record = clsPatientRecords.FindRecordByID((int)dataGridView1.CurrentRow.Cells[0].Value);
            if(Record.IsLeaved)
            {
                MessageBox.Show("You can't Update this Record because it was Ended", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            UpdatePatientRecord frm = new UpdatePatientRecord(Record);
            frm.ShowDialog();
            _ReffreshData();

        }

        private void updateRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsPatientRecords Record = clsPatientRecords.FindRecordByID((int)dataGridView1.CurrentRow.Cells[0].Value);

            UpdatePatientRecord frm = new UpdatePatientRecord(Record);
            frm.ShowDialog();
            _ReffreshData();
        }

        private void recordInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsPatientRecords Record = clsPatientRecords.FindRecordByID((int)dataGridView1.CurrentRow.Cells[0].Value);

            RecordInfo frm =new RecordInfo(Record);
            frm.ShowDialog();
            _ReffreshData();
        }

        private void isPatientLeavedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if((bool)dataGridView1.CurrentRow.Cells[7].Value)
            {
                MessageBox.Show("Yes This Patient has been Leaved the HS in this Record!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("No This Patient does not leave from HS", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dischargePatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to discharge this Patient from HS?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Cancel)
            {
                return;
            }

            if(!clsPatientRecords.DischargePatient((int)dataGridView1.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("There is Somting Error,You cant make this Process!","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _ReffreshData();
        }

        private void deleteRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if((bool)dataGridView1.CurrentRow.Cells[7].Value)
            {
                MessageBox.Show("You can't delete this Patient Record, Because it is Active!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error); return;
            }

            if (MessageBox.Show("Are you sure to delete this Patient from HS?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Cancel)
            {
                return;
            }

            if(!clsPatientRecords.DeletePatientRecord((int)dataGridView1.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("There is Somting Error,You cant make this Process!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _ReffreshData();

        }

        private void patientInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsPateints Patient=clsPateints.FindPatientByID((int)dataGridView1.CurrentRow.Cells[1].Value);

            PatientInfo frm = new PatientInfo(Patient);
            frm.ShowDialog();

        }

        private void doctorInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsDoctors Doctor = clsDoctors.FindDoctorByID((int)dataGridView1.CurrentRow.Cells[4].Value);

            DoctorInfo frm =new DoctorInfo(Doctor);
            frm.ShowDialog();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            ToolStripItem Item = contextMenuStrip1.Items[0];
            ToolStripItem Item2 = contextMenuStrip1.Items[3];

            if ((bool)dataGridView1.CurrentRow.Cells[7].Value)
            {
                Item.Enabled = false;
                Item2.Enabled = false;
            }
            else
            {
                Item.Enabled = true;
                Item2.Enabled = true;
            }

        }
    }
}
