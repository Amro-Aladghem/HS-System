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

namespace HospitalSys.Patients
{
    public partial class ctrPatientInfoWithFilter : UserControl
    {
        public ctrPatientInfoWithFilter()
        {
            InitializeComponent();
        }

        private void txtPatientID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNationalNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled= true;
            }
        }

        private void btnPatientSearch_Click(object sender, EventArgs e)
        {
            if(txtPatientID.Text=="")
            {
                MessageBox.Show("You must Fill Text Box!");
                return;
            }

            clsPateints pateints=clsPateints.FindPatientByID(Convert.ToInt32(txtPatientID.Text));
            if (pateints == null)
            {
                MessageBox.Show("No Patient with this ID","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            ctrPatientInfo1.GetObjectAndLoadData(pateints);
        }

        private void btnNationalSearch_Click(object sender, EventArgs e)
        {
            if (txtNationalNum.Text == "")
            {
                MessageBox.Show("You must Fill Text Box!");
                return;
            }

            clsPateints pateints = clsPateints.FindPatientByNationalNum(txtNationalNum.Text);
            if(pateints==null)
            {
                MessageBox.Show("No Patient with this National Num", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ctrPatientInfo1.GetObjectAndLoadData(pateints);
        }

        private void rdPatientID_CheckedChanged(object sender, EventArgs e)
        {
            gbPatientID.Visible = true;
            gbNationalNum.Visible = false;
        }

        private void rdNationalNum_CheckedChanged(object sender, EventArgs e)
        {
            gbNationalNum.Visible = true;
            gbPatientID.Visible = false;
        }

        private void ctrPatientInfoWithFilter_Load(object sender, EventArgs e)
        {
            rdPatientID.Checked = true;
        }
    }
}
