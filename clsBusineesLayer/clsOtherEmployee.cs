using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsBusineesLayer
{
    public class clsOtherEmployee :clsPersons
    {
        enum eMode { AddNew=1,Update=2}
        eMode Mode;

        public int EmployeeID { get; set; }
        public int RolesJobID { get; set; }
        public int SectionTypeID { get; set; }
        public DateTime DateOfSet { get; set; }
        public decimal Salary { get; set; }

        public clsOtherEmployee()
        {
            this.EmployeeID          = -1;
            this.RolesJobID          = -1;
            this.SectionTypeID       = -1;
            this.Salary              = -1;
            this.DateOfSet           = DateTime.MinValue;

            Mode = eMode.AddNew;

        }

        public clsOtherEmployee(int EmployeeID,clsPersons Person,int  RolesJobID,int SectionTypeID,DateTime DateOfSet,decimal Salary)
        {
            this.EmployeeID = EmployeeID;
            this.RolesJobID = RolesJobID;
            this.SectionTypeID =SectionTypeID;
            this.Salary = Salary;
            this.DateOfSet = DateOfSet;

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

        public static clsOtherEmployee FindEmployeeByID(int EmployeeID)
        {
            int RolesJobID = 0, SectionTypeID = 0, PersonID = 0;
            DateTime DateOfSet =DateTime.MinValue;
            decimal Salary = 0;

            if (clsOtherEmployeesData.GetFullRecordByID(EmployeeID, ref PersonID, ref RolesJobID, ref SectionTypeID, ref DateOfSet, ref Salary))
            {
                clsPersons Person = FindPersonByID(PersonID);

                return new clsOtherEmployee(EmployeeID,Person,RolesJobID, SectionTypeID, DateOfSet, Salary);
            }
            else
            {
                return null;
            }
        }

        public static clsOtherEmployee FindEmployeeByName(string FirstName,string LastName)
        {
            int RolesJobID = 0, SectionTypeID = 0, PersonID = 0, EmployeeID = 0;
            DateTime DateOfSet = DateTime.MinValue;
            decimal Salary = 0;

            if (clsOtherEmployeesData.GetFullRecordByName(FirstName,LastName,ref EmployeeID, ref PersonID, ref RolesJobID, ref SectionTypeID, ref DateOfSet, ref Salary))
            {
                clsPersons Person = FindPersonByID(PersonID);

                return new clsOtherEmployee(EmployeeID, Person, RolesJobID, SectionTypeID, DateOfSet, Salary);
            }
            else
            {
                return null;
            }
        }

        private bool _AddNewEmployee()
        {
            this.EmployeeID = clsOtherEmployeesData.AddNewRecord(base.PersonID, this.RolesJobID, this.SectionTypeID, this.Salary);
            return EmployeeID != -1;
        }

        private bool _UpdateEmployee()
        {
            return clsOtherEmployeesData.UdpateRecord(this.EmployeeID,this.RolesJobID,this.SectionTypeID,this.Salary);
        }

        public override bool Save()
        {
            base.Mode = (clsPersons.eMode)Mode;
            if(!base.Save())
            {
                return false;
            }

            switch (Mode)
            {
                case eMode.AddNew:
                    {
                        if (_AddNewEmployee())
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
                        if (_UpdateEmployee())
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

        public static DataTable GetAllEmployeesInSys()
        {
            return clsOtherEmployeesData.GetAllRecordsInSys();
        }

        public static bool DeleteEmployee(int EmployeeID)
        {
            return clsOtherEmployeesData.DeleteRecord(EmployeeID);
        }

        public bool DeleteEmployee()
        {
            return clsOtherEmployeesData.DeleteRecord(EmployeeID);
        }














    }
}
