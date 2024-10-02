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

namespace HospitalSys.LabTests
{
    public partial class TestInfo : Form
    {
        clsLapTests LapTest;
        public TestInfo(clsLapTests Test)
        {
            InitializeComponent();
            this.LapTest = Test;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TestInfo_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                this.Invoke((Action)(() =>
                {
                    ctrTestLapInfo1.GetObjectAndLoadData(LapTest);
                }));

            });
        }
    }
}
