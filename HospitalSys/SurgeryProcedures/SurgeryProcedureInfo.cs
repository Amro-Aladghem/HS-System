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

namespace HospitalSys.SurgeryProcedures
{
    public partial class SurgeryProcedureInfo : Form
    {
        clsSurgery Surgery;
        public SurgeryProcedureInfo(clsSurgery Surgery)
        {
            InitializeComponent();
            this.Surgery = Surgery;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SurgeryProcedureInfo_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                this.Invoke((Action)(() =>
                {
                    ctrSurgeryInfo1.GetObjectAndLoadData(Surgery);
                }));

            });
        }
    }
}
