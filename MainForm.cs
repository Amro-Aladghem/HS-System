using clsBusineesLayer;
using HospitalProject.Appointments;
using HospitalProject.Doctors;
using HospitalProject.LabTests;
using HospitalProject.Loging;
using HospitalProject.Medicals;
using HospitalProject.Nurses;
using HospitalProject.OtherEmployee;
using HospitalProject.PateintsRecords;
using HospitalProject.Patients;
using HospitalProject.SurgeryProcedures;
using HospitalProject.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalProject
{
    public partial class MainForm : Form
    {
        public MainForm(Form frm)
        {
            InitializeComponent();
            LogFrom = frm;
        }

        Form LogFrom;


        private void PerformUserPermisions()
        {
            clsUsers User = clsGlobal.User;

            int counter = 1;
            foreach (ToolStripMenuItem Item in menuStrip1.Items)
            {
                if ((User.Permistion & Convert.ToInt32(Item.Tag)) == counter)
                {
                    Item.Enabled = true;
                }
                else
                {
                    Item.Enabled = false;
                }

                counter *= 2;
            }


            foreach(ToolStripMenuItem Item in menuStrip2.Items)
            {
                if ((User.Permistion & Convert.ToInt32(Item.Tag)) == counter)
                {
                    Item.Enabled = true;
                }
                else
                {
                    Item.Enabled = false;
                }

                counter *= 2;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void MainMenue_Load(object sender, EventArgs e)
        {

            Task.Run(() =>
            {
        
                this.Invoke((Action)(() =>
                {
                    toolStripUser.Text = clsGlobal.User.UserName;
                    PerformUserPermisions();
                }));

            });
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void doctorsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListOfDoctors frm =new ListOfDoctors();
            frm.ShowDialog();
        }

        private void findDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindDoctor frm = new FindDoctor();
            frm.Show();
        }

        private void addDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUpdateDoctor frm = new AddUpdateDoctor();
            frm.Show();

        }

        private void nursesListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListOfNurses frm =new ListOfNurses();
            frm.ShowDialog();
        }

        private void findNurseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindNurse frm = new FindNurse();
            frm.ShowDialog();
        }

        private void addNurseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUpdateNurse frm = new AddUpdateNurse();
            frm.ShowDialog();
        }

        private void employeeListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeList frm = new EmployeeList();
            frm.ShowDialog();
        }

        private void findEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindEmployee frm = new FindEmployee();
            frm.ShowDialog();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUpdateEmployee frm = new AddUpdateEmployee();
            frm.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void userListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListOfUsers frm = new ListOfUsers();
            frm.ShowDialog();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewUser frm = new AddNewUser();
            frm.ShowDialog();
        }

        private void findUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindUser frm = new FindUser();
            frm.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void userInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInfo frm = new UserInfo(clsGlobal.User);
            frm.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsGlobal.User = null;
            LogFrom.Show();
            this.Close();
        }

        private void patientListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListOfPatients frm = new ListOfPatients();
            frm.ShowDialog();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            AddUpdate_Patient frm = new AddUpdate_Patient();
            frm.ShowDialog();
        }

        private void findPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindPatient frm = new FindPatient();
            frm.ShowDialog();
        }

        private void patientsRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatientsRecordsList frm = new PatientsRecordsList();
            frm.ShowDialog();
        }

        private void addNewRecordForPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewPatientRecordHS frm = new AddNewPatientRecordHS();
            frm.ShowDialog();
        }

        private void findPatientsRecordHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatientsRecordHistory frm = new PatientsRecordHistory();
            frm.ShowDialog();
        }

        private void findReceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindRecentlyRecordForPatient frm = new FindRecentlyRecordForPatient();
            frm.ShowDialog();
        }

        private void addNewMedicalTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUpdateMedicalInSys frm = new AddUpdateMedicalInSys();
            frm.ShowDialog();
        }

        private void listOfSysMedicalsTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListOfMedicalTypeInSys frm = new ListOfMedicalTypeInSys();
            frm.ShowDialog();
        }

        private void addNewMedicalQuantityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewMedicalQuantityInStorage frm = new AddNewMedicalQuantityInStorage();
            frm.ShowDialog();
        }

        private void listOfMedicalInStorageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListOfMedicalsInStorage frm = new ListOfMedicalsInStorage();
            frm.ShowDialog();
        }

        private void findMedicalRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindMedicalRecordInStorage frm = new FindMedicalRecordInStorage();
            frm.ShowDialog();
        }

        private void findAllRecordsForMedicalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllQuantityRecordsForMedical frm = new AllQuantityRecordsForMedical();
            frm.ShowDialog();
        }

        private void addNewAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewAppointment frm = new AddNewAppointment();
            frm.ShowDialog();
        }

        private void appointmentsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListOfAppoointments frm = new ListOfAppoointments();
            frm.ShowDialog();
        }

        private void findAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindAppointment frm = new FindAppointment();
            frm.ShowDialog();
        }

        private void findAppointmentsForDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListOfAllActiveAppointmentForDoctor frm = new ListOfAllActiveAppointmentForDoctor();
            frm.ShowDialog();
        }

        private void labTestsHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListOfLapTestsHistory frm = new ListOfLapTestsHistory();
            frm.ShowDialog();
        }

        private void addNewTestForPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookANewLapTest frm = new BookANewLapTest();
            frm.ShowDialog();
        }

        private void addResultForTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddResultForTest frm = new AddResultForTest();
            frm.ShowDialog();
        }

        private void findPatientTestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllTestsForPatient frm = new AllTestsForPatient();
            frm.ShowDialog();
        }

        private void findLapTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindLapTest frm = new FindLapTest();
            frm.ShowDialog();
        }

        private void listOfSurgeryProcedureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListOfSurgeryProcedures frm = new ListOfSurgeryProcedures();
            frm.ShowDialog();
        }

        private void addNewSurgeryProcedureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewSurgeryProcedureAppointment frm = new AddNewSurgeryProcedureAppointment();
            frm.ShowDialog();
        }

        private void findSurgeryProcedureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindSurgeryProcedure frm = new FindSurgeryProcedure();
            frm.ShowDialog();
        }

        private void listOfAllSurgeryDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListOfAllSurgeryDoctorcs frm = new ListOfAllSurgeryDoctorcs();
            frm.ShowDialog();
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            ListOfAllNurses frm = new ListOfAllNurses();
            frm.ShowDialog();
        }

        private void patientProcedursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllSurgeryProcedureForPaients frm = new AllSurgeryProcedureForPaients();
            frm.ShowDialog();
        }
    }
}
