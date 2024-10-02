using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsInvoicesData
    {

        public static DataTable GetAllInvoicesInSys()
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using(SqlCommand command=new SqlCommand("SP_GetAllInvoices", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                       
                        using(SqlDataReader reader=command.ExecuteReader())
                        {
                            if(reader.HasRows)
                            {
                                dt.Load(reader);
                            }
                        }
                    }
                }
            }
            catch
            {
                //..
            }

            return dt;
        }

        public static DataTable GetAllInovicesForPatientRecord(int PatientRecordID)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetAllInvoicesRecordForPatientRecord", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PatientRecordID", PatientRecordID);

                        using(SqlDataReader reader=command.ExecuteReader())
                        {
                            if(reader.HasRows)
                            {
                                dt.Load(reader);
                            }
                        }
                    }
                }
            }
            catch
            {
                //..
            }

            return dt;
        }

        public static bool GetInvoiceFullRecord(int InvoiceRecordID,ref int PatientRecordId,ref decimal TotalAmoun,ref DateTime Date,ref bool IsPaid)
        {
            bool IsFound = false;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand("SP_GetInvoiceFullRecord", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@InvoiceID", InvoiceRecordID);

                        using(SqlDataReader reader=command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                IsFound = true;

                                PatientRecordId = (int)reader[1];
                                TotalAmoun= (decimal)reader[2];
                                Date = (DateTime)reader[3];
                                IsPaid = Convert.ToBoolean(reader[4]);
                            }
                        }
                    }
                }


            }
            catch
            {
                //..
            }

            return IsFound;
        }

        public static int AddNewInvoice(int PatientRecordID,decimal TotalAmount,DateTime Date,bool IsPaid)
        {
            int NewID = -1;

            try
            {

                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();  
                    using(SqlCommand command=new SqlCommand("SP_AddNewInvoice", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PatientRecordID", PatientRecordID);
                        command.Parameters.AddWithValue("@TotalAmount", TotalAmount);
                        command.Parameters.AddWithValue("@Date", Date);
                        command.Parameters.AddWithValue("@IsPaid", IsPaid);

                        object reader=command.ExecuteScalar();
                        if(reader!=null && int.TryParse(reader.ToString(),out int value))
                        {
                            NewID = value;
                        }
                    }
                }
            }
            catch
            {
                //..
            }

            return NewID;
        }

        public static bool UpdateTotoalAmount(int InvoiceID, decimal NewTotalAmoun)
        {
            bool IsDone = false;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("UpdateTotalAmount", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@InvoiceID", InvoiceID);
                        command.Parameters.AddWithValue("@NewTotalAmount", NewTotalAmoun);

                        int rowaffectes = command.ExecuteNonQuery();
                        if(rowaffectes>0)
                        {
                            IsDone = true;
                        }
                    }
                }
            }
            catch
            {
                //..
            }

            return IsDone;
        }

        public static bool DeleteInvoiceRecord(int InvoiceID)
        {
            bool IsDone = false;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand("SP_DeleteInvoiceRecord", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@InvoiceID", InvoiceID);

                        int rowaffectes = command.ExecuteNonQuery();
                        if (rowaffectes > 0)
                        {
                            IsDone = true;
                        }

                    }
                }
               

            }
            catch
            {
                //..
            }

            return IsDone;
        }


        public static bool MakeInvoicePaid(int InvoiceID)
        {
            bool IsDone = false;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand("SP_MakeInovicePaid", connection))
                    {
                        command.CommandType=CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@InvoiceID", InvoiceID);

                        int rowaffected=command.ExecuteNonQuery();
                        if(rowaffected> 0)
                        {
                            IsDone = true;
                        }
                    }
                }
            }
            catch
            {
                //..
            }

            return IsDone;
        }











    }


}
