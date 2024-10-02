using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace clsBusineesLayer
{
    public class clsAppointments
    {
        enum eMode { AddNew=1,Update=2};
        eMode Mode;

        public int AppointmentID { get; set; }
        public string PersonFirstName { get; set; }
        public string PersonLastName { get; set; }  
        public string PhoneNum { get; set; }
        public string Address { get; set; }
        public int DocotrID { get; set; }
        public bool IsAcitve { get; set; }
        public DateTime DateOfAppointment { get; set;}
        public TimeSpan Time { get; set; }
        public int ? PatientID { get; set; }


        public clsAppointments()
        {
            this.AppointmentID         = 0;
            this.PersonFirstName       = string.Empty;
            this.PersonLastName        = string.Empty;
            this.PhoneNum              = string.Empty;
            this.Address               = string.Empty;
            this.DocotrID              = 0;
            this.IsAcitve              = false;
            this.DateOfAppointment     = DateTime.Now;
            this.Time                  = new TimeSpan(12, 12, 0);
            this.PatientID             = null;

            Mode = eMode.AddNew;
        }

        public clsAppointments(int AppointmentID,string FirstName,string LastName,string PhoneNum,string Address,int DocotrID,
            bool IsActive,DateTime DateOfAppointment,TimeSpan Time)
        {
            this.AppointmentID = AppointmentID;
            this.PersonFirstName = FirstName;
            this.PersonLastName = LastName;
            this.PhoneNum = PhoneNum;
            this.Address = Address;
            this.DocotrID = DocotrID;
            this.IsAcitve = IsActive;
            this.DateOfAppointment = DateOfAppointment;
            this.Time = Time;

            Mode = eMode.Update;
        }

        public static clsAppointments FindAppointmentByID(int AppointmentID)
        {
            string FirstName = "", LastName = "", PhoneNum = "", Address = "";
            int DocotrID = 0; bool IsActive = false; DateTime DateOfAppointment = DateTime.MinValue; TimeSpan time = TimeSpan.Zero;

            if(clsAppointmentData.GetFullRecordForAppointmentByID(AppointmentID,ref FirstName,ref LastName,ref PhoneNum,ref Address,ref DocotrID,ref IsActive,ref DateOfAppointment,ref time))
            {
                return new clsAppointments(AppointmentID,FirstName,LastName,PhoneNum,Address,DocotrID,IsActive,DateOfAppointment,time);
            }
            else
            {
                return null;
            }
        }

        public static clsAppointments FindAppointmentByPersonName(string FirstName,string LastName)
        {
            string  PhoneNum = "", Address = "";
            int DocotrID = 0,AppointmentID=0; bool IsActive = false; DateTime DateOfAppointment = DateTime.MinValue; TimeSpan time = TimeSpan.Zero;

            if (clsAppointmentData.GetFullRecordForAppointmentByName(ref AppointmentID,  FirstName, LastName, ref PhoneNum, ref Address, ref DocotrID, ref IsActive, ref DateOfAppointment, ref time))
            {
                return new clsAppointments(AppointmentID, FirstName, LastName, PhoneNum, Address, DocotrID, IsActive, DateOfAppointment, time);
            }
            else
            {
                return null;
            }
        }

        private bool _AddNewAppointemnt()
        {
            this.AppointmentID = clsAppointmentData.AddNewAppointment(this.PersonFirstName, this.PersonLastName, this.PhoneNum, this.Address, this.DocotrID, this.IsAcitve, this.DateOfAppointment, this.Time,this.PatientID);
            return AppointmentID != -1;
        }

        private bool _UpdateAppointment()
        {
            return clsAppointmentData.UpdateAppointentRecord(this.AppointmentID, this.PhoneNum, this.Address, this.DocotrID, this.IsAcitve, this.DateOfAppointment, this.Time);
        }

        public bool Save()
        {
            switch(Mode)
            {
                case eMode.AddNew:
                    if(_AddNewAppointemnt())
                    {
                        Mode = eMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case eMode.Update:
                    if (_UpdateAppointment())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                default:return false;
            }
        }

        public static DataTable GetAllAppointmentsInSys()
        {
            return clsAppointmentData.GetAllAppointmetnsInSys();
        }

        public static bool DeleteAppointmentRecord(int AppointmentRecordID)
        {
            return clsAppointmentData.DeleteAppointmentRecord(AppointmentRecordID);
        }

        public static bool IsDoctorAvaialableForAppointment(int DoctorID,TimeSpan Time,DateTime DateOfAppointment)
        {
            return clsAppointmentData.IsDoctorAvaialableForAppointment(DoctorID,Time,DateOfAppointment);
        }

        public static DataTable GetAllActiveAppointmentForDoctor(int DoctorID)
        {
            return clsAppointmentData.GetAllActiveAppointmentForDoctor(DoctorID);
        }

        public static decimal GetAppointmentCostForADoctor(int DoctorID)
        {
            return clsAppointmentData.GetAppointmentCostForADoctor(DoctorID);
        }

        public static DataTable GetAllDoctorsWhoseHaveARoom()
        {
            return clsAppointmentData.GetAllDoctorsWhoseHaveARoom();
        }

        public static bool AddNewPrescription(int AppointmentID,string Discribtion)
        {
            return clsAppointmentData.AddNewPrescription(AppointmentID,Discribtion); 
        }

        public static DataTable GetAllPrescriptionsInSys()
        {
            return clsAppointmentData.GetAllPrescriptionsInSys();
        }

        public static bool AddPatientIDToAppointmentRecord(int AppointmentID,int PatientID)
        {
            return clsAppointmentData.AddPatientIDToAppointmentRecord(AppointmentID, PatientID);
        }



    }
}
