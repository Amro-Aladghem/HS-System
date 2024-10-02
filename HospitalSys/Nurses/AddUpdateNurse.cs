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
    public partial class AddUpdateNurse : Form
    {
        enum eMode { AddNew = 1, Update = 2 };
        eMode Mode;

        public delegate void AfterChanging(clsNurses Nurse);
       public AfterChanging AfterChangingDataBack;

        public AddUpdateNurse()
        {
            InitializeComponent();
            Mode = eMode.AddNew;
            lbHeader.Text = "Add Nurse :";
        }

        public AddUpdateNurse(clsNurses Nurse)
        {
            InitializeComponent();
            this.Nurse = Nurse;
            Mode = eMode.Update;
            lbHeader.Text = "Update Nurse :";
        }


        private void ctrAddUpdateNurse1_OnSaveClick(object sender, ctrAddUpdateNurse.clsOnSaveClick e)
        {
            lbHeader.Text = "Update Nurse:";
            AfterChangingDataBack?.Invoke(e.Nurse);
            Mode = eMode.Update;
        }


        clsNurses Nurse;

        private void AddUpdateNurse_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                var data1 = clsHSInformation.GetAllSectionsInSys();

                this.Invoke((Action)(() =>
                {
                    ctrAddUpdateNurse1.LoadDataToCbxs(data1);
                    if (Mode == eMode.Update)
                    {
                        ctrAddUpdateNurse1.GetObjectAndLoadData(Nurse);
                    }

                }));

            });
        }

        private void btnExits_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
