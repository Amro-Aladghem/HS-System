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
    public partial class AddResultForTest : Form
    {
        int TestID = -1;
        public AddResultForTest()
        {
            InitializeComponent();
        }

        public AddResultForTest(int TestID)
        {
            InitializeComponent();
            this.TestID = TestID;
        }


        private void AddResultForTest_Load(object sender, EventArgs e)
        {
            if(TestID!=-1)
            {
                



            }
        }
    }
}
