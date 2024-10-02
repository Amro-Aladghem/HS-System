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
    public partial class FindPatient : Form
    {
        public FindPatient()
        {
            InitializeComponent();
        }

        private void FindPatient_Load(object sender, EventArgs e)
        {

        }

        private void btnExits_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
