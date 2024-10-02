using clsBusineesLayer;
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

namespace HospitalSys.Payments
{
    public partial class ListOfAllPaymentTransactons : Form
    {
        public ListOfAllPaymentTransactons()
        {
            InitializeComponent();
        }


        private void _ReffreshData()
        {
            dataGridView1.DataSource = clsPayments.GetAllPaymentRecordsInSys();
        }

        private DataTable _LoadData()
        {
            DataTable dt = new DataTable();
            dt = clsPayments.GetAllPaymentRecordsInSys();
            return dt;
        }

        private void ListOfAllPaymentTransactons_Load(object sender, EventArgs e)
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
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("{0} = {1}", filterColumn, filterValue);

            }
            else
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Empty; // إلغاء الفلتر
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                return;
            }

            string filterValue = dateTimePicker1.Value.ToString("dd-MM-yyyy");
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"DateOfProcedure = '{filterValue}'";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsPayments Payment = clsPayments.FindPaymentByID((int)dataGridView1.CurrentRow.Cells[0].Value);
            PaymentInfo frm = new PaymentInfo(Payment);
            frm.ShowDialog();
        }

        private void paitentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsPateints Patient = clsPateints.FindPatientByID((int)dataGridView1.CurrentRow.Cells[8].Value);
            PatientInfo frm = new PatientInfo(Patient);
            frm.ShowDialog();
        }

        private void deleteRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You sure to delete this Record!","Warnning",MessageBoxButtons.OK,MessageBoxIcon.Warning)==DialogResult.Cancel)
            {
                return;
            }

            if(!clsPayments.DeletePaymentRecord((int)dataGridView1.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("There is something Error,The Process has been Cancled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _ReffreshData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewPayment frm = new AddNewPayment();
            frm.ShowDialog();
        }
    }
}
