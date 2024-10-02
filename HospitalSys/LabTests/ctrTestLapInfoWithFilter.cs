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
    public partial class ctrTestLapInfoWithFilter : UserControl
    {
        clsLapTests LapTest;

        public class AfterSearchClick: EventArgs
        {
            public clsLapTests LapTest { get; set; }

            public AfterSearchClick(clsLapTests lapTest)
            {
                LapTest = lapTest;
            }
        }

        public event EventHandler<AfterSearchClick> OnSearchClick;


        public ctrTestLapInfoWithFilter()
        {
            InitializeComponent();
        }

        private void txtTestID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled= true;    
            }
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtTestID.Text=="")
            {
                MessageBox.Show("You must Fill TextBox","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

            LapTest=clsLapTests.FindTestRecordByID(Convert.ToInt32(txtTestID.Text));
            if(LapTest==null)
            {
                MessageBox.Show("No Lap Test With this ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ctrTestLapInfo1.GetObjectAndLoadData(LapTest);
            OnSearchClick?.Invoke(sender, new AfterSearchClick(LapTest));
        }

        private void ctrTestLapInfoWithFilter_Load(object sender, EventArgs e)
        {

        }
    }
}
