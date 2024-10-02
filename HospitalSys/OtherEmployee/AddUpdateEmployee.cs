using clsBusineesLayer;
using HospitalSys.Doctors;
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
    public partial class AddUpdateEmployee : Form
    {
        enum eMode { Addnew=1,Update=2 };
        eMode Mode;

        clsOtherEmployee Employee;

        public delegate void AfterChanging(clsOtherEmployee otherEmployee);
       public AfterChanging AfterChangingDataBack;
         

        public AddUpdateEmployee()
        {
            InitializeComponent();
            Employee= new clsOtherEmployee();
            Mode = eMode.Addnew;
            lbHeader.Text = "Add Employee:";
        }

        public AddUpdateEmployee(clsOtherEmployee Employee)
        {
            InitializeComponent();
            this.Employee = Employee;
            Mode=eMode.Update;
            lbHeader.Text = "Update Employee:";
        }



        private void AddUpdateEmployee_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                var data = clsHSInformation.GetAllJopRoleInSys();
                var data1 = clsHSInformation.GetAllSectionsInSys();

                this.Invoke((Action)(() =>
                {
                    ctrAddUpdateEmployee1.LoadDataToCbxs(data1, data);
                    if (Mode == eMode.Update)
                    {
                        ctrAddUpdateEmployee1.GetObjectAndLoadData(Employee);
                    }

                }));

            });
        }

        private void ctrAddUpdateEmployee1_OnSaveClick(object sender, ctrAddUpdateEmployee.clsAfterSave e)
        {
            lbHeader.Text = "Update Employee:";
            Mode = eMode.Update;
            AfterChangingDataBack?.Invoke(e.Employee);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
