using clsBusineesLayer;
using HospitalSys.PateintsRecords;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace HospitalSys.Patients
{
    public partial class ctrAddUpdatePatient : UserControl
    {
        enum eMode { AddNew=1,Update=2}
        eMode Mode;

        clsPateints Patient;

        public class clsAfterSaving : EventArgs
        {
            public clsPateints Pateints { get; set; }

            public clsAfterSaving(clsPateints patient)
            {
                this.Pateints = patient;
            }
        }

      public event EventHandler<clsAfterSaving> AfterSaving;    


        public ctrAddUpdatePatient()
        {
            InitializeComponent();
            Mode = eMode.AddNew;
            Patient = new clsPateints();
        }

        public void GetObjectAndLoadData(clsPateints Patient)
        {
            this.Patient = Patient;
            Mode =eMode.Update;
            _LoadDataToForm();
        }

        private void _LoadDataToForm()
        {
            if (Patient != null)
            {

                //General -----
                txtFirstName.Text = Patient.Firstname;
                txtSecondName.Text = Patient.SecondName;
                txtLastName.Text = Patient.LastName;
                txtPhone.Text = Patient.PhoneNum;
                txtEmail.Text = Patient.Email;
                txtNationalNum.Text = Patient.NationalNum;
                dateTimeBirth.Value = Patient.DateOfBirth;

                rdMale.Checked = Patient.Gendor == false ? true : false;
                rdFemale.Checked = Patient.Gendor ? true : false;

                //Specific Info -------
                cbNationality.Text = Patient.Nationality;
                cbBloodType.Text = Patient.BloodTypeID == null ? "None" : clsHSInformation.GetBloodeTypeNameByID((int)Patient.BloodTypeID);
                txtAddress.Text = Patient.Address;
                txtRelativeNum.Text = Patient.RelativeNumber;


                gbName.Enabled = false;
                dateTimeBirth.Enabled = false;
                rdFemale.Enabled = false;
                rdMale.Enabled = false;
                txtNationalNum.ReadOnly = true;
                cbNationality.Enabled = false;
            }
        }

        private void ctrAddUpdatePatient_Load(object sender, EventArgs e)
        {
            cbBloodType.SelectedIndex = 0;
            cbNationality.SelectedIndex = 0;
        }

     

        private void _LoadDataToObject()
        {
            if (Mode == eMode.AddNew)
            {
                Patient.Firstname = txtFirstName.Text;
                Patient.SecondName = txtSecondName.Text;
                Patient.LastName = txtLastName.Text;
                Patient.NationalNum = txtNationalNum.Text;
                Patient.DateOfBirth = dateTimeBirth.Value;
                Patient.Gendor = rdMale.Checked ? false : true;
                Patient.Nationality = cbNationality.Text;
            }

            Patient.PhoneNum = txtPhone.Text;
            Patient.Email = txtEmail.Text;
            Patient.BloodTypeID = cbBloodType.SelectedIndex;
            Patient.RelativeNumber = txtRelativeNum.Text;
            Patient.Address = txtAddress.Text;

        }

        private void _PerfromAddNewRecordForPatient()
        {
            if(Mode==eMode.AddNew)
            {
                if(MessageBox.Show("Do you want to add Medical Record for this Patient?","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)==DialogResult.Yes)
                {
                    AddNewPatientRecordHS frm = new AddNewPatientRecordHS(Patient.PatinetID);
                    frm.ShowDialog();
                }
                else
                {
                    return;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                return;
            }

            if (MessageBox.Show("Are You sure To Add/Update this Patient!", "Warnning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }

            _LoadDataToObject();

            if(!Patient.Save())
            {
                MessageBox.Show("There is Something Error,Please Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            MessageBox.Show("The Process has been done Successfully!");

            gbName.Enabled = false;
            dateTimeBirth.Enabled = false;
            rdFemale.Enabled = false;
            rdMale.Enabled = false;
            txtNationalNum.ReadOnly = true;
            cbNationality.Enabled = false;

            _PerfromAddNewRecordForPatient();

            Mode = eMode.Update;

            AfterSaving?.Invoke(sender, new clsAfterSaving(Patient));


        }


        //Valiedation Stage -----------------------------------------------------
        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSecondName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
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
            if(string.IsNullOrEmpty(txtFirstName.Text))
            {
                e.Cancel = true;
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
            if(string.IsNullOrEmpty(txtLastName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtLastName, "You must Fill it!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtLastName,"");
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled=true;
            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtPhone.Text))
            {
               e.Cancel=true;
                errorProvider1.SetError(txtPhone, "You must Fill It!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPhone, "");
            }
        }

        private void txtNationalNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNationalNum_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtNationalNum.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNationalNum, "You must Fill it!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNationalNum, "");
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if(!txtEmail.Text.Contains("@gmail.com") &&txtEmail.Text!="")
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "This Email not valied!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtEmail, "");
            }
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtAddress.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtAddress, "You must Fill it!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtAddress, "");
            }
        }

     }
}
