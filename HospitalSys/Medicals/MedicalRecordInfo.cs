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

namespace HospitalSys.Medicals
{
    public partial class MedicalRecordInfo : Form
    {
        public MedicalRecordInfo(clsMedicals Medical)
        {
            InitializeComponent();
            ctrMedicalRecordInfo1.GetObjectAndLoadData(Medical);
        }



        private void btnExits_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MedicalRecordInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
