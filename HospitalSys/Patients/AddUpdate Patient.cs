using clsBusineesLayer;
using HospitalSys.Nurses;
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
    public partial class AddUpdate_Patient : Form
    {
 
        enum eMode { AddNew=1,Update=2}
        eMode Mode;

        clsPateints Pateint;

        public delegate void AfterSave(clsPateints Pateint);
        public AfterSave AfterSaveDataBack;
        public AddUpdate_Patient()
        {
            InitializeComponent();
            Mode = eMode.AddNew;
            lbHeader.Text = "Adding Patient:";
        }

        public AddUpdate_Patient(clsPateints pateints)
        {
            InitializeComponent();
            Mode = eMode.Update;
            Pateint = pateints;
            lbHeader.Text = "Update Patient:";
        }




        private void AddUpdate_Patient_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {

                this.Invoke((Action)(() =>
                {
                    
                    if (Mode == eMode.Update)
                    {
                        ctrAddUpdatePatient1.GetObjectAndLoadData(Pateint);
                    }

                }));

            });
        }

       

        private void btnExits_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrAddUpdatePatient1_Load(object sender, EventArgs e)
        {

        }

        private void ctrAddUpdatePatient1_AfterSaving(object sender, ctrAddUpdatePatient.clsAfterSaving e)
        {

            lbHeader.Text = "Update Patient:";
            Mode = eMode.Update;
            AfterSaveDataBack?.Invoke(e.Pateints);
            this.Close();
        }
    }
}
