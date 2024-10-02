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

namespace HospitalSys.Medicals
{
    public partial class ListOfMedicalsInStorage : Form
    {
        public ListOfMedicalsInStorage()
        {
            InitializeComponent();
        }

        private void _ReffreshData()
        {
            dataGridView1.DataSource = clsMedicals.GetAllMedicalsInStorage();
            lbRecords.Text = dataGridView1.RowCount.ToString();
        }

        private DataTable _LoadData()
        {
            DataTable dt = new DataTable();
            dt = clsMedicals.GetAllMedicalsInStorage();
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
                if (cbxFilter.SelectedIndex == 1 )
                {
                    if (!_CheckIfValueIsValied(filterValue))
                    {
                        MessageBox.Show("The Value is not Valied!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                    }

                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format($"{filterColumn}={filterValue}");
                    lbRecords.Text = dataGridView1.RowCount.ToString();
                }
                else
                {
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", filterColumn, filterValue);
                    lbRecords.Text = dataGridView1.RowCount.ToString();
                }

            }
            else
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Empty; // إلغاء الفلتر
                lbRecords.Text = dataGridView1.RowCount.ToString();
            }
        }

        private void ListOfMedicalsInStorage_Load(object sender, EventArgs e)
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
            AddNewMedicalQuantityInStorage frm = new AddNewMedicalQuantityInStorage();
            frm.ShowDialog();
            _ReffreshData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count!=1)
            {
                MessageBox.Show("You must select 1 one Person!","info",MessageBoxButtons.OK,MessageBoxIcon.Information); return;
            }

            clsMedicals Medical = clsMedicals.FindMedicalByID((int)dataGridView1.CurrentRow.Cells[0].Value);

            UpdateMedicalInStorage frm = new UpdateMedicalInStorage(Medical);
            frm.ShowDialog();
            _ReffreshData();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            FindMedicalRecordInStorage frm = new FindMedicalRecordInStorage();
            frm.ShowDialog();
        }

        private void updateMedicalRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsMedicals Medical = clsMedicals.FindMedicalByID((int)dataGridView1.CurrentRow.Cells[0].Value);

            UpdateMedicalInStorage frm = new UpdateMedicalInStorage(Medical);
            frm.ShowDialog();
            _ReffreshData();
        }

        private void showInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsMedicals Medical = clsMedicals.FindMedicalByID((int)dataGridView1.CurrentRow.Cells[0].Value);

            MedicalRecordInfo frm = new MedicalRecordInfo(Medical);
            frm.ShowDialog();
        }

        private void deleteRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You sure to delete this Record?","Warnning!",MessageBoxButtons.OKCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)==DialogResult.Cancel)
            {
                return;
            }

            if(!clsMedicals.DeleteMedicalRecordFromStorage((int)dataGridView1.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("There is Somthing Error,The Process has been Cancled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _ReffreshData();

        }

        private void isExpiredToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsMedicals Medical = clsMedicals.FindMedicalByID((int)dataGridView1.CurrentRow.Cells[0].Value);

            if(Medical.ExpiaredDate.Date<DateTime.Now.Date)
            {
                MessageBox.Show("This Medical Qunatity is Expired!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            else
            {
                MessageBox.Show("This Medical Quntity is not Expired", "Info", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void changePriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsMedicals Medical = clsMedicals.FindMedicalByID((int)dataGridView1.CurrentRow.Cells[0].Value);

            ChangeMedicalQuantityPrice frm = new ChangeMedicalQuantityPrice(Medical);
            frm.ShowDialog();
            _ReffreshData();

        }

        private void getAllSotrageQuantityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllQuantityRecordsForMedical frm = new AllQuantityRecordsForMedical((string)dataGridView1.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
            _ReffreshData();
        }
    }
}
