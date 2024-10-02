using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace clsBusineesLayer
{
    public class clsPayments
    {
        public enum ePayReason { Appointment=1,LapTest=2,Invoice=3,Other=4,Surgery=1003}
         
        enum eMode { AddNew=1,Update=2}
        eMode Mode;


        public int PaymentID { get; set; }
        public int? PatientRecordID { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal ReturnAmount { get; set; }
        public DateTime DateOfPayment { get; set; }
        public string Note { get; set; }
        public int UserID { get; set; }
        public int PayReasonID { get; set; }
        public int? PatientID { get; set; }

        public clsPayments()
        {
            this.PaymentID             = -1;
            this.PatientRecordID       = null;
            this.PaidAmount            = 0;
            this.ReturnAmount          = 0;
            this.DateOfPayment         = DateTime.Now;
            this.PatientID             = null;

            Mode= eMode.AddNew;
        }

        public clsPayments(int PaymentID,int PatientRecordID,decimal PaidAmount,decimal ReturnAmount,DateTime DateOfPayment,string Note,
                         int UserID,int PayReasonID,int?PatientID)
        {
            this.PaymentID = PaymentID;
            this.PatientRecordID = PatientRecordID;
            this.PaidAmount = PaidAmount;
            this.ReturnAmount =ReturnAmount;
            this.DateOfPayment = DateOfPayment;
            this.PatientID = PatientID;
            this.Note = Note;

            Mode = eMode.Update;
        }

        public static clsPayments FindPaymentByID(int PaymentID)
        {
            int PatientRecordId = -1;decimal PaidAmount=0,ReturnAmount=0;
            DateTime DateOfPayment = DateTime.Now;int PatientID = -1, UserID = -1, PaymentReasonID = -1;
            string Note = "";

            if (clsPaymentData.FindPaymentByID(PaymentID,ref PatientRecordId,ref PaidAmount,ref ReturnAmount,ref DateOfPayment,ref Note,ref UserID,ref PaymentReasonID,ref PatientID))
            {
               return new clsPayments(PaymentID, PatientRecordId, PaidAmount, ReturnAmount, DateOfPayment, Note, UserID, PaymentReasonID, PatientID);
            }
            else
            {
                return null;
            }
               
        }



        private bool _AddNewPayment()
        {
            this.PaymentID = clsPaymentData.AddNewPayment(this.PatientRecordID, this.PaidAmount, this.ReturnAmount, this.Note, this.UserID,this.PayReasonID,this.PatientID);
            return this.PaymentID != -1;
        }

        
        public bool Save()
        {
            switch (Mode)
            {

                case eMode.AddNew:
                    if (_AddNewPayment())
                    {
                        Mode = eMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                default: return false;

            }
        }

        public static DataTable GetAllPaymentRecordsInSys()
        {
            return clsPaymentData.GetAllPaymentsRecordInSys();
        }

        public static DataTable GetAllPaymentForPatient(int PatientID)
        {
            return clsPaymentData.GetAllPaymentsForPaitentID(PatientID);
        }

        public static bool DeletePaymentRecord(int PaymentRecordID)
        {
            return clsPaymentData.DeletePaymentRecord(PaymentRecordID);
        }



    }
}
