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
    public  class clsDoctors:clsPersons
    {
        enum eMode { AddNew=1,Update=2 }
        eMode Mode;

        public int DoctorID { get; set; }
        public int SpectialistTypeID { get; set; }
        public int SectionTypeID { get; set; }
        public int? RoomID { get; set; } 
        public bool IsAvailable { get; set; }
        public bool isActive { get;  set; }
        public decimal Salary { get; set; }
        public decimal? AppointmentCost { get; set; }
        public clsPersons Person { get; set; }

        public clsDoctors()
        {
            this.DoctorID            = -1;
            this.SpectialistTypeID   = -1;
            this.SectionTypeID       = -1;
            this.RoomID              = -1;
            this.IsAvailable         = true;
            this.isActive            = false;
            this.Salary              = 0;
            this.AppointmentCost     = 0;

            Mode = eMode.AddNew;
        }

        public clsDoctors(int DoctorID,clsPersons Person,int SpectialitstTypeID,int SectionTypeID,int? RoomID,bool IsAvailable,bool IsActive,decimal Salary,decimal? AppointmentCost)
        {
            this.DoctorID = DoctorID;
            this.SpectialistTypeID = SpectialitstTypeID;
            this.SectionTypeID = SectionTypeID;
            this.RoomID = RoomID;
            this.IsAvailable = IsAvailable;
            this.isActive = IsActive;
            this.Salary = Salary;
            this.AppointmentCost = AppointmentCost;

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

        public static clsDoctors FindDoctorByID(int DoctorID)
        {
            int SpectialistTypeID = 0, SectionTypeID = 0,PersonID=0;int? RoomID = 0;
            bool IsAvailable = false, isActive = false; decimal Salary = 0;decimal? AppointmentCost = 0;

            if (clsDoctorData.GetFullRecordByID(DoctorID,ref PersonID,ref SpectialistTypeID,ref SectionTypeID,ref RoomID,ref IsAvailable,ref isActive,ref Salary,ref AppointmentCost))
            {
                clsPersons Persons = FindPersonByID(PersonID);

                return new clsDoctors(DoctorID, Persons, SpectialistTypeID, SectionTypeID, RoomID, IsAvailable, isActive, Salary, AppointmentCost);
            }
            else
            {
                return null;
            }
        }

        public static clsDoctors FindDoctorByName(string FirstName,string LastName)
        {
            int SpectialistTypeID = 0, SectionTypeID = 0, PersonID = 0,DoctorID=0; int? RoomID = 0;
            bool IsAvailable = false, isActive = false; decimal Salary = 0; decimal? AppointmentCost = 0;
            

            if (clsDoctorData.GetFullRecordByName(FirstName,LastName,ref DoctorID, ref PersonID, ref SpectialistTypeID, ref SectionTypeID, ref RoomID, ref IsAvailable, ref isActive, ref Salary, ref AppointmentCost))
            {
                clsPersons Persons = FindPersonByID(PersonID);

                return new clsDoctors(DoctorID, Persons, SpectialistTypeID, SectionTypeID, RoomID, IsAvailable, isActive, Salary, AppointmentCost);
            }
            else
            {
                return null;
            }
        }

        private bool _AddNewDoctor()
        {
            this.DoctorID = clsDoctorData.AddNewRecordToTheSys(base.PersonID, this.SpectialistTypeID, this.SectionTypeID, this.RoomID, this.IsAvailable, this.isActive, this.Salary, this.AppointmentCost);
            return this.DoctorID != -1;
        }

        private bool _UpdateDoctorRecord()
        {
            return clsDoctorData.UpdateRecord(this.DoctorID, this.SpectialistTypeID, this.SectionTypeID, this.Salary, this.RoomID, this.AppointmentCost, this.isActive);
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
                        if(_AddNewDoctor())
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
                        if(_UpdateDoctorRecord())
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

        public static DataTable GetAllDoctorInSys()
        {
            return clsDoctorData.GetAllRecordsInSys();
        }

        public static bool DeleteDoctor(int DoctorID)
        {
            return clsDoctorData.DeleteRecord(DoctorID);
        }

        public  bool DeleteDoctor()
        {
            return clsDoctorData.DeleteRecord(this.DoctorID);
        }

        public static bool ChangTheStatusOfDoctor(int DoctorID,bool isActive)
        {
            return clsDoctorData.ChangeActiveStatus(DoctorID,isActive); 
        }

        public bool ChangTheStatusOfDoctor( bool isActive)
        {
            return clsDoctorData.ChangeActiveStatus(this.DoctorID, isActive);
        }

        public static decimal GetAppointmentCostForADoctor(int DoctorID)
        {
            return clsDoctorData.GetAppointmentCostForADoctor(DoctorID);
        }

        public static DataTable GetAllAvailableDoctorInSys()
        {
            return clsDoctorData.GetAllAvailableDoctorForPatients();
        }















    }
}
