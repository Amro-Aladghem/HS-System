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

namespace HospitalSys.Users
{
    public partial class UpdatePaswords : Form
    {
        public UpdatePaswords(clsUsers User)
        {
            InitializeComponent();
            changePassword1.SetUser(User);
        }

        private void btnExits_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdatePaswords_Load(object sender, EventArgs e)
        {

        }
    }
}
