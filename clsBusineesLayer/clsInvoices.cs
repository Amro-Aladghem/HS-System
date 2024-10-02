using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace clsBusineesLayer
{
    public class clsInvoices
    {

        public int InvoiceID { get; set; }
        public int PatientRecordID { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime Date { get; set; }
        public bool IsPaid { get; set; }


        public clsInvoices()
        {
            this.InvoiceID       = -1;
            this.PatientRecordID = -1;
            this.TotalAmount     = 0;
            this.Date            = DateTime.MinValue;
            this.IsPaid          = false;

        }

        public clsInvoices(int InvoiceId,int PatientRecordID, decimal TotalAmount, DateTime Date, bool IsPaid)
        {
            this.InvoiceID = InvoiceID;
            this.PatientRecordID = PatientRecordID;
            this.TotalAmount = TotalAmount;
            this.Date = Date;
            this.IsPaid = IsPaid;
        }

        public static clsInvoices FindInvoiceByID(int InvoiceID)
        {
            int PatientRecordID = -1;decimal TotalAmount = 0;DateTime Date=DateTime.MinValue;bool IsPaid = false;

            if (clsInvoicesData.GetInvoiceFullRecord(InvoiceID, ref PatientRecordID, ref TotalAmount,ref  Date,ref  IsPaid))
            {
                return new clsInvoices(InvoiceID,PatientRecordID,TotalAmount,Date,IsPaid);
            }
            else
            {
                return null;
            }
        }

        private bool _AddNewInvoice()
        {
            this.InvoiceID = clsInvoicesData.AddNewInvoice(this.PatientRecordID, this.TotalAmount, this.Date, this.IsPaid);
            return InvoiceID != -1;
        }

        public bool Save()
        {
            if(_AddNewInvoice())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static DataTable GetAllInvoiceRecordInSys()
        {
            return clsInvoicesData.GetAllInvoicesInSys();
        }

        public static DataTable GetAllInvoiceRecordsForPatientRecord(int PatientRecordID)
        {
            return clsInvoicesData.GetAllInovicesForPatientRecord(PatientRecordID);
        }

        public static bool UpdateTotalAmount(int InvoiceID,decimal NewTotalAmount)
        {
            return clsInvoicesData.UpdateTotoalAmount(InvoiceID, NewTotalAmount);
        }

        public static bool DeleteInvoiceRecord(int InvoiceID)
        {
            return clsInvoicesData.DeleteInvoiceRecord(InvoiceID);
        }

        public static bool MakeInvoicePaid(int InvoiceID)
        {
            return clsInvoicesData.MakeInvoicePaid(InvoiceID);
        }







    }
}
