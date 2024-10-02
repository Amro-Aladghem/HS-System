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

namespace HospitalSys.PateintsRecords
{
    public partial class PatientsRecordHistory : Form
    {
        public PatientsRecordHistory()
        {
            InitializeComponent();
        }


        private void btnExits_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            {
                MessageBox.Show("You must fill The text Box with National Num", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataTable dt = new DataTable();
            dt = clsPatientRecords.GetAllRecordsForSpecificPatient(textBox1.Text);

            if (dt == null)
            {
                MessageBox.Show("This Person dose not have any record in the sys!","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                MessageBox.Show("You must Add this Person as Patient !");
                btnAddPatient.Enabled = true;
                btnAddRecord.Enabled = false;
                dataGridView1.DataSource = null;
                return;
            }

            dataGridView1.DataSource = dt;
            btnAddPatient.Enabled = false;
            btnAddRecord.Enabled = true;
        }

        private void recordInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsPatientRecords Record = clsPatientRecords.FindRecordByID((int)dataGridView1.CurrentRow.Cells[0].Value);
            RecordInfo frm = new RecordInfo(Record);
            frm.ShowDialog();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                if (Clipboard.ContainsText())
                {
                    textBox1.Text = Clipboard.GetText();
                }
                e.Handled = true; 
            }
        }

        private void rdNationalNum_CheckedChanged(object sender, EventArgs e)
        {
            gbNationaNum.Visible = true;
            gbPatient.Visible = false;
        }

        private void rdPatientID_CheckedChanged(object sender, EventArgs e)
        {
            gbPatient.Visible = true;
            gbNationaNum.Visible = false;
        }

        private void txtPatientID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnPatientIDSearch_Click(object sender, EventArgs e)
        {
            if (txtPatientID.Text == "")
            {
                MessageBox.Show("You must fill The text Box with National Num", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataTable dt = new DataTable();
            dt = clsPatientRecords.GetAllRecordsForSpecificPatientByID(Convert.ToInt32(txtPatientID.Text));

            if (dt.Rows.Count==0)
            {
                MessageBox.Show("This Person dose not have any record in the sys!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("You must Add this Person as Patient !");
                btnAddPatient.Enabled = true;
                btnAddRecord.Enabled = false;
                dataGridView1.DataSource = null;
                return;
            }

            dataGridView1.DataSource = dt;
            btnAddPatient.Enabled = false;
            btnAddRecord.Enabled = true;
        }

        private void PatientsRecordHistory_Load(object sender, EventArgs e)
        {
            rdNationalNum.Checked = true;
        }
    }
}
