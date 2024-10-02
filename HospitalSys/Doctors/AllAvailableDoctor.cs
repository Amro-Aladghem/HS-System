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

namespace HospitalSys.Doctors
{
    public partial class AllAvailableDoctor : Form
    {

        public delegate void AfterChoosing(int DoctorID);
        public AfterChoosing AfterChoosingDataBack;

        public AllAvailableDoctor()
        {
            InitializeComponent();
        }

        private DataTable _LoadData()
        {
            DataTable dt = new DataTable();
            dt = clsDoctors.GetAllAvailableDoctorInSys();
            return dt;
        }

        private void AllAvailableDoctor_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                var data = _LoadData();

                this.Invoke((Action)(() =>
                {
                    dataGridView1.DataSource = data;
                  cbxFilter.SelectedIndex = 0;
                }));

            });
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
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

            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", filterColumn, filterValue);
                  

            }
            else
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Empty; // إلغاء الفلتر
              
            }
        }

        private void chooseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AfterChoosingDataBack?.Invoke((int)dataGridView1.CurrentRow.Cells[0].Value);
            this.Close();
        }

    }
}
