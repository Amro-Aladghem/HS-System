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
    public partial class ctrUserInfo : UserControl
    {
        enum eTypePerson { Doctor=0,Nurse=1,Employee=3}
        eTypePerson TypePerson;

        public ctrUserInfo()
        {
            InitializeComponent();
        }

        clsUsers User;

        public void SetObject(clsUsers User)
        {
            this.User = User;
            _LoadData();
        }

        private void CheckedThePermisionList()
        {
            int Counter = 1;

            for (int i = 0; i <= 11; i++)
            {
                if ((Counter & User.Permistion) == Counter)
                {
                    cbPermision.SetItemChecked(i, true);
                }

                Counter *= 2;
            }
        }

        private int _GetPersonID()
        {
            if (User.DoctorID != null)
            {
                return (int)User.DoctorID;
            }
            else if (User.NurseID != null)
            {
                return (int)User.NurseID;
            }
            else
            {
                return (int)User.EmployeeID;
            }

        }

        private void _LoadData()
        {
            if(User!=null)
            {
                txtUserName.Text=User.UserName;
                lbUserID.Text = User.UserID.ToString();
                txtPassword.Text = "******";
                cbActive.Checked = User.IsActive;
                CheckedThePermisionList();
                lbPerson.Text = _GetPersonID().ToString();
            }

        }




        private void ctrUserInfo_Load(object sender, EventArgs e)
        {

        }

        private void cbPermision_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
