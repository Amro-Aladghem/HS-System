using clsBusineesLayer;
using HospitalSys.Nurses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalSys.OtherEmployee
{
    public partial class EmployeeInfo : Form
    {
        public EmployeeInfo(clsOtherEmployee Employee)
        {
            InitializeComponent();
            this.Employee = Employee;
        }

        clsOtherEmployee Employee;


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EmployeeInfo_Load(object sender, EventArgs e)
        {

            this.Invoke((Action)(() =>
            {
                ctrEmployeInfo1.GetObjectAndLoadDataToForm(Employee);
            }));
        }

        private void btnExits_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
