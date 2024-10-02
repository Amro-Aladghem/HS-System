using clsBusineesLayer;
using HospitalSys.Doctors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalSys.Nurses
{
    public partial class ctrAddUpdateNurse :UserControl
    {
        enum eMode { AddNew = 1, Update = 2 };
        eMode Mode;

        clsNurses Nurse;

        public class clsOnSaveClick : EventArgs
        {
            public clsNurses Nurse { get; set; }

            public clsOnSaveClick(clsNurses Nurse)
            {
                this.Nurse = Nurse;
            }
        }

        public event EventHandler<clsOnSaveClick> OnSaveClick;

        public ctrAddUpdateNurse()
        {
            InitializeComponent();
            Nurse = new clsNurses();
            Mode = eMode.AddNew;
        }


        public void GetObjectAndLoadData(clsNurses Nurse)
        {
            this.Nurse = Nurse;
            Mode = eMode.Update;
            _LoadDataToForm();
        }

        private void _LoadDataToForm()
        {
            lbNurseID.Text         = Nurse.NurseID.ToString();
            txtFirstName.Text      = Nurse.Firstname;
            txtSecondName.Text     = Nurse.SecondName;
            txtLastName.Text       = Nurse.LastName;
            txtPhone.Text          = Nurse.PhoneNum;
            txtEmail.Text          = Nurse.Email;
            txtNationalNum.Text    = Nurse.NationalNum;
            dateTimeBirth.Value    = Nurse.DateOfBirth;
            numaricSalary.Value    = Nurse.Salary;


            rdMale.Checked         = Nurse.Gendor == false ? true : false;
            rdFemale.Checked       = Nurse.Gendor == true ? true : false;
            cbIsActive.Checked     = Nurse.IsActive;
            cbSection.Text         = clsHSInformation.GetSectionNameByID(Nurse.SectionTypeID);

            gbName.Enabled = false;
            dateTimeBirth.Enabled = false;
            rdFemale.Enabled = false;
            rdMale.Enabled = false;
            txtNationalNum.ReadOnly = true;

        }

        public void LoadDataToCbxs(DataTable cbxSectionData)
        {
            _PerformCbxSections(cbxSectionData);
        }

        private void _PerformCbxSections(DataTable dt)
        {
            foreach (DataRow dr in dt.Rows)
            {
                cbSection.Items.Add(dr["SectionName"]);
            }

            cbSection.SelectedIndex = 0;
        }


        private void ctrAddUpdateNurse_Load(object sender, EventArgs e)
        {

        }

        private void _LoadDataToObject()
        {
            if (Mode == eMode.AddNew)
            {
                Nurse.Firstname = txtFirstName.Text;
                Nurse.SecondName = txtSecondName.Text;
                Nurse.LastName = txtLastName.Text;
                Nurse.NationalNum = txtNationalNum.Text;
                Nurse.DateOfBirth = dateTimeBirth.Value;
                Nurse.Gendor = rdMale.Checked ? false : true;
            }

            Nurse.PhoneNum = txtPhone.Text;
            Nurse.Email = txtEmail.Text;
            Nurse.SectionTypeID = clsHSInformation.GetSectionTypeIDByName(cbSection.Text);
            Nurse.Salary = numaricSalary.Value;
            Nurse.IsActive = cbIsActive.Checked;
           
            
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                return;
            }

            if (MessageBox.Show("Are You Sure to Add/Update this Nurse?", "Warnning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                MessageBox.Show("The Procedss Cancled!");
                return;
            }

            _LoadDataToObject();

            if(!Nurse.Save())
            {
                MessageBox.Show("Somting Error , The Process has been Cancled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("The Process Has been Done Successfully!");
            OnSaveClick?.Invoke(sender, new clsOnSaveClick(Nurse));
            lbNurseID.Text = Nurse.NurseID.ToString();

            gbName.Enabled = false;
            dateTimeBirth.Enabled = false;
            rdFemale.Enabled = false;
            rdMale.Enabled = false;
            txtNationalNum.ReadOnly = true;

        }




        //Valideation Stage------------------------------------------------------

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
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
            if (string.IsNullOrEmpty(txtFirstName.Text))
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
            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtLastName, "You must Fill it!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtLastName, "");
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNationalNum_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNationalNum_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNationalNum.Text))
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

        private void txtEmail_Validating_1(object sender, CancelEventArgs e)
        {
            if (!txtEmail.Text.Contains("@gmail.com") && txtEmail.Text != "")
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "This Email Not valied!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtEmail, "");
            }
        }

        private void dateTimeBirth_Validating(object sender, CancelEventArgs e)
        {
            if ((DateTime.Now.Year - dateTimeBirth.Value.Year) < 21)
            {
                e.Cancel = true;
                errorProvider1.SetError(dateTimeBirth, "Invalied Date, The Age must at least 24 and above!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(dateTimeBirth, "");
            }
        }

        private void numaricSalary_Validating(object sender, CancelEventArgs e)
        {
            if (numaricSalary.Value == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(numaricSalary, "The Salary must be above 0 JO");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(numaricSalary, "");
            }
        }
    }
}
