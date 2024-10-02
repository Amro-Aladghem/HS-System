using clsBusineesLayer;
using HospitalSys.Patients;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HospitalSys.Appointments
{
    public partial class ctrAddNewAppointment : UserControl
    {
        int DoctorID = -1;
        clsAppointments NewAppointment;

        clsPateints Patient;

        bool WithPatientID = false;

        public event EventHandler OnSaveClick;

        public ctrAddNewAppointment()
        {
            InitializeComponent();
            NewAppointment=new clsAppointments();
        }

        private void _SetDoctorID(int DoctorID)
        {
            this.DoctorID=DoctorID;
            lbDoctorID.Text = DoctorID.ToString();
        }

        private void ctrAddNewAppointment_Load(object sender, EventArgs e)
        {

        }

        private void lbChooseDoctor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ListOfAllDoctorsWhosehaveARoom frm = new ListOfAllDoctorsWhosehaveARoom();
            frm.AfterChoosingDataBack += _SetDoctorID;
            frm.ShowDialog();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                return;
            }

            if(DoctorID==-1)
            {
                MessageBox.Show("You must select Doctor!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            TimeSpan Time = TimeOfAppointment.Value.TimeOfDay;
            DateTime Date = dateOfAppointment.Value.Date;

            if (!clsAppointments.IsDoctorAvaialableForAppointment(DoctorID, Time, Date))
            {
                MessageBox.Show("This Doctor Not Available in this Date And Time", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbAppError.Visible = true;
                btnSave.Enabled = false;
                return;
            }

            lbAppError.Visible = false;
            btnSave.Enabled = true;


        }

        private void _LoadDataToObject()
        {
            NewAppointment.DocotrID = DoctorID;
            NewAppointment.PersonFirstName = txtFirstName.Text;
            NewAppointment.PersonLastName = txtLastName.Text;
            NewAppointment.PhoneNum = txtPhone.Text;
            NewAppointment.Address = txtAddress.Text;
            NewAppointment.DateOfAppointment = dateOfAppointment.Value.Date;
            NewAppointment.Time = TimeOfAppointment.Value.TimeOfDay;
            NewAppointment.IsAcitve = true;
            if(WithPatientID)
            {
                NewAppointment.PatientID = Patient.PatinetID;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You sure to continue?", "Warnning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                MessageBox.Show("The Process has been Cancled!");
                return;
            }

            _LoadDataToObject();

            if (!NewAppointment.Save())
            {
                MessageBox.Show("There is somthing Error,The Process has been Cancled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("The Process has been done Successfully!");
            lbAppointmentID.Text = NewAppointment.AppointmentID.ToString();
            btnSave.Enabled = false;
            btnCheck.Enabled = false;

            OnSaveClick?.Invoke(null, null);

        }

        private void _SetPatientObject(clsPateints pateint)
        {
            this.Patient = pateint;
        }

        private void _LoadPatientDataAfterAddingNewPatient()
        {
            if (this.Patient != null)
            {
                clsPersons Person = clsPersons.FindPersonByID(Patient.PersonID);

                if (Person == null)
                {
                    MessageBox.Show("There is Somthing Error with connection,Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                lbNotFound.Visible = false;
                WithPatientID = true;

                txtFirstName.Text = Person.Firstname;
                txtLastName.Text = Person.LastName;
                txtPhone.Text = Person.PhoneNum;
                txtNationalNum.Text = Person.NationalNum;

            }
        }

        private void lbNotFound_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddUpdate_Patient frm = new AddUpdate_Patient();
            frm.AfterSaveDataBack += _SetPatientObject;
            frm.ShowDialog();

            _LoadPatientDataAfterAddingNewPatient();
        }

        private void _LoadPatientDataIfExsits(clsPateints Patient)
        {
            if (Patient == null)
            {
                lbNotFound.Visible = true;
                WithPatientID = false;

                txtFirstName.Clear();
                txtLastName.Clear();
                txtPhone.Clear();
                txtAddress.Clear();

                this.Patient = null;

                return;
            }

            clsPersons Person = clsPersons.FindPersonByID(Patient.PersonID);

            if (Person == null)
            {
                MessageBox.Show("There is Somthing Error with connection,Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            lbNotFound.Visible = false;
            WithPatientID = true;

            txtFirstName.Text = Person.Firstname;
            txtLastName.Text = Person.LastName;
            txtPhone.Text = Person.PhoneNum;

            this.Patient = Patient;
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtNationalNum.Text == "")
            {
                MessageBox.Show("You must fill National Num Text Box!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            clsPateints Patient = clsPateints.FindPatientByNationalNum(txtNationalNum.Text);


            _LoadPatientDataIfExsits(Patient);

        }


        // Validatation Stage---------------------------------------------------
        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if(txtFirstName.Text=="")
            {
                e.Cancel=true;
                errorProvider1.SetError(txtFirstName, "You must Fill it!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFirstName, "");
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (txtLastName.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(txtLastName, "You must Fill IT!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtLastName, "");
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if(txtPhone.Text=="")
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPhone, "You must Fill IT!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPhone, "");
            }
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            if(txtAddress.Text=="")
            {
                e.Cancel = true;
                errorProvider1.SetError(txtAddress, "You must Fill IT!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtAddress, "");
            }
        }

        private void lbDoctorID_Validating(object sender, CancelEventArgs e)
        {
            if(lbDoctorID.Text=="N/A")
            {
                e.Cancel = true;
                errorProvider1.SetError(lbDoctorID, "You must Choose Doctor!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(lbDoctorID, "");
            }
        }

        private void txtNationalNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNationalNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                if (Clipboard.ContainsText())
                {
                    txtNationalNum.Text = Clipboard.GetText();
                }
                e.Handled = true;
            }
        }
    }
}
