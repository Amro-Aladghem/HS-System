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
    public partial class DoctorInfo : Form
    {
        public DoctorInfo(clsDoctors Doctor)
        {
            InitializeComponent();
            this.Doctor= Doctor;    
        }

        clsDoctors Doctor;



        private void btnExits_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DoctorInfo_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                this.Invoke((Action)(() =>
                {
                   ctrDoctorInfo1.GetObjectAndLoadData(Doctor);
                }));

            });
        }
    }
}
