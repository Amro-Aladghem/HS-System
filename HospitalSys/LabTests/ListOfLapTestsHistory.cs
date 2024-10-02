using clsBusineesLayer;
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

namespace HospitalSys.LabTests
{
    public partial class ListOfLapTestsHistory : Form
    {
        public ListOfLapTestsHistory()
        {
            InitializeComponent();
        }

        private void _ReffreshData()
        {
            dataGridView1.DataSource = clsLapTests.GetAllLabTestshistory();
            lbRecords.Text = dataGridView1.RowCount.ToString();
        }

        private DataTable _LoadData()
        {
            DataTable dt = new DataTable();
            dt = clsLapTests.GetAllLabTestshistory();
            return dt;
        }

        private bool _CheckIfValueIsValied(string value)
        {
            if (int.TryParse(value, out int x))
            {
                return true;
            }

            return false;
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
                if (cbxFilter.SelectedIndex ==4)
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

        private void ListOfLapTestsHistory_Load(object sender, EventArgs e)
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
            BookANewLapTest frm = new BookANewLapTest();
            frm.ShowDialog();
            _ReffreshData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            AddResultForTest frm = new AddResultForTest();
            frm.ShowDialog();
            _ReffreshData();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            FindLapTest frm = new FindLapTest();
            frm.ShowDialog();
        }

        private void addResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddResultForTest frm = new AddResultForTest();
            frm.ShowDialog();
            _ReffreshData();
        }

        private void testInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsLapTests Test = clsLapTests.FindTestRecordByID((int)dataGridView1.CurrentRow.Cells[0].Value);

            TestInfo frm = new TestInfo(Test);
            frm.ShowDialog();
        }

        private void paitentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsPateints Patient = clsPateints.FindPatientByID((int)dataGridView1.CurrentRow.Cells[2].Value);

            PatientInfo frm = new PatientInfo(Patient);
            frm.ShowDialog();
        }

        private void paitentRecordInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsPatientRecords Record = clsPatientRecords.FindRecordByID((int)dataGridView1.CurrentRow.Cells[1].Value);
            
             RecordInfo frm =new RecordInfo(Record);
            frm.ShowDialog();
        }

        private void deleteTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You sure to delete this Test,This Will Cancel it!","Warnning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2)==DialogResult.Cancel)
            {
                return;
            }

            if(!clsLapTests.DeleteTestLabRecord((int)dataGridView1.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("There is somthing Error,The Process has been Cancled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _ReffreshData();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if((bool)dataGridView1.CurrentRow.Cells[7].Value)
            {
                contextMenuStrip1.Items[0].Enabled = false;
            }
            else
            {
                contextMenuStrip1.Items[0].Enabled = true;
            }
        }

        private void allTestsForPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllTestsForPatient frm = new AllTestsForPatient((int)dataGridView1.CurrentRow.Cells[2].Value);
            frm.ShowDialog();
        }
    }
}
