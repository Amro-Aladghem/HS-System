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
    public partial class ctrSurgeryInfoWithFilter : UserControl
    {
        public ctrSurgeryInfoWithFilter()
        {
            InitializeComponent();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text=="")
            {
                MessageBox.Show("You must Fill Tect Box!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            clsSurgery Surgery =clsSurgery.FindSurgeryProcedureByID(Convert.ToInt32(txtSearch.Text));
            if(Surgery==null)
            {
                MessageBox.Show("No Surgery With This ID, Please Check the Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ctrSurgeryInfo2.GetObjectAndLoadData(Surgery);
        }
    }
}
