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
    public partial class ChangeMedicalQuantityPrice : Form
    {
        clsMedicals Medical;


        public ChangeMedicalQuantityPrice(clsMedicals Medical)
        {
            InitializeComponent();
            this.Medical = Medical;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numaricNewPrice_Validating(object sender, CancelEventArgs e)
        {
            if(numaricNewPrice.Value<=0)
            {
                e.Cancel = true;
                errorProvider1.SetError(numaricNewPrice, "The Price Must be above 0 JD");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(numaricNewPrice, "");
            }
        }

        private void ChangeMedicalQuantityPrice_Load(object sender, EventArgs e)
        {
            lbOldePrice.Text = Medical.Price.ToString() + "JD";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!ValidateChildren())
            {
                return;
            }

            decimal NewPrice = numaricNewPrice.Value;

            if (!clsMedicals.ChangeThePriceOfMedical(Medical.MedicalID, NewPrice))
            {
                MessageBox.Show("There is Somthing Error,The Process has been Cancled!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("The Price has been Changed Successfully!");
            this.Close();


        }
    }
}
