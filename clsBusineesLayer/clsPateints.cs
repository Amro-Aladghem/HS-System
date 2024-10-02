using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace clsBusineesLayer
{
    public  class clsPateints:clsPersons
    {
        enum eMode { AddNew=1,Update=2}
        eMode Mode;

        public int PatinetID { get; set; }
        public string Nationality { get; set; }
        public string Address { get; set; }
        public int ? BloodTypeID { get; set; }
        public string RelativeNumber { get; set; }

        public clsPateints()
        {
            this.PatinetID      = -1;
            this.Nationality    = string.Empty;
            this.Address        = string.Empty;
            this.BloodTypeID    = null;
            this.RelativeNumber = string.Empty;

            Mode = eMode.AddNew;
        }

        public clsPateints(int PatinetID,clsPersons Person,string Nationality,string Address,int? BloodTypeID,string RelativeNumber)
        {
            this.PatinetID = PatinetID;
            this.Nationality = Nationality;
            this.Address= Address;
            this.BloodTypeID=BloodTypeID;
            this.RelativeNumber = RelativeNumber;

            base.PersonID = Person.PersonID;
            base.Firstname = Person.Firstname;
            base.SecondName = Person.SecondName;
            base.LastName = Person.LastName;
            base.PhoneNum = Person.PhoneNum;
            base.Email = Person.Email;
            base.NationalNum = Person.NationalNum;
            base.Gendor = Person.Gendor;
            base.DateOfBirth = Person.DateOfBirth;
            base.OldPhoneNumber = Person.PhoneNum;
            base.OldEmail = Person.Email;

            Mode = eMode.Update;
        }

        public static clsPateints FindPatientByID(int PatientID)
        {
            int PersonID = -1;int?BloodTypeID = null;
            string RelativeNumber = null, Nationality = "", Address = "";

            if (clsPatinetsData.GetFullRecordByID(PatientID, ref PersonID, ref Nationality, ref Address, ref BloodTypeID, ref RelativeNumber))
            {
                clsPersons Person = FindPersonByID(PersonID);

                return new clsPateints(PatientID, Person, Nationality, Address, BloodTypeID, RelativeNumber);
            }
            else
            {
                return null;
            }
        }

        public static clsPateints FindPatientByNationalNum(string NationalNum)
        {
            int PersonID = -1, PatientID = -1 ; int? BloodTypeID = null;
            string RelativeNumber = null, Nationality = "", Address = "";

            if (clsPatinetsData.GetFullRecordByNationalNum(NationalNum,ref PatientID, ref PersonID, ref Nationality, ref Address, ref BloodTypeID, ref RelativeNumber))
            {
                clsPersons Person = FindPersonByID(PersonID);

                return new clsPateints(PatientID, Person, Nationality, Address, BloodTypeID, RelativeNumber);
            }
            else
            {
                return null;
            }
        }

        private bool _AddNewPatient()
        {
            this.PatinetID = clsPatinetsData.AddNewRecord(this.PersonID, this.Nationality, this.Address, this.BloodTypeID, this.RelativeNumber);
            return PatinetID != -1;
        }

        private bool _UpdatePatient()
        {
            return clsPatinetsData.UpdateRecord(this.PatinetID, this.Address, this.BloodTypeID, this.RelativeNumber);
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
                    if(_AddNewPatient())
                    {
                        Mode = eMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case eMode.Update:
                    if(_UpdatePatient())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                 default: return false;
            }

        }

        public static DataTable GetAllPatientInSys()
        {
            return clsPatinetsData.GetAllPatientRecord();
        }

        public static bool DeletePatient(int PatientID)
        {
            return clsPatinetsData.DeleteRecord(PatientID);
        }

        public bool DeletePatient()
        {
            return clsPatinetsData.DeleteRecord(this.PatinetID);
        }

        public static bool IsPatientExitsInSys(string NationalNum)
        {
            return clsPatinetsData.IsPatientExitsInSys(NationalNum);
        }

        public static DataTable GetAllTestForPatientThatIsNotPaid(int PatientID)
        {
            return clsPatinetsData.GetAllTestForPatientThatIsNotPaid(PatientID);
        }

        public static DataTable GetAllSurgeryProcederForPatientThatIsNotPaid(int PatientID)
        {
            return clsPatinetsData.GetAllSurgeryProcederForPatientThatIsNotPaid(PatientID);
        }

        public static DataTable GetPatientRecord(int PatientID)
        {
            return clsPatinetsData.GetPatientRecord(PatientID);
        }

        public static decimal GetTotalTestsCostForPatient(int PatientID)
        {
            return clsPatinetsData.GetTotalTestsCostForPatient(PatientID);
        }

        public static decimal GetTotalSurgeryProcedureCostForPatient(int PatientID)
        {
            return clsPatinetsData.GetTotalSurgeryProcedureCostForPatient(PatientID);
        }

        public static void MakeTestsPaidForPatient(List<int>TestIDs)
        {
            foreach(int testID in TestIDs)
            {
                clsPatinetsData.MakeTestIsPaidForPatient(testID);
            }
        }

        public static void MakeSurgeysPaidForPatient(List<int>ProcedureIDs)
        {
            foreach(int  procedureID in ProcedureIDs)
            {
                clsPatinetsData.MakeSuregryProcedurePaidForPatient(procedureID);
            }
        }

    }
}
