using clsBusineesLayer;
using HospitalSys.Nurses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalSys.SurgeryProcedures
{
    public partial class AddNewSurgeryProcedureAppointment : Form
    {
        enum eMode { AddNew=1,Udpdate=2}
        eMode Mode;


        int PatientID;
        int CurrentChoseDoctor = -1;
        int CurrentChoseNurse = -1;

        bool FinishDoctor = false;
        bool FinishNurse = false;

        SortedList<int, int?> listDoctorsID = new SortedList<int, int?>();

        SortedList<int,int?> listNursesID=new SortedList<int, int?>();

        clsSurgery SurgeryProcedure = new clsSurgery();

        public AddNewSurgeryProcedureAppointment()
        {
            InitializeComponent();
            Mode = eMode.AddNew;
        }

        public AddNewSurgeryProcedureAppointment(clsSurgery Surgery)
        {
            InitializeComponent();
            Mode = eMode.Udpdate;
            this.SurgeryProcedure = Surgery;
            lbHeader.Text = "Update Sugery Procedure:";
        }

        public void LoadDataToCbxSygeryTypes(DataTable dt)
        {
            foreach(DataRow row in dt.Rows)
            {
                cbxSurgeryTypes.Items.Add(row[0]);
            }

            cbxSurgeryTypes.SelectedIndex = 0;
        }

        public void LoadDataToCbxSurgeryRoom(DataTable dt)
        {
            foreach(DataRow row in dt.Rows)
            {
                cbxRoomNum.Items.Add(row[0]);
            }


            cbxRoomNum.SelectedIndex = 0;
        }

        private void _LoadDoctorsAndNursesData()
        {
            PanelChoosing.Enabled = true;

            //Doctors
            listDoctorsID[1] = SurgeryProcedure.FirstDoctorID;
            listDoctorsID[2]=  SurgeryProcedure.SecondDoctorID;
            listDoctorsID[3] = SurgeryProcedure.ThirdDoctorID;

            //Nurse
            listNursesID[1] = SurgeryProcedure.FirstNurseID;
            listNursesID[2]=  SurgeryProcedure.SecondNurseID;

            lbDoctor1.Text = listDoctorsID[1].ToString();
            lbDoctor2.Text = listDoctorsID[2] == null ? "N/A" : listDoctorsID[2].ToString();
            lbDoctor3.Text = listDoctorsID[3] == null ? "N/A" : listDoctorsID[3].ToString();

            lbNurse1.Text = listNursesID[1].ToString();
            lbNurse2.Text = listNursesID[2] == null ? "N/A" : listNursesID[2].ToString();

            btnDeleteDoctor2.Visible = listDoctorsID[2] != null;
            btnDeleteDoctor3.Visible = listDoctorsID[3] != null;

            btnDeleteNurse2.Visible = listNursesID[2] != null;

            changeButtonsEnabledStatus(false);
            changeButtonsEnabledStatusForNurse(false);

            FinishDoctor = true;
            FinishNurse = true;

        }

        private void _LoadDataToForm()
        {
            if (SurgeryProcedure!=null)
            {
                btnSave.Visible = true;

                txtPatientID.Text = SurgeryProcedure.PatientID.ToString();
                btnSearchPatient.Enabled = false;
                PatientID = SurgeryProcedure.PatientID;

                dateOfProcedure.Value = SurgeryProcedure.DateOfProcedure;
                TimeOfProcedure.Value= DateTime.Today.Add(SurgeryProcedure.Time);

                cbxSurgeryTypes.Text = clsSurgery.GetSurgeryTypeNameByID(SurgeryProcedure.SurgeryProcedureTypeID);
                cbxRoomNum.Text = clsHSInformation.GetRoomNumberByID(SurgeryProcedure.RoomID).ToString();

                _ChangeStatusOfEnabledForContorl(true);

                btnCheck.Enabled = false;

                _LoadDoctorsAndNursesData();

            }
        }

        private void _ChangeStatusOfEnabledForContorl(bool IsEnabled)
        {
            dateOfProcedure.Enabled=IsEnabled;
            TimeOfProcedure.Enabled=IsEnabled;
            cbxSurgeryTypes.Enabled = IsEnabled;
            cbxRoomNum.Enabled = IsEnabled;
            btnCheck.Enabled = IsEnabled;
        }

        private void btnSearchPatient_Click(object sender, EventArgs e)
        {
            if(txtPatientID.Text=="")
            {
                MessageBox.Show("You must Fill Text Box!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            clsPateints Patient = clsPateints.FindPatientByID(Convert.ToInt32(txtPatientID.Text));
            if (Patient == null)
            {
                MessageBox.Show("No Patient With this ID,Please Try an other one!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ChangeStatusOfEnabledForContorl(false);
                return;
            }

            this.PatientID = Patient.PatinetID;

            _ChangeStatusOfEnabledForContorl(true);

        }

        private void dateOfProcedure_Validating(object sender, CancelEventArgs e)
        {
            if(dateOfProcedure.Value.Date<DateTime.Now.Date)
            {
                e.Cancel = true;
                errorProvider1.SetError(dateOfProcedure, "The Date Can't be less than Date Of Today!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(dateOfProcedure, "");
            }
        }

        private void txtPatientID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AddNewSurgeryProcedureAppointment_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                var data = clsSurgery.GetAllSugeryTypesInSys();
                var data2 = clsSurgery.GetAllSurgeryRoomInHS();

                this.Invoke((Action)(() =>
                {
                    LoadDataToCbxSurgeryRoom(data2);
                    LoadDataToCbxSygeryTypes(data);

                    if(Mode==eMode.Udpdate)
                    {
                        _LoadDataToForm();
                    }

                }));

            });
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int RoomID = clsHSInformation.GetRoomIDByRoomNumber(Convert.ToInt32(cbxRoomNum.Text));
            DateTime Date = dateOfProcedure.Value.Date;
            TimeSpan Time = TimeOfProcedure.Value.TimeOfDay;

            if(!clsSurgery.IsSurgeryProcedureCanbeAtThisTime(Date,Time,RoomID))
            {
                MessageBox.Show("There is a Conflict with other Procedure Please Check Procedure Table!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PanelChoosing.Enabled = false;
                return;
            }

            PanelChoosing.Enabled = true;

            if(Mode==eMode.Udpdate)
            {
                btnSave.Visible = true;
            }

        }

        private void _SetDoctorID( int DoctorID)
        {
            this.CurrentChoseDoctor = DoctorID;
        }

        private void ChooseDoctorProcess(int DoctorNum)
        {
            ListOfAllSurgeryDoctorcs frm = new ListOfAllSurgeryDoctorcs();
            frm.AfterChoosingDocotorDataBack += _SetDoctorID;
            frm.ShowDialog();

            if(CurrentChoseDoctor==-1)
            {
                return;
            }

            if (listDoctorsID.Values.Contains(CurrentChoseDoctor))
            {
                MessageBox.Show("This Doctor ID is arleady has been Chose,Choose an other one!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            listDoctorsID[DoctorNum] = CurrentChoseDoctor;
            CurrentChoseDoctor = -1;
        }

        private void btnChooseDoctor1_Click(object sender, EventArgs e)
        {
            ChooseDoctorProcess(1);
            if(listDoctorsID.Count>=1)
            {
                lbDoctor1.Text = listDoctorsID[1].ToString();
            }
        }

        private void btnChooseDoctor2_Click(object sender, EventArgs e)
        {
            ChooseDoctorProcess(2);

            if(listDoctorsID.ContainsKey(2))
            {
                if(Mode==eMode.Udpdate)
                {
                    btnDeleteDoctor2.Visible = listDoctorsID[2] != null;
                    lbDoctor2.Text = listDoctorsID[2] != null ? listDoctorsID[2].ToString() : "N/A";
                    return;
                }


                lbDoctor2.Text = listDoctorsID[2].ToString();
                btnDeleteDoctor2.Visible = true;
            }
        }

        private void btnChooseDoctor3_Click(object sender, EventArgs e)
        {
            ChooseDoctorProcess(3);

            if (listDoctorsID.ContainsKey(3))
            {
                if (Mode == eMode.Udpdate)
                {
                    btnDeleteDoctor3.Visible = listDoctorsID[3] != null;
                    lbDoctor3.Text = listDoctorsID[3] != null ? listDoctorsID[3].ToString() : "N/A";
                    return;
                }


                lbDoctor3.Text = listDoctorsID[3].ToString();
                btnDeleteDoctor3.Visible = true;
            }

        }

        private void btnDeleteDoctor2_Click(object sender, EventArgs e)
        {
            listDoctorsID[2] = null;
            lbDoctor2.Text = "N/A";
            btnDeleteDoctor2.Visible = false;
        }

        private void btnDeleteDoctor3_Click(object sender, EventArgs e)
        {
            listDoctorsID[3] = null;
            lbDoctor3.Text = "N/A";
            btnDeleteDoctor3.Visible = false;
        }

        private void changeButtonsEnabledStatus(bool IsEnabled)
        {
            btnChooseDoctor1.Enabled = IsEnabled;
            btnChooseDoctor2.Enabled=  IsEnabled;
            btnChooseDoctor3.Enabled = IsEnabled;
            btnDeleteDoctor2.Enabled=  IsEnabled;
            btnDeleteDoctor3.Enabled=  IsEnabled;
            btnFinishDoctors.Enabled = IsEnabled;
            btnEditDoctors.Enabled =  !IsEnabled;
        }

        private void btnFinishDoctors_Click(object sender, EventArgs e)
        {
            if (!listDoctorsID.ContainsKey(1))
            {
                if(Mode==eMode.Udpdate)
                {
                    if (listDoctorsID[1]==null)
                    {
                        MessageBox.Show("You must select at least One Doctor!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                MessageBox.Show("You must select at least One Doctor!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            changeButtonsEnabledStatus(false);
            FinishDoctor = true;

            if(FinishNurse)
            {
                btnSave.Visible = true;
            }
        }

        private void btnEditDoctors_Click(object sender, EventArgs e)
        {
            changeButtonsEnabledStatus(true);
            btnSave.Visible = false;
            FinishDoctor = false;
        }

        private void _SetNurseID(int NurseID)
        {
            this.CurrentChoseNurse = NurseID;
        }

        private void ChooseNursesProcess(int NurseNum)
        {
            ListOfAllNurses frm = new ListOfAllNurses();
            frm.AfterChoosingDataBack += _SetNurseID;
            frm.ShowDialog();

            if(CurrentChoseNurse==-1)
            {
                return;
            }

            if (listNursesID.Values.Contains(CurrentChoseNurse))
            {
                MessageBox.Show("This Nurse ID is already Chosen, you must select an other!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            listNursesID[NurseNum] = CurrentChoseNurse;
            CurrentChoseNurse = -1;
        }

        private void btnChooseNurse1_Click(object sender, EventArgs e)
        {
            ChooseNursesProcess(1);
            if(listNursesID.ContainsKey(1))
            {
                lbNurse1.Text = listNursesID[1].ToString();
            }
        }

        private void btnChooseNurse2_Click(object sender, EventArgs e)
        {
            ChooseNursesProcess(2);
            if(listNursesID.ContainsKey(2))
            {
                if(Mode==eMode.Udpdate)
                {
                    btnDeleteNurse2.Visible = listNursesID[2] != null;
                    lbNurse2.Text = listNursesID[2] != null ? listNursesID[2].ToString() : "N/A";
                    return;
                }


                lbNurse2.Text = listNursesID[2].ToString();
                btnDeleteNurse2.Visible = true;
            }
        }

        private void btnDeleteNurse2_Click(object sender, EventArgs e)
        {
            listNursesID[2] = null;
            lbNurse2.Text = "N/A";
            btnDeleteNurse2.Visible = false;
        }

        private void changeButtonsEnabledStatusForNurse(bool IsEnabled)
        {
            btnChooseNurse1.Enabled=IsEnabled;
            btnChooseNurse2.Enabled = IsEnabled;
            btnDeleteNurse2.Enabled = IsEnabled;
            btnFinishNurse.Enabled = IsEnabled;
            btnEditNurse.Enabled = !IsEnabled;
        }

        private void btnFinishNurse_Click(object sender, EventArgs e)
        {
            if (!listNursesID.ContainsKey(1))
            {
                if(Mode==eMode.Udpdate)
                {
                    if (listNursesID[1]==null)
                    {
                        MessageBox.Show("You must select At least one Nurse!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                MessageBox.Show("You must select At least one Nurse!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            changeButtonsEnabledStatusForNurse(false);
            FinishNurse = true;

            if(FinishDoctor)
            {
                btnSave.Visible = true;
            }
        }

        private void btnEditNurse_Click(object sender, EventArgs e)
        {
            changeButtonsEnabledStatusForNurse(true);
            btnSave.Visible = false;
            FinishNurse=false;
        }

        private void _LoadDataToObject()
        {
            SurgeryProcedure.DateOfProcedure = dateOfProcedure.Value.Date;
            SurgeryProcedure.Time = TimeOfProcedure.Value.TimeOfDay;

            SurgeryProcedure.FirstDoctorID = (int)listDoctorsID[1];
            SurgeryProcedure.SecondDoctorID = listDoctorsID.ContainsKey(2) ? listDoctorsID[2] : null;
            SurgeryProcedure.ThirdDoctorID = listDoctorsID.ContainsKey(3) ? listDoctorsID[3] : null;

            SurgeryProcedure.FirstNurseID = (int)listNursesID[1];
            SurgeryProcedure.SecondNurseID = listNursesID.ContainsKey(2) ? listNursesID[2] : null;

            SurgeryProcedure.PatientID = this.PatientID;
            SurgeryProcedure.SurgeryProcedureTypeID=clsSurgery.GetSurgeryTypeIDByName(cbxSurgeryTypes.Text);
            SurgeryProcedure.RoomID = clsHSInformation.GetRoomIDByRoomNumber(Convert.ToInt32(cbxRoomNum.Text));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You sure to add this Surgery Procedure?","Warnning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.Cancel)
            {
                return;
            }

            _LoadDataToObject();

            if(!SurgeryProcedure._Save())
            {
                MessageBox.Show("There is somthing Error,The Process has been Cancled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("The Process has been Done Successfully!");
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _EnabledCheckButton()
        {
            if (Mode == eMode.Udpdate)
            {
                btnCheck.Enabled = true;
                btnSave.Visible = false;
            }
        }

        private void dateOfProcedure_ValueChanged(object sender, EventArgs e)
        {
            _EnabledCheckButton();
        }

        private void TimeOfProcedure_ValueChanged(object sender, EventArgs e)
        {
            _EnabledCheckButton();

        }

        private void cbxSurgeryTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            _EnabledCheckButton();

        }

        private void cbxRoomNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            _EnabledCheckButton();

        }


    }
}
