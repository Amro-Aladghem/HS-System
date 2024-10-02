using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace clsBusineesLayer
{
    public class clsNurses :clsPersons
    {
        enum eMode { AddNew=1,Update=2}
        eMode Mode;

        public int NurseID { get; set; }
        public int SectionTypeID { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsActive { get; set; }
        public decimal Salary { get; set; }


        public clsNurses()
        {
            this.NurseID        = -1;
            this.SectionTypeID  = -1;
            this.IsAvailable    = true;
            this.IsActive       = true;
            this.Salary         = 0;

            Mode = eMode.AddNew;
        }

        public clsNurses(int nurseID,clsPersons Person, int sectionTypeID, bool isAvailable, bool isActive, decimal salary )
        {
            NurseID = nurseID;
            SectionTypeID = sectionTypeID;
            IsAvailable = isAvailable;
            IsActive = isActive;
            Salary = salary;

            base.PersonID = Person.PersonID;
            base.Firstname = Person.Firstname;
            base.SecondName = Person.SecondName;
            base.LastName = Person.LastName;
            base.PhoneNum = Person.PhoneNum;
            base.Email = Person.Email;
            base.NationalNum = Person.NationalNum;
            base.Gendor = Person.Gendor;
            base.DateOfBirth = Person.DateOfBirth;

            Mode = eMode.Update;

        }

        public static clsNurses FindNurseByID(int NurseID)
        {
            int SectionTypeID = 1,PersonID=0;bool IsAvailable = false,IsActive = false;
            decimal Salary = 0; 

            if(clsNursesData.GetFullRecordByID(NurseID,ref PersonID,ref SectionTypeID,ref IsAvailable,ref IsActive,ref Salary ))
            {
                clsPersons Person = FindPersonByID(PersonID);

                return new clsNurses(NurseID, Person, SectionTypeID, IsAvailable, IsActive, Salary);
            }
            else
            {
                return null;
            }
        }

        public static clsNurses FindNurseByName(string FirstName,string LastName)
        {
            int SectionTypeID = 1, PersonID = 0,NurseID=-1; bool IsAvailable = false, IsActive = false;
            decimal Salary = 0;

            if (clsNursesData.GetFullRecordByName(FirstName,LastName,ref NurseID, ref PersonID, ref SectionTypeID, ref IsAvailable, ref IsActive, ref Salary))
            {
                clsPersons Person = FindPersonByID(PersonID);

                return new clsNurses(NurseID, Person, SectionTypeID, IsAvailable, IsActive, Salary);
            }
            else
            {
                return null;
            }
        }

        private bool _AddNewNurse()
        {
            this.NurseID = clsNursesData.AddNewRecord(base.PersonID, this.SectionTypeID, this.IsAvailable, this.IsActive, this.Salary);
            return NurseID != -1;
        }

        private bool _UpdateNurse()
        {
            return clsNursesData.UpdateRecord(this.NurseID, this.SectionTypeID, this.Salary, this.IsActive);
        }

        public override bool Save()
        {
            base.Mode = (clsPersons.eMode)Mode;
            if(!base.Save())
            {
                return false;
            }

            switch(Mode)
            {
                case eMode.AddNew:
                    {
                        if(_AddNewNurse())
                        {
                            Mode = eMode.Update;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                case eMode.Update:
                    {
                        if(_UpdateNurse())
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                default:return false;

            }
        }

        public static DataTable GetAllNursesRecordInSys()
        {
            return clsNursesData.GetAllRecordsInSys();
        }

        public static bool DeleteRecord(int NurseID)
        {
            return clsNursesData.DeleteRecord(NurseID);
        }

        public bool DeleteRecord()
        {
            return clsNursesData.DeleteRecord(NurseID);
        }

        public static bool ChangeTheStatusOfNurse(int NurseID,bool IsActive)
        {
            return clsNursesData.ChangeTheActivateStatus(NurseID, IsActive);
        }

        public bool ChangeTheStatusOfNurse(bool IsActive)
        {
            return clsNursesData.ChangeTheActivateStatus(this.NurseID, IsActive);
        }



    }
}
