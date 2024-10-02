using DataAccessLayer;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsBusineesLayer
{
    public  class clsPersons
    {
      public  enum eMode { AddNew=1,Update=2 }
       public eMode Mode;


        public int PersonID { get; set; }
        public string Firstname { get; set; }   
        public string SecondName { get; set; }  
        public string LastName { get; set; }
        public string PhoneNum { get; set; }
        public string Email { get; set; }   
        public string NationalNum { get; set; }
        public bool Gendor { get; set; }
        public DateTime DateOfBirth { get; set; }

        protected  string OldPhoneNumber { get; set; }
        protected string OldEmail { get; set; }

        public clsPersons()
        {
            PersonID         = 0;
            Firstname        = string.Empty;
            SecondName       = string.Empty;
            LastName         = string.Empty;
            PhoneNum         = string.Empty;
            Email            = string.Empty;
            NationalNum      = string.Empty;
            Gendor           = false;
            DateOfBirth      = DateTime.MinValue;

            Mode = eMode.AddNew;
        }

        public clsPersons(int PersonID,string FirstName,string SecondName,string LastName,string PhoneNum,string Email,string NationalNum,bool Gendor,DateTime DateOfBirth)
        {
            this.PersonID = PersonID;
            this.Firstname = FirstName;
            this.SecondName = SecondName;
            this.LastName = LastName;
            this.PhoneNum = PhoneNum;
            this.Email = Email;
            this.NationalNum = NationalNum;
            this.Gendor = Gendor;
            this.DateOfBirth = DateOfBirth;

            Mode = eMode.Update;
        }

        public static clsPersons FindPersonByID(int PersonID)
        {
            string FirstName = "", SecondName = "", LastName = "", PhoneNum = "", Email = "", NationalNum = "";
            bool Gendor = false; DateTime DateOfBirth = DateTime.MinValue;

            if(clsPersonsData.GetFullRecordByID(PersonID,ref FirstName,ref SecondName,ref LastName,ref PhoneNum,ref Email,ref NationalNum,ref Gendor,ref DateOfBirth))
            {
                return new clsPersons(PersonID,FirstName,SecondName,LastName,PhoneNum,Email,NationalNum,Gendor,DateOfBirth);
            }
            else
            {
                return null;
            }
        }

        public static clsPersons FindPersonByNationalNum(string NationalNum)
        {
            string FirstName = "", SecondName = "", LastName = "", PhoneNum = "", Email = "";int PersonID = 0;
            bool Gendor = false; DateTime DateOfBirth = DateTime.MinValue;

            if (clsPersonsData.GetFullRecordByNationalNum(ref PersonID, ref FirstName, ref SecondName, ref LastName, ref PhoneNum, ref Email,  NationalNum, ref Gendor, ref DateOfBirth))
            {
                return new clsPersons(PersonID, FirstName, SecondName, LastName, PhoneNum, Email, NationalNum, Gendor, DateOfBirth);
            }
            else
            {
                return null;
            }
        }

        private bool _AddNewPersonRecord()
        {
            this.PersonID=clsPersonsData.AddNewPersonRecord(Firstname,SecondName,LastName,PhoneNum,Email, NationalNum,Gendor,DateOfBirth);
            return PersonID != -1;

        }

        private bool _UpdatePersonReocord()
        {
            if (OldEmail == Email && PhoneNum==OldPhoneNumber)
            {
                return true;
            }

            return clsPersonsData.UpdatePersonRecord(this.PersonID, this.PhoneNum, this.Email);
        }

        public virtual bool Save()
        {
            switch (Mode)
            {
                case eMode.AddNew:
                    {
                        if (_AddNewPersonRecord())
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
                        if (_UpdatePersonReocord())
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

        public static bool DeletePerson(int PersonID)
        {
            return clsPersonsData.DeletePerson(PersonID);
        }



    }
}
