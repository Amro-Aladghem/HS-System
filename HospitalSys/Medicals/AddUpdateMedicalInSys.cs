using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalSys.Medicals
{
    public partial class AddUpdateMedicalInSys : Form
    {
        enum eMode { AddNew=1,Update=2}
        eMode Mode;


        public AddUpdateMedicalInSys()
        {
            InitializeComponent();
            Mode = eMode.AddNew;
            lbHeader.Text = "Add Medical Sys:";
        }

        public AddUpdateMedicalInSys(string MedicalTypeQR)
        {
            InitializeComponent();
            ctrAddUpdateMedicalTypeInSys1.GetQRAndLoadData(MedicalTypeQR);
            Mode = eMode.Update;
            lbHeader.Text = "Update Medical Sys:";
        }

        private void btnExits_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddUpdateMedicalInSys_Load(object sender, EventArgs e)
        {

        }

        private void ctrAddUpdateMedicalTypeInSys1_OnSaveClick(object sender, EventArgs e)
        {
            lbHeader.Text = "Update Medical Sys:";
        }
    }
}
