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
    public partial class ListOfMedicalTypeInSys : Form
    {
        public ListOfMedicalTypeInSys()
        {
            InitializeComponent();
        }

        private void _ReffreshData()
        {
            dataGridView1.DataSource = clsMedicals.GetAllMedicalsTypesInSys();
            lbRecords.Text = dataGridView1.RowCount.ToString();
        }

        private DataTable _LoadData()
        {
            DataTable dt = new DataTable();
            dt = clsMedicals.GetAllMedicalsTypesInSys();
            return dt;
        }

        private void btnExits_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListOfMedicalTypeInSys_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                var data = _LoadData();

                this.Invoke((Action)(() =>
                {
                    dataGridView1.DataSource = data;
                    lbRecords.Text = dataGridView1.RowCount.ToString();
                }));

            });
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string filterColumn = "MedicalName";
            string filterValue = txtFilter.Text;

            // تطبيق الفلترة على DataTable
            if (!string.IsNullOrEmpty(filterValue))
            {
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", filterColumn, filterValue);
                    lbRecords.Text = dataGridView1.RowCount.ToString();
               
            }
            else
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Empty; // إلغاء الفلتر
                lbRecords.Text = dataGridView1.RowCount.ToString();
            }
        }

        private void updateQRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUpdateMedicalInSys frm = new AddUpdateMedicalInSys((string)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _ReffreshData();
        }
    }
}
