using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsBusineesLayer
{
    public class clsHSInformation
    {
        public static DataTable GetAllSpecialistTypeInSys()
        {
            return clsHSInfomationData.GetAllSpecialestTypes();
        }
        public static DataTable GetAllSectionsInSys()
        {
            return clsHSInfomationData.GetAllSectionsInSys();
        }

        public static DataTable GetAllJopRoleInSys()
        {
            return clsHSInfomationData.GetAllJobRoleTypes();
        }

        public static int GetSectionTypeIDByName(string SectionName)
        {
            return clsHSInfomationData.GetSectionIDByName(SectionName);
        }

        public static int GetJobRoleIDByName(string JobRoleName)
        {
            return clsHSInfomationData.GetJobRoleIDByName(JobRoleName);
        }

        public static int GetSpecialistTypeIDByName(string SpecialistName)
        {
            return clsHSInfomationData.GetSpecialestTypeIDByName(SpecialistName);
        }

        public static string GetSpecialistNameByID(int SpecialistID)
        {
            return clsHSInfomationData.GetSpecialestNameByID(SpecialistID);
        }

        public static string GetSectionNameByID(int SectionID)
        {
            return clsHSInfomationData.GetSectionNameByID(SectionID);
        }

        public static string GetJobRoleNameByID(int JobRoleID)
        {
            return clsHSInfomationData.GetJobRoleNameByID(JobRoleID) ;
        }

        public static DataTable GetAllAvailableRoomForDoctor()
        {
            return clsHSInfomationData.GetAllAvailableRoomForDoctor();
        }

        public static int GetRoomNumberByID(int RoomID)
        {
            return clsHSInfomationData.GetRoomNumberByID(RoomID);
        }

        public static int GetRoomIDByRoomNumber(int RoomNumber)
        {
            return clsHSInfomationData.GetRoomIDByNumberOfIt(RoomNumber);
        }

        public static string GetBloodeTypeNameByID(int BloodeTypeID)
        {
            return clsHSInfomationData.GetBloodeTypeNameByID(BloodeTypeID);
        }

        public static DataTable GetAllAvailableRoomForPatients()
        {
            return clsHSInfomationData.GetAllAvailableRoomForPatients();
        }

        public static DataTable GetAllRoomsInSys()
        {
            return clsHSInfomationData.GetAllRoomsInSys();
        }

        public static DataTable GetWareHouseRooms()
        {
            return clsHSInfomationData.GetWareHouseRooms();
        }
    }
}
