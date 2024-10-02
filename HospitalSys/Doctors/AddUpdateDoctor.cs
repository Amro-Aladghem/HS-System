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
    public partial class AddUpdateDoctor : Form
    {
        enum eMode { AddNew=1,Update=2 };
        eMode Mode;

        clsDoctors Doctor;

        public delegate void AfterChanging(clsDoctors Doctor);
      public  AfterChanging AfterChangingDataBack;

        public AddUpdateDoctor()
        {
            InitializeComponent();
            Mode=eMode.AddNew;
            lbHeader.Text = "Add New Doctor:";
        }
        public AddUpdateDoctor(clsDoctors Doctor)
        {
            InitializeComponent();
            this.Doctor = Doctor;
            lbHeader.Text = "Update Doctor:";
            Mode = eMode.Update;
        }


        private void AddUpdateDoctor_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                var data = clsHSInformation.GetAllSpecialistTypeInSys();
                var data1 = clsHSInformation.GetAllSectionsInSys();

                this.Invoke((Action)(() =>
                {
                    ctrAddUpdateDoctorcs1.LoadDataToCbxs(data1, data);
                    if(Mode==eMode.Update)
                    {
                        ctrAddUpdateDoctorcs1.GetObjectAndLoadData(Doctor);
                    }

                }));

            });
        }

        private void ctrAddUpdateDoctorcs1_OnSaveClick(object sender, ctrAddUpdateDoctorcs.clsAfterSave e)
        {
            Mode = eMode.Update;
            lbHeader.Text = "Update Doctor:";
            AfterChangingDataBack?.Invoke(e.Doctor);
        }

        private void btnExits_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
