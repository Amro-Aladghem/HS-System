using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace clsBusineesLayer
{
    public  class clsMedicals
    {
       enum eMode { AddNew=1,Update=2};
       eMode Mode;

        public int MedicalID { get; set; }
        public string MedicalTypeQR { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime ProducedDate { get; set; }
        public DateTime ExpiaredDate { get; set; }

        public DateTime DateOfArrivale { get; set; }


        public clsMedicals()
        {
            this.MedicalID        = 0;
            this.MedicalTypeQR    = string.Empty;
            this.Quantity         = 0;
            this.Price            = 0;
            this.ProducedDate     = DateTime.MinValue;
            this.ExpiaredDate     = DateTime.MinValue;

            Mode = eMode.AddNew;
        }

        public clsMedicals(int MedicalID,string MedicalTypeQR,int Quantity,decimal Price ,DateTime ProducedDate,DateTime ExpiaredDate,DateTime DateOfArraivel)
        {
            this.MedicalID = MedicalID;
            this.MedicalTypeQR = MedicalTypeQR;
            this.Quantity = Quantity;
            this.Price = Price;
            this.ProducedDate = ProducedDate;
            this.ExpiaredDate = ExpiaredDate;
            this.DateOfArrivale = DateOfArrivale;

            Mode = eMode.Update;
        }

        public static  clsMedicals FindMedicalByID(int MedicalID)
        {
            string MedicalTypeQR = ""; int Quantity=0; decimal Price= 0; DateTime ProducedDate=DateTime.MinValue, ExpiaredDate=DateTime.MinValue,DateOfArraivel=DateTime.MinValue;

            if(clsMedicalsData.GetFullRecordOfMedicalByID(MedicalID,ref MedicalTypeQR,ref Quantity,ref Price,ref ProducedDate,ref ExpiaredDate,ref DateOfArraivel))
            {
                return new clsMedicals(MedicalID, MedicalTypeQR, Quantity, Price, ProducedDate, ExpiaredDate,DateOfArraivel);
            }
            else
            {
                return null;
            }
        }

        public static clsMedicals FindMedicalByQRAndProducedDate(string QR,DateTime ProducedDate)
        {
            int Quantity = 0; decimal Price = 0; DateTime ExpiaredDate = DateTime.MinValue, DateOfArraivle = DateTime.MinValue; int MedicalID = 0; 

            if(clsMedicalsData.GetFullRecordOfMedicalByQRAndProducedDate(ref MedicalID,ProducedDate,QR,ref Quantity,ref Price,ref ExpiaredDate,ref DateOfArraivle))
            {
                return new clsMedicals(MedicalID,QR,Quantity,Price,ProducedDate,ExpiaredDate,DateOfArraivle);
            }
            else
            {
                return null; 
            }

        }

        public static clsMedicals FindMedicalByQR(string QR)
        {
            int Quantity = 0; decimal Price = 0; DateTime ExpiaredDate = DateTime.MinValue, DateOfArraivle = DateTime.MinValue,ProducedDate=DateTime.MinValue; int MedicalID = 0;

            if (clsMedicalsData.GetFullRecordOfMedicalByQR(ref MedicalID, QR, ref Quantity, ref Price,ref ProducedDate ,ref ExpiaredDate, ref DateOfArraivle))
            {
                return new clsMedicals(MedicalID, QR, Quantity, Price, ProducedDate, ExpiaredDate, DateOfArraivle);
            }
            else
            {
                return null;
            }
        }

        private bool _AddNewMedicalInStorage()
        {
            this.MedicalID = clsMedicalsData.AddNewMedicalRecordInStorage(this.MedicalTypeQR, this.Quantity, this.Price, this.ProducedDate, this.ExpiaredDate);
            return MedicalID != -1;
        }

        private bool _UpdateMedicalInStorage()
        {
            return clsMedicalsData.UpdateMedicalRecord(this.MedicalID, this.Quantity, this.Price, this.ProducedDate, this.ExpiaredDate);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case eMode.AddNew:
                    if (_AddNewMedicalInStorage())
                    {
                        Mode = eMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case eMode.Update:
                    if(_UpdateMedicalInStorage())
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

        public static bool AddNewMedicalTypeInSys(string MedicalTypeQR,string MedicalName)
        {
            return clsMedicalsData.AddNewMedicalTypeInSys(MedicalTypeQR, MedicalName);
        }

        public static bool UpdateMedicalTypeInSys(string OldMedicalTypeQR,string NewMedicalTypeQR)
        {
            return clsMedicalsData.UpdateMedicalTypeRecord(OldMedicalTypeQR, NewMedicalTypeQR);
        }

        public static DataTable GetAllMedicalsTypesInSys()
        {
            return clsMedicalsData.GetAllMedicalTypeInSys();
        }

        public static DataTable GetAllMedicalsInStorage()
        {
            return clsMedicalsData.GetAllMedicalsInStorage();
        }

        public static bool DeleteMedicalTypeFromSys(string QRForMedicalType)
        {
            return clsMedicalsData.DeleteMedicalTypeFromSys(QRForMedicalType);
        }

        public static bool ChangeThePriceOfMedical(int MedicalID,decimal NewPrice)
        {
            return clsMedicalsData.ChangeThePriceOfMedical(MedicalID,NewPrice);
        }

        public static bool DecreaseMedicalQuantity(int MedicalID,int DecreaseQuantity)
        {
            return clsMedicalsData.DecreaseMedicalQuantity(MedicalID, DecreaseQuantity);
        }

        public static DataTable GetAllRecordsForSpecificMedicalInStorage(string QRFromMedicalType)
        {
            return clsMedicalsData.GetAllStorageQuantityOfMedical(QRFromMedicalType);
        }

        public static string GetMedicalNameByQR(string MedicalQR)
        {
            return clsMedicalsData.GetMedicalNameByQR(MedicalQR);
        }

        public static bool IsMedicalTypeExitsInSys(string MedicalQR)
        {
            return clsMedicalsData.IsMedicalTypeExitsInSys(MedicalQR) ; 
        }

        public static bool IsMedicalHasMoreThanOneRecordWithDiffDate(string MedicalQR)
        {
            return clsMedicalsData.IsMedicalHasMorethanRecordWithDiffDate(MedicalQR);
        }

        public static bool DeleteMedicalRecordFromStorage(int MedicalID)
        {
            return clsMedicalsData.DeleteMedicalRecordFromStorage(MedicalID);
        }





    }
}
