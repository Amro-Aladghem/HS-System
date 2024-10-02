using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsBusineesLayer
{
    public  class clsLapTests
    {
        enum eMode { AddNew=1,Update=2}
        eMode Mode;


        public int TestID { get; set; }
        public int PatientRecordID { get; set; }
        public int PatientID { get; set; }
        public int TestTypeID { get; set; }
        public bool IsPaid { get; set; }
        public DateTime DateOfTest { get; set; }
        public string FilePath { get; set; }
        public bool IsDone { get; set; }


        public clsLapTests()
        {
            this.TestID          = -1;
            this.PatientRecordID = -1;
            this.PatientID       = -1;
            this.TestTypeID      = -1;
            this.IsPaid          = false;
            this.DateOfTest      = DateTime.Now;
            this.FilePath        = "";

            Mode = eMode.AddNew;
        }

        public clsLapTests(int TestID,int PatientRecordID,int PatientID,int TestTypeID,bool IsPaid,DateTime DateOfTest,string FilePath,bool IsDone)
        {
            this.TestID = TestID;
            this.PatientRecordID = PatientRecordID;
            this.PatientID = PatientID;
            this.TestTypeID = TestTypeID;
            this.IsPaid = IsPaid;
            this.DateOfTest = DateOfTest;
            this.FilePath = FilePath;
            this.IsDone = IsDone;

            Mode = eMode.Update;
        }

        public static clsLapTests FindTestRecordByID(int TestId)
        {
            int PatientRecordID = -1, PatientID = -1, TestTypeID = -1;
            bool IsPaid = false, IsDone = true; DateTime DateOfSet = DateTime.Now;string FilePath = "";

            if(clsLabsData.GetFullRecordByID(TestId,ref PatientRecordID,ref PatientID,ref TestTypeID,ref IsPaid,ref DateOfSet,ref FilePath,ref IsDone))
            {
                return  new clsLapTests(TestId,PatientRecordID,PatientID,TestTypeID,IsPaid,DateOfSet,FilePath,IsDone);
            }
            else
            {
                return null;
            }

        }

        private bool _AddNewLapTestRecord()
        {
            this.TestID = clsLabsData.AddNewTestLabRecord(this.PatientRecordID, this.PatientID, this.TestTypeID, this.IsPaid, this.DateOfTest);
            return TestID != -1;
        }

        private bool _UpdateLapTestRecord()
        {
            return clsLabsData.UpdateTestLabRecord(this.TestID, this.TestTypeID, this.IsPaid, this.DateOfTest, this.FilePath,this.IsDone);
        }

        public bool Save()
        {
            switch(Mode)
            {
                case eMode.AddNew:
                    if(_AddNewLapTestRecord())
                    {
                        Mode = eMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case eMode.Update:
                    if(_UpdateLapTestRecord())
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

        public static DataTable GetAllLabTestshistory()
        {
            return clsLabsData.GetAllLabTestshistory();
        }
        
        public static bool DeleteTestLabRecord(int TestId)
        {
            return clsLabsData.DeleteTestLabRecord(TestId);
        }

        public static DataTable GetAllTestsForPatient(int PatientID)
        {
            return clsLabsData.GetAllTestsForPatient(PatientID);
        }

        public static string GetTestTypeName(int TestTypeID)
        {
            return clsLabsData.GetTestTypeName(TestTypeID);
        }

        public  static int GetTestTypeIDByName(string TestTypeName)
        {
            return clsLabsData.GetTestTypeIDByName(TestTypeName);   
        }

        public static decimal GetTestCost(int TestTypeID)
        {
            return clsLabsData.GetTestCost(TestTypeID);
        }

        public static DataTable GetAllTestTypeInSys()
        {
            return clsLabsData.GetAllTestTypeInSys();
        }

        public static decimal GetTestCostByName(string TestTypeName)
        {
            return clsLabsData.GetTestCostByName(TestTypeName);
        }



    }
}
