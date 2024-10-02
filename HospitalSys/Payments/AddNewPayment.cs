using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalSys.Payments
{
    public partial class AddNewPayment : Form
    {
        public AddNewPayment()
        {
            InitializeComponent();
        }

        public AddNewPayment(bool IsInvoice)
        {
            InitializeComponent();
            ctrAddNewPayment1.SetInvoiceMode();
        }

        private void AddNewPayment_Load(object sender, EventArgs e)
        {

        }

        private void ctrAddNewPayment1_Load(object sender, EventArgs e)
        {

        }
    }
}
