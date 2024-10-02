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
    public partial class ctrMedicalRecordInfo : UserControl
    {
        clsMedicals Medical;

        public ctrMedicalRecordInfo()
        {
            InitializeComponent();
        }

        public void GetObjectAndLoadData(clsMedicals Medical)
        {
            this.Medical = Medical;
            _LoadDataToForm();
        }

        private void _LoadDataToForm()
        {
            lbMedicalID.Text = Medical.MedicalID.ToString();
            lbMedicalQR.Text = Medical.MedicalTypeQR;
            numaricQuantity.Value = (decimal)Medical.Quantity;
            numaricPrice.Value=Medical.Price;
            dateTimePicker1.Value = Medical.ProducedDate;
            dateExpired.Value = Medical.ExpiaredDate;
        }


        private void ctrMedicalRecordInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
