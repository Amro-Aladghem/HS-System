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

namespace HospitalSys.Nurses
{
    public partial class NurseInfo : Form
    {
        public NurseInfo(clsNurses Nurse)
        {
            InitializeComponent();
            this.Nurse = Nurse;
        }

        clsNurses Nurse;

        private void NurseInfo_Load(object sender, EventArgs e)
        {

            this.Invoke((Action)(() =>
            {
                ctrNurseInfo1.GetObjectAndLoadData(Nurse);
            }));

        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
