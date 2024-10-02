using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsBusineesLayer
{
    public class clsPatientRecords
    {
        enum eMode { AddNew = 1, Update = 2 }
        eMode Mode;

        public int RecordID { get; set; }
        public int PatientID { get; set; }
        public DateTime DateOfArraivel { get; set; }
        public string Symptoms { get; set; }
        public int? DoctorAssignedID { get; set; }
        public bool IsLeaved { get; set; }
        public string Dignosis { get; set; }
        public DateTime? DateTimeOfLeaved { get; set; }
        public int? RoomID { get; set; }


        public clsPatientRecords()
        {
            this.RecordID = -1;
            this.PatientID = -1;
            this.DateOfArraivel = DateTime.Now;
            this.Symptoms = string.Empty;
            this.DoctorAssignedID = null;
            this.IsLeaved = false;
            this.Dignosis = string.Empty;
            this.DateTimeOfLeaved = null;
            this.RoomID = null;

            Mode = eMode.AddNew;
        }

        public clsPatientRecords(int RecordID, int PatientId, DateTime DateOfArraivel, string Symptoms, int? DoctorID, bool IsLeaved, string Dignosis, DateTime? DateOfLeaved, int? RoomID)
        {
            this.RecordID = RecordID;
            this.PatientID = PatientId;
            this.DateOfArraivel = DateOfArraivel;
            this.Symptoms = Symptoms;
            this.DoctorAssignedID = DoctorID;
            this.IsLeaved = IsLeaved;
            this.Dignosis = Dignosis;
            this.DateTimeOfLeaved = DateOfLeaved;
            this.RoomID = RoomID;

            Mode = eMode.Update;
        }

        public static clsPatientRecords FindRecordByID(int RecordID)
        {
            DateTime DateOfArraivel = DateTime.MinValue;int PatientID = 0;
            string Symptoms = "", Dignosis = ""; int? DoctorID = null, RoomID = null;
            DateTime? DateOfLeaved = null; bool IsLeaved = false;

            if (clsPateintRecordData.GetFullRecordByID( RecordID, ref DateOfArraivel,ref  PatientID, ref Symptoms, ref DoctorID, ref IsLeaved, ref Dignosis, ref DateOfLeaved, ref RoomID))
            {
                return new clsPatientRecords(RecordID, PatientID, DateOfArraivel, Symptoms, DoctorID, IsLeaved, Dignosis, DateOfLeaved, RoomID);
            }
            else
            {
                return null;
            }
        }
        public  static clsPatientRecords FindTheMostUpdateRecordForPatient(int PatientID)
        {
            int RecordID = 0; DateTime DateOfArraivel = DateTime.MinValue;
            string Symptoms = "", Dignosis = ""; int? DoctorID = null, RoomID = null;
            DateTime? DateOfLeaved = null; bool IsLeaved = false;

            if (clsPateintRecordData.GetTheMostUpdatePatientFullRecord(ref RecordID, ref DateOfArraivel, PatientID, ref Symptoms, ref DoctorID, ref IsLeaved, ref Dignosis, ref DateOfLeaved, ref RoomID))
            {
                return new clsPatientRecords(RecordID, PatientID, DateOfArraivel, Symptoms, DoctorID, IsLeaved, Dignosis, DateOfLeaved, RoomID);
            }
            else
            {
                return null;
            }
        }

        public static DataTable GetAllPatientsRecordsInSys()
        {
            return clsPateintRecordData.GetAllRecordsInSys();
        }

        public static DataTable GetAllRecordsForSpecificPatient(string NationalNum)
        {
            return clsPateintRecordData.GetAllRecordsForSpecificPatientByNationalNum(NationalNum);
        }

        public static DataTable GetAllRecordsForSpecificPatientByID(int PatientID)
        {
            return clsPateintRecordData.GetAllRecordsForSpecificPatientByID(PatientID);
        }

        public static bool DischargePatient(int RecordID)
        {
            return clsPateintRecordData.DischargePatient(RecordID);
        }

        public static bool DeletePatientRecord(int RecordID)
        {
            return clsPateintRecordData.DeletePatientRecord(RecordID);
        }

        private bool _AddnewPatientRecord()
        {
            this.RecordID = clsPateintRecordData.AddNewPatientRecordHS(this.PatientID, this.DateOfArraivel, this.Symptoms, this.DoctorAssignedID, this.IsLeaved, this.Dignosis, this.RoomID);
            return RecordID != -1;
        }

        private bool _UpdatePatientRecord()
        {
            return clsPateintRecordData.UpdatePatientRecordHS(this.RecordID, this.Symptoms, this.DoctorAssignedID, this.IsLeaved, this.Dignosis, this.RoomID);
        }
        
        public bool Save()
        {
            switch(Mode)
            {
                case eMode.AddNew:
                    if(_AddnewPatientRecord())
                    {
                        Mode = eMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case eMode.Update:
                    if(_UpdatePatientRecord())
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

        public static bool IsPatientHasAnActiveRecord(int PatientID)
        {
            return clsPateintRecordData.IsPatientHasAnActiveRecord(PatientID);
        }










    }
}
