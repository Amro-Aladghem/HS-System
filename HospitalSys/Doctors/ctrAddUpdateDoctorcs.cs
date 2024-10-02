using clsBusineesLayer;
using System;
using System.CodeDom;
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
    public partial class ctrAddUpdateDoctorcs : UserControl
    {
        enum eMode { AddNew=1,Update=2 };
        eMode Mode;

        public class clsAfterSave :EventArgs
        {
            public clsDoctors Doctor { get; set; }

            public clsAfterSave(clsDoctors Doctor)
            {
                this.Doctor = Doctor;
            }
        }

        public event EventHandler<clsAfterSave> OnSaveClick;

        public ctrAddUpdateDoctorcs()
        {
            InitializeComponent();
            Mode = eMode.AddNew;
            Doctor = new clsDoctors();
        }

        private clsDoctors Doctor;

        private int? RoomID;


        public void LoadDataToCbxs(DataTable cbxSectionData, DataTable cbxSpecialistData)
        {
            _PerformCbxSections(cbxSectionData);
            _PerformCbxSpecialist(cbxSpecialistData);
        }

        public void GetObjectAndLoadData(clsDoctors Doctor)
        {
            this.Doctor = Doctor;
            Mode = eMode.Update;
            _LoadDoctorDataToForm();
        }

        private void _LoadDoctorDataToForm()
        {
            if(Doctor!=null)
            {
                lbDoctorID.Text              = Doctor.DoctorID.ToString();
                txtFirstName.Text            = Doctor.Firstname;
                txtSecondName.Text           = Doctor.SecondName;
                txtLastName.Text             = Doctor.LastName;
                txtPhone.Text                = Doctor.PhoneNum;
                txtEmail.Text                = Doctor.Email;
                txtNationalNum.Text          =Doctor.NationalNum;
                dateTimeBirth.Value          = Doctor.DateOfBirth;
                numaricAppointmentCost.Value = (decimal)Doctor.AppointmentCost;
                numaricSalary.Value          = Doctor.Salary;

                cbSpecialist.Text            = clsHSInformation.GetSpecialistNameByID(Doctor.SpectialistTypeID);
                rdMale.Checked               = (Doctor.Gendor == false) ? true : false;
                rdFemale.Checked             = (Doctor.Gendor == true) ? true : false;
                cbIsActive.Checked           = Doctor.isActive;
                cbSection.Text               = clsHSInformation.GetSectionNameByID(Doctor.SectionTypeID);

                if(Doctor.RoomID!=null)
                {
                    gbRoomInfo.Enabled = true;
                    cbWithRoom.Checked = true;
                    cbRooms.Text = clsHSInformation.GetRoomNumberByID((int)Doctor.RoomID).ToString();
                    numaricAppointmentCost.Value = (decimal)Doctor.AppointmentCost;
                }

                gbFullName.Enabled = false;
                dateTimeBirth.Enabled = false;
                rdFemale.Enabled = false;
                rdMale.Enabled = false;
                txtNationalNum.ReadOnly = true;
            }
        }

        private void _LoadDataToCbxRoomsNumber()
        {
            DataTable dt = new DataTable();
            dt = clsHSInformation.GetAllAvailableRoomForDoctor();
            foreach (DataRow dr in dt.Rows)
            {
                cbRooms.Items.Add(dr["RoomNumber"]);
            }
        }

        private void cbWithRoom_CheckedChanged(object sender, EventArgs e)
        {
            if (cbWithRoom.Checked == false)
            {
                gbRoomInfo.Enabled = false;
                RoomID = null;
                numaricAppointmentCost.Value = 0;
            }
            else
            {
                gbRoomInfo.Enabled = true;
                if (cbRooms.Items.Count == 0)
                {
                    _LoadDataToCbxRoomsNumber();
                }
            }
        }

        private DataTable _LoadDataToCbxSectionsTypes()
        {
            DataTable dt = clsHSInformation.GetAllSectionsInSys();
            return dt;
        }

        private DataTable _LoadDataToCbxSpecialisTypes()
        {
            DataTable dt = clsHSInformation.GetAllSpecialistTypeInSys();
            return dt; 
        }

        private void _PerformCbxSections(DataTable dt)
        {
            foreach (DataRow dr in dt.Rows)
            {
                cbSection.Items.Add(dr["SectionName"]);
            }

            cbSection.SelectedIndex = 0;
        }

        private void _PerformCbxSpecialist(DataTable dt)
        {
            foreach (DataRow dr in dt.Rows)
            {
                cbSpecialist.Items.Add(dr["SpecialestName"]);
            }

            cbSpecialist.SelectedIndex = 0;
        }

        private void ctrAddUpdateDoctorcs_Load(object sender, EventArgs e)
        {
               
        }
        
        private void _SetRoomID(int RoomNumber)
        {
            RoomID=clsHSInformation.GetRoomIDByRoomNumber(RoomNumber);
        }

        private void _LoadDataToObject()
        {
            if(Mode==eMode.AddNew)
            {
                Doctor.Firstname = txtFirstName.Text;
                Doctor.SecondName = txtSecondName.Text;
                Doctor.LastName = txtLastName.Text;
                Doctor.NationalNum= txtNationalNum.Text;
                Doctor.DateOfBirth = dateTimeBirth.Value;
                Doctor.Gendor = rdMale.Checked ? false : true;
            }

            Doctor.PhoneNum = txtPhone.Text;
            Doctor.Email = txtEmail.Text;
            Doctor.SpectialistTypeID = clsHSInformation.GetSpecialistTypeIDByName(cbSpecialist.Text);
            Doctor.SectionTypeID = clsHSInformation.GetSectionTypeIDByName(cbSection.Text);
            Doctor.Salary = numaricSalary.Value;
            Doctor.isActive = cbIsActive.Checked;
            Doctor.RoomID = RoomID;
            Doctor.AppointmentCost = numaricAppointmentCost.Value;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!ValidateChildren())
            {
                return;
            }

            if(MessageBox.Show("Are You Sure to Add/Update this Doctor?", "Warnning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                MessageBox.Show("The Procedss Cancled!");
                return;
            }

            _LoadDataToObject();

            if(!Doctor.Save())
            {
                MessageBox.Show("Somting Error , The Process has been Cancled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("The Process has been Done Successsfully!");
            lbDoctorID.Text = Doctor.DoctorID.ToString();
            Mode = eMode.Update;

            OnSaveClick?.Invoke(sender, new clsAfterSave(Doctor));

            gbFullName.Enabled = false;
            dateTimeBirth.Enabled = false;
            rdFemale.Enabled = false;
            rdMale.Enabled = false;
            txtNationalNum.ReadOnly = true;

        }

        private void cbRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SetRoomID(Convert.ToInt32(cbRooms.Text));
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

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPhone, "You must Fill it!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPhone, "");
            }
        }

        private void txtNationalNum_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtEmail_Validating(object sender, CancelEventArgs e)
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
            if ((DateTime.Now.Year - dateTimeBirth.Value.Year) < 24)
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
