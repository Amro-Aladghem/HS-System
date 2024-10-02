using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace DataAccessLayer
{
    public  class clsMedicalsData
    {
        private static void AddValueToParameterCommand(SqlCommand command, string ColoumnName, object value)
        {
            if (value == System.DBNull.Value)
            {
                command.Parameters.AddWithValue(ColoumnName, System.DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue(ColoumnName, value);
            }

        }

        public static DataTable GetAllMedicalTypeInSys()
        {
            DataTable dt = new DataTable();


            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using(SqlCommand command=new SqlCommand("SP_GetAllMedicalsTypesInSys", connection))
                    {

                        command.CommandType = CommandType.StoredProcedure;
                        
                        using(SqlDataReader reader=command.ExecuteReader())
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

        public static bool AddNewMedicalTypeInSys(string MedicalTypeQR,string MedicalName)
        {
            bool isDone = false;

            try
            {

                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using(SqlCommand command=new SqlCommand("SP_AddNewMedicalTypeInSys", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@MedicalTypeQR", MedicalTypeQR);
                        command.Parameters.AddWithValue("@MedicalName", MedicalName);

                        using(SqlDataReader r=command.ExecuteReader())
                        {
                            if(r.Read())
                            {
                                isDone = true;
                            }
                        }
                       
                    }
                }
            }
            catch
            {
                //..
            }

            return isDone;
        }

        public static bool UpdateMedicalTypeRecord(string OldQRForMedicalType,string NewQRForMedicalType)
        {
            bool isDone = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using(SqlCommand command = new SqlCommand("SP_UpdateQrForMedicalTypeInSys", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@OldQR", OldQRForMedicalType);
                        command.Parameters.AddWithValue("@NewQR", NewQRForMedicalType);

                        int rowaffected = command.ExecuteNonQuery();
                        if(rowaffected>0)
                        {
                            isDone = true;
                        }
                    }
                }
            }
            catch
            {
                //..
            }

            return isDone;
        }

        public static bool DeleteMedicalTypeFromSys(string QROfMedicalType)
        {
            bool isDone = false;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using(SqlCommand command=new SqlCommand("SP_DeleteMedicalTypeFromSys", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@QR", QROfMedicalType);

                        int rowaffected = command.ExecuteNonQuery();
                        if (rowaffected > 0)
                        {
                            isDone = true;
                        }
                    }
                }
            }
            catch
            {
                //..
            }

            return isDone;
        }

        public static DataTable GetAllMedicalsInStorage()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using(SqlCommand command=new SqlCommand("SP_GetAllMedicalsInStorage",connection))
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

        public static bool GetFullRecordOfMedicalByID(int MedicalID,ref string MedicalTypeQR,ref int Quantity,ref decimal Price,ref DateTime ProducedDate,ref DateTime ExpiredDate,ref DateTime DateOfArraivle)
        {
            bool isFound = false;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_GetMedicalFullRecordByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@MedicalID", MedicalID);
                        
                        using(SqlDataReader reader=command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                isFound = true;

                                MedicalTypeQR = (string)reader[1];
                                Quantity = (int)reader[2];
                                Price = (decimal)reader[3];
                                ProducedDate = (DateTime)reader[4];
                                ExpiredDate = (DateTime)reader[5];
                                DateOfArraivle = (DateTime)reader[6];
                            }
                        }

                    }
                }
            }
            catch
            {
                //..
            }

            return isFound;
        }

        public static bool GetFullRecordOfMedicalByQRAndProducedDate(ref int MedicalID,DateTime ProducedDate, string MedicalTypeQR,ref int Quantity,ref decimal Price,ref DateTime ExpiredDate,ref DateTime DateOfArraivle)
        {
            bool isFound = false;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand("SP_GetFullRecordOfMedicalByQRAndProducedDate", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@MedicalTypeQR", MedicalTypeQR);
                        command.Parameters.AddWithValue("@ProducedDate", ProducedDate);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                isFound = true;

                                MedicalID = (int)reader[0];
                                Quantity = (int)reader[2];
                                Price = (decimal)reader[3];
                                ExpiredDate = (DateTime)reader[5];
                                DateOfArraivle = (DateTime)reader[6];

                            }
                        }
                    }



                }


            }
            catch
            {
                //..
            }

            return isFound;
        }
        
        public static bool GetFullRecordOfMedicalByQR(ref int MedicalID,string MedicalTypeQr,ref int Quantity, ref decimal Price,ref DateTime ProducedDate,ref DateTime ExpiredDate,ref DateTime DateOfArraivle)
        {
            bool isFound = false;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand("SP_GetMedicalFullRecordByQR", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@QR", MedicalTypeQr);

                        using(SqlDataReader reader=command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                isFound = true;

                                MedicalID = (int)reader[0];
                                Quantity = (int)reader[2];
                                Price = (decimal)reader[3];
                                ProducedDate = (DateTime)reader[4];
                                ExpiredDate = (DateTime)reader[5];
                                DateOfArraivle = (DateTime)reader[6];
                            }
                        }
                    }
                }



            }
            catch
            {
                //..
            }

            return isFound;
        }

        public static bool IsMedicalHasMorethanRecordWithDiffDate(string MedicalTypeQR)
        {
            bool isRight = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command= new SqlCommand("SP_IsMedicalHasMoreThanOneRecord", connection))
                    {
                        command.CommandType=CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@MedicalTypeQR", MedicalTypeQR);

                        object reader = command.ExecuteScalar();
                        if(reader!=null && int.TryParse(reader.ToString(),out int value))
                        {
                            if(value!=1)
                            {
                                isRight = true;
                            }
                        }
                    }
                }
            }
            catch
            {
                ///.
            }
            return isRight;
        }

        public static int AddNewMedicalRecordInStorage( string MedicalTypeQR,int Quantity,decimal Price,DateTime ProducedDate,DateTime ExpiredDate)
        {
            int NewID = -1;

            try
            {

                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command =new SqlCommand("SP_AddNewMedicalInStorage", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@MedicalTypeQR", MedicalTypeQR);
                        command.Parameters.AddWithValue("@Quantity", Quantity);
                        command.Parameters.AddWithValue("@Price", Price);
                        command.Parameters.AddWithValue("@ProducedDate", ProducedDate);
                        command.Parameters.AddWithValue("@ExpiaredDate", ExpiredDate);

                        object reader = command.ExecuteScalar();
                        if (reader != null && int.TryParse(reader.ToString(),out int value))
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

        public static bool UpdateMedicalRecord(int MedicalRecordID,int Quantity,decimal Price, DateTime ProducedDate,DateTime ExpiredDate)
        {
            bool isDone = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using(SqlCommand command=new SqlCommand("SP_UpdateMedicalRecord", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@MedicalID", MedicalRecordID);
                        command.Parameters.AddWithValue("@Quantity", Quantity);
                        command.Parameters.AddWithValue("@Price", Price);
                        command.Parameters.AddWithValue("@ProducedDate", ProducedDate);
                        command.Parameters.AddWithValue("@ExpiaredDate", ExpiredDate);

                        int rowaffected = command.ExecuteNonQuery();
                        if(rowaffected> 0)
                        {
                            isDone = true;
                        }
                    }
                }
            }
            catch
            {
             //**
               
            }

            return isDone;
        }

        public static bool ChangeThePriceOfMedical(int MedicalRecordID, decimal NewPrice)
        {
            bool isDone = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_ChangeThePriceOfMedical", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@MedicalID", MedicalRecordID);
                        command.Parameters.AddWithValue("@NewPrice", NewPrice);

                        int rowaffected = command.ExecuteNonQuery();
                        if (rowaffected > 0)
                        {
                            isDone = true;
                        }
                    }
                }                
            }
            catch
            {
                //..
            }

            return isDone;
        }

        public static bool DecreaseMedicalQuantity(int MedicalRecordID, int DecreaseQuantity)
        {
            bool isDone = false;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand("SP_DecreaseMedicalQuantity", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@MedicalId", MedicalRecordID);
                        command.Parameters.AddWithValue("@DecreaseAmount", DecreaseQuantity);

                        int rowaffected = command.ExecuteNonQuery();
                        if(rowaffected > 0)
                        {
                            isDone = true;
                        }
                    }
                }
            }
            catch
            {
                //..
            }

            return isDone;
        }

        public static DataTable GetAllStorageQuantityOfMedical(string MedicalQR)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_GetAllStorageQuantityOfMedical", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@QR", MedicalQR);

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

        public static string GetMedicalNameByQR(string MedicalQR)
        {
            string Name = "";

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using(SqlCommand command=new SqlCommand("SP_GEtMedicalnameByQR", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@QR", MedicalQR);

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                Name = (string)reader[0];
                            }
                        }
                    }
                }
            }
            catch
            {
                //..
            }

            return Name;
        }

        public static bool IsMedicalTypeExitsInSys(string MedicalQR)
        {
            bool isRight = false;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand("SP_IsMedicalTypeExitsInSys", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@MedicalQR", MedicalQR);

                        SqlParameter resultPar = new SqlParameter("@Result", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.ReturnValue
                        };

                        command.Parameters.Add(resultPar);
                        command.ExecuteNonQuery();

                        if((int)resultPar.Value==1)
                        {
                            isRight = true;
                        }
                    }
                }

            }
            catch
            {
                //..
            }

            return isRight;
        }

        public static bool DeleteMedicalRecordFromStorage(int MedicalID)
        {
            bool IsDone = false;

            try
            {
                using(SqlConnection connectionn=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connectionn.Open();
                    using(SqlCommand command=new SqlCommand("SP_DeleteMedicalRecordFromStorage", connectionn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@MedicalID", MedicalID);

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

    }
}
