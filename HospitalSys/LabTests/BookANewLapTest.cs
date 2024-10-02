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
    public partial class BookANewLapTest : Form
    {
        public BookANewLapTest()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BookANewLapTest_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                var data = clsLapTests.GetAllTestTypeInSys();

                this.Invoke((Action)(() =>
                {
                   ctrBookANewLabTest1.LoadDataToCbx(data); 
                }));

            });
        }
    }
}
