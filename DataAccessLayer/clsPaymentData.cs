using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsPaymentData
    {
        private static void AddValueToParameterCommand(SqlCommand command, string ColoumnName, object value)
        {
            if (value == System.DBNull.Value || value == null)
            {
                command.Parameters.AddWithValue(ColoumnName, System.DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue(ColoumnName, value);
            }


        }

        public static DataTable GetAllPaymentsRecordInSys()
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand("SP_GetAllPaymentsRecords", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
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

        public static DataTable GetAllPaymentsForPaitentID(int PatientID)
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command =new SqlCommand("SP_GetAllPaymentsRecordsForPatient", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PatientID", PatientID);

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

        public static int AddNewPayment(int? PatientRecordID,decimal PaidAmount,decimal ReturnAmount,string Note,int UserID,int PaymentReasonID,int? PatientID)
        {
            int NewID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    
                    using(SqlCommand command=new SqlCommand("SP_AddNewPayment", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        AddValueToParameterCommand(command, "@PatientReocrdID", PatientRecordID);
                        command.Parameters.AddWithValue("@PaidAmount", PaidAmount);
                        command.Parameters.AddWithValue("@ReturnAmount", ReturnAmount);
                        command.Parameters.AddWithValue("@Note", Note);
                        command.Parameters.AddWithValue("@UserId", UserID);
                        command.Parameters.AddWithValue("@PayReasonID", PaymentReasonID);
                        AddValueToParameterCommand(command, "@PatientID", PatientID);
                        

                        object reader = command.ExecuteScalar();
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

        public static bool DeletePaymentRecord(int PaymentRecordID)
        {
            bool IsDone = false;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using(SqlCommand command=new SqlCommand("SP_DeletePaymentRecord", connection))
                    {
                        command.CommandType=CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PaymentRecordId", PaymentRecordID);

                        int rowaffected = command.ExecuteNonQuery();
                        if(rowaffected>0)
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

        public static bool FindPaymentByID(int PaymentID,ref int PatientRecordID,ref decimal PaidAmount,ref decimal ReturnAmount,ref DateTime Date,ref string Note,ref int UserID,ref int PaymentReasonID,ref int PatientID)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand("SP_GetPaymentFullRecord", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PaymentID", PaymentID);

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                IsFound = true;

                                PatientRecordID = (int)reader[1];
                                PaidAmount = (decimal)reader[2];
                                ReturnAmount = (decimal)reader[3];
                                Date = (DateTime)reader[4];
                                Note = (string)reader[5];
                                UserID = (int)reader[6];
                                PaymentReasonID = (int)reader[7];
                                PatientID = (int)reader[8];
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
       

    }
}
