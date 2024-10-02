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

namespace HospitalSys.SurgeryProcedures
{
    public partial class ctrSurgeryInfo : UserControl
    {
        clsSurgery SurgeryProcedure;
        public ctrSurgeryInfo()
        {
            InitializeComponent();
        }

        public void GetObjectAndLoadData(clsSurgery surgery)
        {
            this.SurgeryProcedure= surgery;
            _LoadDataToForm();
        }

        private void _LoadDataToForm()
        {
            lbProcedureID.Text=SurgeryProcedure.SurgerProcedureID.ToString();
            lbPatientID.Text=SurgeryProcedure.PatientID.ToString();
            lbDoctor1.Text=SurgeryProcedure.FirstDoctorID.ToString();
            lbDoctor2.Text = SurgeryProcedure.SecondDoctorID.ToString();
            lbDoctor3.Text = SurgeryProcedure.ThirdDoctorID.ToString();
            lbNurse1.Text=SurgeryProcedure.FirstNurseID.ToString();
            lbNurse2.Text = SurgeryProcedure.SecondNurseID.ToString();
            lbProcedureName.Text=clsSurgery.GetSurgeryTypeNameByID(SurgeryProcedure.SurgerProcedureID);
            lbDate.Text = SurgeryProcedure.DateOfProcedure.ToShortDateString();
            lbTime.Text=SurgeryProcedure.Time.ToString();
            lbIsFinish.Text = SurgeryProcedure.IsFinish ? "Yes" : "No";
            lbRoomNum.Text = clsHSInformation.GetRoomNumberByID(SurgeryProcedure.RoomID).ToString();
            
        }

        private void ctrSurgeryInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
