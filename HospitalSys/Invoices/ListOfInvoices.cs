using clsBusineesLayer;
using HospitalSys.Patients;
using HospitalSys.Payments;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalSys.Invoices
{
    public partial class ListOfInvoices : Form
    {
        public ListOfInvoices()
        {
            InitializeComponent();
        }

        private void _ReffreshData()
        {
            dataGridView1.DataSource = clsInvoices.GetAllInvoiceRecordInSys();
        }

        private DataTable _LoadData()
        {
            DataTable dt = new DataTable();
            dt = clsInvoices.GetAllInvoiceRecordInSys();
            return dt;
        }



        private void showPatientInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsPatientRecords Record = clsPatientRecords.FindRecordByID((int)dataGridView1.CurrentRow.Cells[1].Value);
            clsPateints Patient = clsPateints.FindPatientByID(Record.PatientID);

            PatientInfo frm = new PatientInfo(Patient);
            frm.ShowDialog();
        }

        private void payInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((bool)dataGridView1.CurrentRow.Cells[4].Value)
            {
                MessageBox.Show("This Invoice was Paid");
                return;
            }

            clsPatientRecords Record = clsPatientRecords.FindRecordByID((int)dataGridView1.CurrentRow.Cells[1].Value);

            PayInvoice frm = new PayInvoice((decimal)dataGridView1.CurrentRow.Cells[2].Value, Record.PatientID);
            frm.ShowDialog();

            clsInvoices.MakeInvoicePaid((int)dataGridView1.CurrentRow.Cells[0].Value);
            _ReffreshData();

        }

        private void btnAddInvoice_Click(object sender, EventArgs e)
        {
            AddNewPayment frm = new AddNewPayment(true);
            frm.ShowDialog();

            _ReffreshData();
        }

        private void ListOfInvoices_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                var data = _LoadData();

                this.Invoke((Action)(() =>
                {
                    dataGridView1.DataSource = data;
                }));

            });
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
