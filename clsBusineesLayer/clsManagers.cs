using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsBusineesLayer
{
    public class clsManagers
    {

       public int ManagerID { get; set; }
       public int UserID { get; set; }
       public int SectionID { get; set; }

        public clsManagers()
        {
            this.ManagerID = -1;
            this.SectionID = -1;
            this.UserID = -1;
        }

        public static DataTable GetAllManagers()
        {
            return clsManagerData.GetAllManagers();
        }

        private bool _AddNewMangaer()
        {
            this.ManagerID = clsManagerData.AddNewManager(this.UserID, this.SectionID);
            return ManagerID != -1;
        }

        public bool Save()
        {
            if(_AddNewMangaer())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool DeleteManager(int managerID)
        {
            return clsManagerData.DeleteManager(managerID);
        }

        public static bool UpdateManager(int ManagerID,int NewSectionID)
        {
            return clsManagerData.UpdateSectionForManager(ManagerID, NewSectionID);
        }

        public static bool IsManagerExsits(int MangaerID)
        {
            return clsManagerData.IsManagerExsits(MangaerID);
        }












    }
}
