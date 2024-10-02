using clsBusineesLayer;
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

namespace HospitalSys.Medicals
{
    public partial class ctrAddUpdateMedicalTypeInSys : UserControl
    {
        enum eMode { AddNew=1,Update=2}
        eMode Mode;

        string MedicalQR = "", MedicalName = "";

        public event EventHandler OnSaveClick;

        public ctrAddUpdateMedicalTypeInSys()
        {
            InitializeComponent();
            Mode = eMode.AddNew;
        }

        public void GetQRAndLoadData(string MedicalQR)
        {
            this.MedicalQR = MedicalQR;
            this.MedicalName= clsMedicals.GetMedicalNameByQR(MedicalQR);
            Mode = eMode.Update;
            _LoadData();
            txtMedicalName.Enabled = false;
        }

        private void _LoadData()
        {
            txtMedicalName.Text = MedicalName;
            txtMedicalQR.Text=MedicalQR;
        }

        private bool _IsExsitsInSys()
        {
            if(Mode==eMode.AddNew)
            {
                if (clsMedicals.IsMedicalTypeExitsInSys(txtMedicalQR.Text))
                {
                    return true;
                }
            }

            return false;
        }
       
        private bool _PerformSaveProcess()
        {
            switch(Mode)
            {
                case eMode.AddNew:
                    if (!clsMedicals.AddNewMedicalTypeInSys(txtMedicalQR.Text, txtMedicalName.Text))
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case eMode.Update:
                    if(!clsMedicals.UpdateMedicalTypeInSys(MedicalQR,txtMedicalQR.Text))
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                default: return false;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!ValidateChildren())
            {
                return;
            }

            if(MessageBox.Show("Are You Sure To Add/Update This Medical?","Warnning",MessageBoxButtons.OK,MessageBoxIcon.Warning)==DialogResult.Cancel)
            {
                return;
            }

            if (_IsExsitsInSys())
            {
                MessageBox.Show("This QR Code is Exits In Sys You Can't Add Two different midecale with same code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(!_PerformSaveProcess())
            {
                MessageBox.Show("Somting Error,The Process has been Cancled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("The Proccess has been done Successfully!");
            OnSaveClick(null, null);
            txtMedicalName.Enabled = false;

        }

        private void ctrAddUpdateMedicalTypeInSys_Load(object sender, EventArgs e)
        {

        }

        private void txtMedicalQR_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtMedicalQR.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtMedicalQR, "You must Fill it!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtMedicalQR, "");
            }
        }

        private void txtMedicalName_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtMedicalName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtMedicalName, "You must Fill it!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtMedicalName, "");
            }
        }


    }
}
