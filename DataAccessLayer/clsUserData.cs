using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsUserData
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

        public static DataTable GetAllUsersInSys()
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using(SqlCommand command=new SqlCommand("SP_GetAllUsersInSys",connection))
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
                //...
            }

            return dt;
        }

        public static bool GetRecordByID(int UserID,ref string UserName,ref string Password,ref int?DoctorID,ref int?NurseID,ref int?EmployeeID,ref bool IsActive ,ref int Permisions)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetUserRecordByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@UserID", UserID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                UserName = (string)reader[1];
                                Password = (string)reader[2];
                                DoctorID = reader[3] == System.DBNull.Value? null:  (int?)reader[3];
                                NurseID = reader[4] == System.DBNull.Value ? null : (int?)reader[4];
                                EmployeeID = reader[5] == System.DBNull.Value ? null:(int?)reader[5];
                                IsActive =(bool)reader[6];
                                Permisions = (int)reader[7];
                            }
                        }

                    }
                }
            }
            catch
            {
                //...
            }

            return isFound;
        }

        public static bool GetRecordByName(ref int UserID,  string UserName, ref string Password, ref int? DoctorID, ref int? NurseID, ref int? EmployeeID, ref bool IsActive, ref int Permisions)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetUserRecordByName", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@UserName", UserName);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                UserID = (int)reader[0];
                                Password = (string)reader[2];
                                DoctorID = reader[3] == System.DBNull.Value ? null : (int?)reader[3];
                                NurseID = reader[4] == System.DBNull.Value ? null : (int?)reader[4];
                                EmployeeID = reader[5] == System.DBNull.Value ? null : (int?)reader[5];
                                IsActive = (bool)reader[6];

                                Permisions = (int)reader[7];
                            }
                        }

                    }
                }
            }
            catch
            {
                //...
            }

            return isFound;
        }


        public static int AddNewRecord( string UserName,  string Password,  int? DoctorID,  int? NurseID,  int? EmployeeID, bool IsActive, int Permisions)
        {
            int NewID = -1;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using(SqlCommand command=new SqlCommand("SP_AddNewUserRecord",connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@UserName", UserName);
                        command.Parameters.AddWithValue("@Password", Password);
                        AddValueToParameterCommand(command, "@DoctoreID", DoctorID);
                        AddValueToParameterCommand(command, "@NurseID", NurseID);
                        AddValueToParameterCommand(command, "@EmployeeID", EmployeeID);

                        command.Parameters.AddWithValue("@IsActive", IsActive);
                        command.Parameters.AddWithValue("@Permistions", Permisions);

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
                //...
            }

            return NewID;
        }

        public static bool UpdateRecord(int UserID,string UserName,bool IsActive,int Permisions)
        {
            bool isDone = false;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using(SqlCommand command =new SqlCommand("SP_UpdateUserRecord",connection))
                    {
                        command.CommandType= CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@UserID", UserID);
                        command.Parameters.AddWithValue("@UserName", UserName);
                        command.Parameters.AddWithValue("@IsActive", IsActive);
                        command.Parameters.AddWithValue("@Permistions", Permisions);

                        int rowaffected=command.ExecuteNonQuery();
                        if(rowaffected>0)
                        {
                            isDone = true;
                        }
                    }
                }
            }
            catch
            {
                //...
            }

            return isDone;
        }

        public static bool ChangePassword(int UserID, string NewPassword)
        {
            bool isDone = false;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command =new SqlCommand("SP_ChangeUserPassword",connection))
                    {
                        command.CommandType=CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@UserID", UserID);
                        command.Parameters.AddWithValue("@Password", NewPassword);

                        int rowaffected=command.ExecuteNonQuery();
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

        public static bool DeleteRecord(int UserID)
        {
            bool isDone = false;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand("SP_DeleteUserRecord", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@UserID", UserID);

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
                ///..
            }

            return isDone;
        }

        public static bool IsUserAlreadyExists(int PersonID)
        {
            bool isExsits = false;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using(SqlCommand command =new SqlCommand("SP_CheckIFPersonAlreadyIsAUser",connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PersonID", PersonID);

                        object reader= command.ExecuteScalar();
                        if(reader!=null&&int.TryParse(reader.ToString(),out int value))
                        {
                            isExsits = true;
                        }
                    }
                }
            }
            catch
            {
                //..
            }

            return isExsits;
        }

















    }
}
