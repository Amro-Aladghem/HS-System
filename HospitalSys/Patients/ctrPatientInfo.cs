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

namespace HospitalSys.Patients
{
    public partial class ctrPatientInfo : UserControl
    {
        clsPateints Patient;


        public ctrPatientInfo()
        {
            InitializeComponent();
        }

        public void GetObjectAndLoadData(clsPateints Patient)
        {
            this.Patient = Patient;
            _LoadDataToForm();
        }

        private void _LoadDataToForm()
        {
            lbPatientID.Text = Patient.PatinetID.ToString();
            lbName.Text = Patient.Firstname + " " + Patient.SecondName + " " + Patient.LastName;
            lbPhone.Text = Patient.PhoneNum;
            lbEmail.Text = Patient.Email;
            lbRelativeNum.Text = Patient.RelativeNumber;
            lbBlood.Text = clsHSInformation.GetBloodeTypeNameByID((int)Patient.BloodTypeID);
            lbBirth.Text = Patient.DateOfBirth.ToShortDateString();
            lbNationalNum.Text = Patient.NationalNum;
            txtAddress.Text = Patient.Address;
        }

        private void ctrPatientInfo_Load(object sender, EventArgs e)
        {

        }

        private void lbCopy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(lbNationalNum.Text);
            MessageBox.Show("تم نسخ الرقم الوطني!", "نسخ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
