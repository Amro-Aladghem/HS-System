using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsBusineesLayer
{
    public class clsSurgery
    {
        enum eMode { AddNew=1,Update =2}
        eMode Mode;

        public int SurgerProcedureID { get; set; }
        public DateTime DateOfProcedure { get; set; }
        public TimeSpan Time { get; set; }
        public int FirstDoctorID { get; set; }
        public int? SecondDoctorID { get; set; }
        public int? ThirdDoctorID { get; set; }
        public int FirstNurseID { get; set; }   
        public int ? SecondNurseID { get; set; }
        public int PatientID { get; set; }
        public int SurgeryProcedureTypeID { get; set; }
        public bool IsFinish { get; set; }
        public int RoomID { get; set; }

        public clsSurgery ()
        {
            this.SurgerProcedureID           = -1;
            this.DateOfProcedure             = DateTime.MinValue;
            this.Time                        = TimeSpan.Zero;
            this.FirstDoctorID               = -1;
            this.SecondDoctorID              = null;
            this.ThirdDoctorID               = null;
            this.FirstNurseID                = -1;
            this.SecondDoctorID              = null;
            this.PatientID                   = -1;
            this.SurgeryProcedureTypeID      = -1;
            this.IsFinish                    = false;
            this.RoomID                      = -1;

            Mode = eMode.AddNew;
        }

        public clsSurgery(int SurgerProcedureID,DateTime DateOfProcedure,TimeSpan Time,int FirstDoctorID,int?SecondDoctorID,int?ThirdDoctorID,
            int FirstNurseID,int? SecondNurseID,int PatientID,int SurgeryProcedureTypeID,bool IsFinish,int RoomID)
        {
            this.SurgerProcedureID = SurgerProcedureID;
            this.DateOfProcedure = DateOfProcedure;
            this.Time = Time;
            this.FirstDoctorID = FirstDoctorID;
            this.SecondDoctorID = SecondDoctorID;
            this.ThirdDoctorID = ThirdDoctorID;
            this.FirstNurseID = FirstNurseID;
            this.SecondNurseID = SecondNurseID;
            this.PatientID = PatientID;
            this.SurgeryProcedureTypeID = SurgeryProcedureTypeID;
            this.IsFinish = IsFinish;
            this.RoomID = RoomID;

            Mode = eMode.Update;
        }

        public static clsSurgery FindSurgeryProcedureByID(int SurgerProcedureID)
        {
            DateTime DateOfProcedure = DateTime.MinValue; TimeSpan Time = TimeSpan.Zero; int FirstDotorID = -1, FirstNurseID = -1;
            int? SecondDoctorID = null, ThirdDoctorID = null, SecondNurseID = null;
            int PatientID = -1, SurgeryProcedureTypeID = -1, RoomID = -1; bool IsFinish = false;    


            if(clsSurgeryData.GetSurgeryProceduerFullRecord(SurgerProcedureID,ref DateOfProcedure,ref Time,ref FirstDotorID,ref SecondDoctorID,ref ThirdDoctorID,
                                                          ref FirstNurseID, ref SecondNurseID,ref PatientID,ref SurgeryProcedureTypeID,ref IsFinish,ref RoomID))
            {
                return  new clsSurgery(SurgerProcedureID, DateOfProcedure, Time, FirstDotorID, SecondDoctorID, ThirdDoctorID,
                                                           FirstNurseID, SecondNurseID, PatientID, SurgeryProcedureTypeID, IsFinish, RoomID);
            }
            else
            {
                return null;
            }
        }

        private bool _AddNewSurgeryProcedure()
        {
            this.SurgerProcedureID=clsSurgeryData.AddNewSugeryProcedureToSys(this.DateOfProcedure,this.Time,this.FirstDoctorID,this.SecondDoctorID,this.ThirdDoctorID
                ,this.FirstNurseID,this.SecondNurseID,this.PatientID,this.SurgeryProcedureTypeID,this.IsFinish,this.RoomID);

            return SurgerProcedureID != -1; 
        }

        private bool _UpdateSurgerProcedure()
        {
            return clsSurgeryData.UpdateSugeryProcedureRecord(this.SurgerProcedureID, this.DateOfProcedure, this.Time, this.FirstDoctorID, this.SecondDoctorID, this.ThirdDoctorID
                , this.FirstNurseID, this.SecondNurseID, this.PatientID, this.SurgeryProcedureTypeID, this.IsFinish, this.RoomID);
        }

        public bool _Save()
        {
            switch(Mode)
            {

                case eMode.AddNew:
                    if(_AddNewSurgeryProcedure())
                    {
                        Mode = eMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case eMode.Update:
                    if (_UpdateSurgerProcedure())
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

        public static DataTable GetAllSurgeryProcedureInSys()
        {
            return clsSurgeryData.GetAllProcedureInSys();
        }

        public static DataTable GetAllSureryProcedureForPatient(int PatientID)
        {
            return clsSurgeryData.GetAllProcedureForSpecificPatient(PatientID);
        }

        public static bool DeleteSurgeryProcedureRecord(int SurgeryProcedureRecordID)
        {
            return clsSurgeryData.DeleteSurgeryProcedureRecord(SurgeryProcedureRecordID);
        }

        public static DataTable GetAllSurgeryRoomInHS()
        {
            return clsSurgeryData.GetAllSurgeryRoomsInHS();
        }

        public static decimal GetSurgeryTypeCostByID(int SurgeryTypeID)
        {
            return clsSurgeryData.GetSurgeryProcedureCostByID(SurgeryTypeID);
        }

        public static decimal GetSurgeryTypeCostByName(string SurgeryTypeName)
        {
            return clsSurgeryData.GetSurgeryProcedureCostByName(SurgeryTypeName);
        }

        public static bool IsSurgeryProcedureCanbeAtThisTime(DateTime Date ,TimeSpan Time,int RoomID)
        {
            return clsSurgeryData.IsSurgeryProcedureCanbeAtThisTime(Date,Time ,RoomID); 
        }

        public static DataTable GetAllSurgeryDoctorsInSys()
        {
            return clsSurgeryData.GetAllSurgeryDoctorsInSys();
        }

        public static DataTable GetAllSurgerNurseInSys()
        {
            return clsSurgeryData.GetAllSurgerNurseInSys();
        }

        public static int GetSurgeryTypeIDByName(string SurgeryTypeName)
        {
            return clsSurgeryData.GetSurgerTypeIDByName(SurgeryTypeName);
        }

        public static DataTable GetAllSugeryTypesInSys()
        {
            return clsSurgeryData.GetAllSugeryTypesInSys();
        }

        public static string GetSurgeryTypeNameByID(int SurgeryTypeID)
        {
            return clsSurgeryData.GetSurgeryTypeNameByID(SurgeryTypeID);
        }

        public static bool FinishTheSurgeryProcedure(int SugeryProcedureID)
        {
            return clsSurgeryData.FinishTheSurgeryProcedure(SugeryProcedureID);
        }








    }
}
