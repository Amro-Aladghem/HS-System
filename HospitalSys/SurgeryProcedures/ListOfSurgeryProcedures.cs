using clsBusineesLayer;
using HospitalSys.Doctors;
using HospitalSys.Nurses;
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

namespace HospitalSys.SurgeryProcedures
{
    public partial class ListOfSurgeryProcedures : Form
    {
        public ListOfSurgeryProcedures()
        {
            InitializeComponent();
        }

        private void _ReffreshData()
        {
            dataGridView1.DataSource = clsSurgery.GetAllSurgeryProcedureInSys();
            lbRecords.Text = dataGridView1.RowCount.ToString();
        }

        private DataTable _LoadData()
        {
            DataTable dt = new DataTable();
            dt = clsSurgery.GetAllSurgeryProcedureInSys();
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
            else if (cbxFilter.SelectedIndex == 9)
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
               
                    if (!_CheckIfValueIsValied(filterValue))
                    {
                        MessageBox.Show("The Value is not Valied!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                    }


                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format($"{filterColumn}={filterValue}");
                    lbRecords.Text = dataGridView1.RowCount.ToString();
                
            }
            else
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Empty; // إلغاء الفلتر
                lbRecords.Text = dataGridView1.RowCount.ToString();
            }
        }

        private void ListOfSurgeryProcedures_Load(object sender, EventArgs e)
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count==0)
            {
                return;
            }

            string filterValue = dateTimePicker1.Value.ToString("dd-MM-yyyy");
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"DateOfProcedure = '{filterValue}'";
            lbRecords.Text = dataGridView1.RowCount.ToString();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNewSurgeryProcedureAppointment frm = new AddNewSurgeryProcedureAppointment();
            frm.ShowDialog();

            _ReffreshData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count!=1)
            {
                MessageBox.Show("You must select 1 one Record!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            clsSurgery Surgery = clsSurgery.FindSurgeryProcedureByID((int)dataGridView1.CurrentRow.Cells[0].Value);
            AddNewSurgeryProcedureAppointment frm = new AddNewSurgeryProcedureAppointment(Surgery);
            frm.ShowDialog();

            _ReffreshData();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            FindSurgeryProcedure frm = new FindSurgeryProcedure();
            frm.ShowDialog();

        }

        private void updateProcedureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsSurgery Surgery = clsSurgery.FindSurgeryProcedureByID((int)dataGridView1.CurrentRow.Cells[0].Value);
            AddNewSurgeryProcedureAppointment frm = new AddNewSurgeryProcedureAppointment(Surgery);
            frm.ShowDialog();

            _ReffreshData();
        }

        private void procedureInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsSurgery Surgery = clsSurgery.FindSurgeryProcedureByID((int)dataGridView1.CurrentRow.Cells[0].Value);
            SurgeryProcedureInfo frm = new SurgeryProcedureInfo(Surgery);
            frm.ShowDialog();
        }

        private void deleteProcedureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Sure to delete this Procedure!","Warnning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.Cancel) 
            {
                return;
            }

            if(!clsSurgery.DeleteSurgeryProcedureRecord((int)dataGridView1.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("There is Somthing Error,The Process has been Cancled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _ReffreshData();


        }

        private void paientInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsPateints Patient = clsPateints.FindPatientByID((int)dataGridView1.CurrentRow.Cells[8].Value);

            PatientInfo frm = new PatientInfo(Patient);
            frm.ShowDialog();
        }

        private void docotr1InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsDoctors Doctor = clsDoctors.FindDoctorByID((int)dataGridView1.CurrentRow.Cells[3].Value);

            DoctorInfo frm = new DoctorInfo(Doctor);
            frm.ShowDialog();
        }

        private void doctor2InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(dataGridView1.CurrentRow.Cells[4].Value.ToString()))
            {
                MessageBox.Show("There is no doctor!");
                return;
            }

            clsDoctors doctor= clsDoctors.FindDoctorByID((int)dataGridView1.CurrentRow.Cells[4].Value);

            DoctorInfo frm = new DoctorInfo(doctor);
            frm.ShowDialog();
        }

        private void doctor3InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dataGridView1.CurrentRow.Cells[5].Value.ToString()))
            {
                MessageBox.Show("There is no doctor!");
                return;
            }

            clsDoctors doctor = clsDoctors.FindDoctorByID((int)dataGridView1.CurrentRow.Cells[5].Value);

            DoctorInfo frm = new DoctorInfo(doctor);
            frm.ShowDialog();
        }

        private void nurse1InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsNurses Nurse = clsNurses.FindNurseByID((int)dataGridView1.CurrentRow.Cells[6].Value);

            NurseInfo frm = new NurseInfo(Nurse);
            frm.ShowDialog();
        }

        private void nurse2InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dataGridView1.CurrentRow.Cells[7].Value.ToString()))
            {
                MessageBox.Show("There is no nurse!");
                return;
            }

            clsNurses Nurse = clsNurses.FindNurseByID((int)dataGridView1.CurrentRow.Cells[7].Value);

            NurseInfo frm = new NurseInfo(Nurse);
            frm.ShowDialog();

        }

        private void makeItFinishedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(DateTime.Now.Date<(DateTime)dataGridView1.CurrentRow.Cells[1].Value)
            {
                MessageBox.Show("You Can't Finish it , The date is not coming", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(DateTime.Now.Date == (DateTime)dataGridView1.CurrentRow.Cells[1].Value)
            {
                if(DateTime.Now.TimeOfDay<= (TimeSpan)dataGridView1.CurrentRow.Cells[2].Value)
                {
                    MessageBox.Show("You Can't Finish it,The Time is not begin or it is eual it!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if(!clsSurgery.FinishTheSurgeryProcedure((int)dataGridView1.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("There is Something Error,The Process has been Cancled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _ReffreshData();

        }

        private void patientsProceduresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllSurgeryProcedureForPaients frm = new AllSurgeryProcedureForPaients((int)dataGridView1.CurrentRow.Cells[8].Value);
            frm.ShowDialog();
        }

        private void payProcedureCostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if((bool)dataGridView1.CurrentRow.Cells[12].Value)
            {
                MessageBox.Show("This Surgey Cost was Paid!");
                return;
            }

            decimal Cost = clsSurgery.GetSurgeryTypeCostByID((int)dataGridView1.CurrentRow.Cells[9].Value);

            PaySurgeryProcedure frm = new PaySurgeryProcedure(Cost, (int)dataGridView1.CurrentRow.Cells[8].Value);
            frm.ShowDialog();

            List<int> list = new List<int>() { (int)dataGridView1.CurrentRow.Cells[0].Value };
            clsPateints.MakeSurgeysPaidForPatient(list);

            _ReffreshData();
        }
    }
}
