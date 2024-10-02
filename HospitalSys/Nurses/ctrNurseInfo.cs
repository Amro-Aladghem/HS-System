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

namespace HospitalSys.Nurses
{
    public partial class ctrNurseInfo : UserControl
    {
        public ctrNurseInfo()
        {
            InitializeComponent();
        }

        clsNurses Nurse;


        public void GetObjectAndLoadData(clsNurses Nurse)
        {
            this.Nurse = Nurse;
            _LoadDataToForm();
        }

        private void _LoadDataToForm()
        {
            lbNurseID.Text = Nurse.NurseID.ToString();
            lbName.Text = Nurse.Firstname +" "+ Nurse.SecondName+" " + Nurse.LastName;
            lbPhone.Text = Nurse.PhoneNum;
            lbEmail.Text = Nurse.Email;
            lbSalary.Text = Nurse.Salary.ToString() + "jd";
            lbBirth.Text = Nurse.DateOfBirth.ToShortDateString();
            lbSection.Text = clsHSInformation.GetSectionNameByID(Nurse.SectionTypeID);
            lbIsActive.Text = Nurse.IsActive ? "Yes" : "No";
        }

        private void _SetNewObjectAndReffreshForm(clsNurses Nurse)
        {
            this.Nurse = Nurse;
            _LoadDataToForm();
        }



        private void ctrNurseInfo_Load(object sender, EventArgs e)
        {

        }

        private void lbUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(Nurse==null)
            {
                MessageBox.Show("No Nurse Object is set!");
                return;
            }

            AddUpdateNurse frm = new AddUpdateNurse(Nurse);
            frm.AfterChangingDataBack += _SetNewObjectAndReffreshForm;
            frm.ShowDialog();
        }
    }
}
