using clsBusineesLayer;
using HospitalSys.Doctors;
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

namespace HospitalSys.Appointments
{
    public partial class ListOfAppoointments : Form
    {
        clsPateints Patient;

        public ListOfAppoointments()
        {
            InitializeComponent();
        }

        private void _ReffreshData()
        {
            dataGridView1.DataSource = clsAppointments.GetAllAppointmentsInSys();
            lbRecord.Text = dataGridView1.RowCount.ToString();
        }

        private DataTable _LoadData()
        {
            DataTable dt = new DataTable();
            dt = clsAppointments.GetAllAppointmentsInSys();
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
            else if (cbxFilter.SelectedIndex == 7)
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
                lbRecord.Text = dataGridView1.RowCount.ToString();
            }
            else if (cbxActive.SelectedIndex == 2)
            {
                filterValue = "0";
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("{0}={1}", filterColumn, filterValue);
                lbRecord.Text = dataGridView1.RowCount.ToString();
            }
            else
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Empty; // إلغاء الفلتر
                lbRecord.Text = dataGridView1.RowCount.ToString();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string filterColumn = cbxFilter.SelectedItem.ToString();
            string filterValue = txtFilter.Text;

            // تطبيق الفلترة على DataTable
            if (!string.IsNullOrEmpty(filterValue))
            {
                if (cbxFilter.SelectedIndex == 2 || cbxFilter.SelectedIndex == 3)
                {
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", filterColumn, filterValue);
                    lbRecord.Text = dataGridView1.RowCount.ToString();
                }
                else
                {

                    if (!_CheckIfValueIsValied(filterValue))
                    {
                        MessageBox.Show("The Value is not Valied!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                    }


                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format($"{filterColumn}={filterValue}");
                    lbRecord.Text = dataGridView1.RowCount.ToString();
                }

            }
            else
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Empty; // إلغاء الفلتر
                lbRecord.Text = dataGridView1.RowCount.ToString();
            }
        }

        private void ListOfAppoointments_Load(object sender, EventArgs e)
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
            AddNewAppointment frm = new AddNewAppointment();
            frm.ShowDialog();
            _ReffreshData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count!=1)
            {
                MessageBox.Show("You must select 1 one Person!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if((bool)dataGridView1.CurrentRow.Cells[6].Value==false)
            {
                MessageBox.Show("This Appointment is Ended ,You Can't Update it !", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsAppointments Appointment = clsAppointments.FindAppointmentByID((int)dataGridView1.CurrentRow.Cells[0].Value);
            UpdateAppointment frm = new UpdateAppointment(Appointment);
            frm.ShowDialog();
            _ReffreshData();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            FindAppointment frm = new FindAppointment();
            frm.ShowDialog();
        }

        private void updateAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsAppointments Appointment = clsAppointments.FindAppointmentByID((int)dataGridView1.CurrentRow.Cells[0].Value);
            UpdateAppointment frm = new UpdateAppointment(Appointment);
            frm.ShowDialog();
            _ReffreshData();
        }

        private void appointmentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsAppointments Appointment = clsAppointments.FindAppointmentByID((int)dataGridView1.CurrentRow.Cells[0].Value);
            AppointmentRecordInfo frm = new AppointmentRecordInfo(Appointment);
            frm.ShowDialog();
        }

        private void doctorInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsDoctors Doctor = clsDoctors.FindDoctorByID((int)dataGridView1.CurrentRow.Cells[5].Value);
            DoctorInfo frm = new DoctorInfo(Doctor);
            frm.ShowDialog();
        }

        private void getAllActiveAppForThisDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListOfAllActiveAppointmentForDoctor frm = new ListOfAllActiveAppointmentForDoctor((int)dataGridView1.CurrentRow.Cells[5].Value);
            frm.ShowDialog();
        }

        private void deleteAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You sure to delete this Appointment Record!,This will cancel The Appointmnet!","Warnning",MessageBoxButtons.OK,MessageBoxIcon.Warning)== DialogResult.Cancel)
            {
                return;
            }

            if (!clsAppointments.DeleteAppointmentRecord((int)dataGridView1.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("There is somthing Error,You can't delete this Appointment Record!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _ReffreshData();
        }

        private void endPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(dataGridView1.CurrentRow.Cells[9].Value.ToString()))
            {
                MessageBox.Show("You must add this Person as a Patient Firstly!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            

            clsAppointments appointment = clsAppointments.FindAppointmentByID((int)dataGridView1.CurrentRow.Cells[0].Value);

            AddNewPrescription frm = new AddNewPrescription(appointment, (int)dataGridView1.CurrentRow.Cells[9].Value);
            frm.ShowDialog();

            _ReffreshData();
        }


        private void _SetPateintID(clsPateints patinetID)
        {
          this.Patient = patinetID;
        }

        private void addAsPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUpdate_Patient frm =new AddUpdate_Patient();
            frm.AfterSaveDataBack += _SetPateintID;
            frm.ShowDialog();

            if(!clsAppointments.AddPatientIDToAppointmentRecord((int)dataGridView1.CurrentRow.Cells[0].Value, Patient.PatinetID))
            {
                MessageBox.Show("There is somthing error while try to add PatientID to Appointment!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            _ReffreshData();

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if((bool)dataGridView1.CurrentRow.Cells[6].Value==false)
            {
                contextMenuStrip1.Items[0].Enabled = false;
                contextMenuStrip1.Items[5].Enabled = false;
                contextMenuStrip1.Items[6].Enabled = false;
            }
            else if(string.IsNullOrWhiteSpace(dataGridView1.CurrentRow.Cells[9].Value.ToString()))
            {
                contextMenuStrip1.Items[0].Enabled = true;
                contextMenuStrip1.Items[5].Enabled = true;
                contextMenuStrip1.Items[6].Enabled = true;
            }
            else
            {
                contextMenuStrip1.Items[0].Enabled =true;
                contextMenuStrip1.Items[5].Enabled =true;
                contextMenuStrip1.Items[6].Enabled =false;
            }
        }
    }
}
