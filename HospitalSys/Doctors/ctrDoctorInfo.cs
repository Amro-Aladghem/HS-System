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

namespace HospitalSys.Doctors
{
    public partial class ctrDoctorInfo : UserControl
    {
        public ctrDoctorInfo()
        {
            InitializeComponent();
        }

        clsDoctors Doctor;

        public void GetObjectAndLoadData(clsDoctors Doctor)
        {
            this.Doctor = Doctor;
            _LoadDataToForm();
        }

        private void _LoadDataToForm()
        {
            if(Doctor!=null)
            {
                lbDoctorID.Text = Doctor.DoctorID.ToString();
                lbName.Text = Doctor.Firstname + " " + Doctor.SecondName + " " + Doctor.LastName;
                lbPhone.Text = Doctor.PhoneNum.ToString();
                lbEmail.Text = Doctor.Email;
                lbSalary.Text = Doctor.Salary.ToString();
                lbBirth.Text = Doctor.DateOfBirth.ToShortDateString();
                lbSpecialist.Text = clsHSInformation.GetSpecialistNameByID(Doctor.SpectialistTypeID);
                lbSection.Text = clsHSInformation.GetSectionNameByID(Doctor.SectionTypeID);
                lbIsActive.Text = Doctor.isActive == true ? "Yes" : "No";
                lbAppointmentCost.Text = Doctor.AppointmentCost == null ? "0jd" : Doctor.AppointmentCost.ToString() + "jd";

                if(Doctor.RoomID!=null)
                {
                    lbRoomNum.Text = clsHSInformation.GetRoomNumberByID((int)Doctor.RoomID).ToString();
                    return;
                }

                lbRoomNum.Text = "Without Room";

            }
        }

        private void _SetNewObjectAfterUpdate(clsDoctors Doctor)
        {
            this.Doctor = Doctor;
            _LoadDataToForm();
        }



        private void ctrDoctorInfo_Load(object sender, EventArgs e)
        {

        }

        private void lbUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Doctor == null)
            {
                MessageBox.Show("No Doctor Object is set!");
                return;
            }

            AddUpdateDoctor frm = new AddUpdateDoctor(Doctor);
            frm.AfterChangingDataBack += _SetNewObjectAfterUpdate;
            frm.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
