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

namespace HospitalSys.OtherEmployee
{
    public partial class ctrEmployeInfo : UserControl
    {
        public ctrEmployeInfo()
        {
            InitializeComponent();
        }

        clsOtherEmployee Employee;

        public void GetObjectAndLoadDataToForm(clsOtherEmployee Employee)
        {
            this.Employee = Employee;
            _LoadDataToForm();
        }

        private void _LoadDataToForm()
        {
            lbEmployeeID.Text = Employee.EmployeeID.ToString();
            lbName.Text = Employee.Firstname + Employee.SecondName + Employee.LastName;
            lbPhone.Text = Employee.PhoneNum;
            lbEmail.Text = Employee.Email;
            lbSalary.Text = Employee.Salary.ToString() + "jd";
            lbBirth.Text = Employee.DateOfBirth.ToShortDateString();
            lbSection.Text = clsHSInformation.GetSectionNameByID(Employee.SectionTypeID);
            lbJobRole.Text = clsHSInformation.GetJobRoleNameByID(Employee.RolesJobID);
        }

        private void _SetNewObjectAndReffreshData(clsOtherEmployee Employee)
        {
            this.Employee= Employee; 
            _LoadDataToForm();
        }


        private void ctrEmployeInfo_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddUpdateEmployee frm = new AddUpdateEmployee(Employee);
            frm.AfterChangingDataBack += _SetNewObjectAndReffreshData;
            frm.ShowDialog();
        }


    }
}
