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

namespace HospitalSys.Medicals
{
    public partial class UpdateMedicalInStorage : Form
    {
        public UpdateMedicalInStorage(clsMedicals Medical)
        {
            InitializeComponent();
            ctrEditMedicalRecordInStorage1.GetObjectAndLoadForm(Medical);
        }

        private void btnExsits_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateMedicalInStorage_Load(object sender, EventArgs e)
        {

        }
    }
}
