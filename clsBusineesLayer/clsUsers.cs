using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsBusineesLayer
{
    public class clsUsers
    { 
        enum eMode { Addnew=1,Udpate=2 };
        eMode Mode;

        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }    
        public int? DoctorID { get; set; }
        public int? NurseID { get; set; }
        public int? EmployeeID { get; set; }
        public bool IsActive { get; set; }
        public int Permistion { get; set; }

        public clsUsers()
        {

            this.UserID            = 0;
            this.UserName          = string.Empty;
            this.Password          = string.Empty;
            this.DoctorID          = null;
            this.NurseID           = null;
            this.EmployeeID        = null;
            this.IsActive          = true;
            this.Permistion        = 0;

            Mode = eMode.Addnew;
        }

        public clsUsers(int UserID, string UserName, string Password, int? DoctorID, int? NurseID, int? EmployeeID, bool IsActive, int Permistion)
        {
            this.UserID = UserID;
            this.UserName = UserName;
            this.Password = Password;
            this.DoctorID = DoctorID;
            this.NurseID = NurseID;
            this.EmployeeID = EmployeeID;
            this.IsActive = IsActive;
            this.Permistion = Permistion;

            Mode = eMode.Udpate;
        }

        public static clsUsers FindUserByID(int UserID)
        {
            string UserName = "", Password = ""; int?DoctorID=null,NurseID=null,EmployeeID=null;
            int Permisions = 0; bool IsActive = false;

            if(clsUserData.GetRecordByID(UserID,ref UserName,ref Password,ref DoctorID,ref NurseID,ref EmployeeID,ref IsActive,ref Permisions))
            {
                return new clsUsers(UserID, UserName, Password, DoctorID, NurseID, EmployeeID, IsActive, Permisions);
            }
            else
            {
                return null;
            }
        }

        public static clsUsers FindUserByName(string UserName)
        {
            string  Password = ""; int? DoctorID = null, NurseID = null, EmployeeID = null;
            int Permisions = 0; bool IsActive = false; int UserID = 0;

            if (clsUserData.GetRecordByName(ref UserID,  UserName, ref Password, ref DoctorID, ref NurseID, ref EmployeeID, ref IsActive, ref Permisions))
            {
                return new clsUsers(UserID, UserName, Password, DoctorID, NurseID, EmployeeID, IsActive, Permisions);
            }
            else
            {
                return null;
            }
        }



        private bool _AddNewUser()
        {
            this.UserID = clsUserData.AddNewRecord(this.UserName, this.Password, this.DoctorID, this.NurseID, this.EmployeeID, this.IsActive, this.Permistion);
            return this.UserID != -1;
        }

        private bool _UpdateUser()
        {
            return clsUserData.UpdateRecord(this.UserID, this.UserName, this.IsActive, this.Permistion);
        }

        public bool Save()
        {
            switch (Mode)
            {

                case eMode.Addnew:
                    {
                        if (_AddNewUser())
                        {
                            Mode = eMode.Udpate;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                case eMode.Udpate:
                    {
                        if (_UpdateUser())
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                default: return false;

            }
        }

        public static DataTable GetAllUsersRecord()
        {
            return clsUserData.GetAllUsersInSys();
        }

        public static bool DeleteUser(int UserID)
        {
            return clsUserData.DeleteRecord(UserID);
        }

        public static bool ChangePassword(int UserID,string NewPassword)
        {
            return clsUserData.ChangePassword(UserID, NewPassword);
        }

        public bool ChangePassword(string NewPassword)
        {
            return clsUserData.ChangePassword(this.UserID, NewPassword);
        }

        public static bool IsPersonIsAlreadyAUser(int PersonID)
        {
            return clsUserData.IsUserAlreadyExists(PersonID);
        }

       











    }

}
