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

namespace HospitalSys.PateintsRecords
{
    public partial class ctrFindTheMostRecentlyRecordForPatient : UserControl
    {
        public ctrFindTheMostRecentlyRecordForPatient()
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtPatientID.Text =="")
            {
                MessageBox.Show("You must Fill Text Box!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            clsPatientRecords Record = clsPatientRecords.FindTheMostUpdateRecordForPatient(Convert.ToInt32(txtPatientID.Text));
            if(Record==null)
            {
                MessageBox.Show("No Records For this Patient!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error); return;
            }

            ctrRecordInfo1._GetObjectAndLoadData(Record);
        }
    }
}
