using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsNursesData
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

        public static DataTable GetAllRecordsInSys()
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection connection =new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using(SqlCommand command =new SqlCommand("SP_GetAllNursesInSys",connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader reader = command.ExecuteReader())
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

        public static bool GetFullRecordByID(int NurseID,ref int PersonID,ref int SectionTypeID,ref bool IsAvailable,ref bool isActive,ref decimal Salary)
        {
            bool isFound = false;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using(SqlCommand command=new SqlCommand("SP_GetNurceFullReocrdByID",connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@NurseID", NurseID);

                        using(SqlDataReader reader=command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                isFound = true;

                                PersonID = (int)reader[1];
                                SectionTypeID = (int)reader[2];
                                IsAvailable = (bool)reader[3];  
                                isActive = (bool)reader[4];
                                Salary = (decimal)reader[5];    
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

        public static bool GetFullRecordByName(string FirstName,string LastName,ref int NurseID, ref int PersonID, ref int SectionTypeID, ref bool IsAvailable, ref bool isActive, ref decimal Salary)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetNuresFullRecordByName", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        command.Parameters.AddWithValue("@LastName", LastName);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                NurseID= (int)reader[0];
                                PersonID = (int)reader[1];
                                SectionTypeID = (int)reader[2];
                                IsAvailable = (bool)reader[3];
                                isActive = (bool)reader[4];
                                Salary = (decimal)reader[5];
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

        public static int AddNewRecord( int PersonID,  int SectionTypeID,  bool IsAvailable,  bool isActive,  decimal Salary)
        {
            int NewID = -1;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using(SqlCommand command=new SqlCommand("SP_AddNewNursReocord",connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@SectionTypeID", SectionTypeID);
                        command.Parameters.AddWithValue("@IsAvailable", IsAvailable);
                        command.Parameters.AddWithValue("@IsActive", isActive);
                        command.Parameters.AddWithValue("@Salary", Salary);

                         object reader= command.ExecuteScalar();
                        if(reader!= null && int.TryParse(reader.ToString(),out int value))
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

        public static bool UpdateRecord(int NurseID,int SectionTypeID,decimal Salary,bool isActive)
        {
            bool isDone = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_UpdateNurseRecord", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@NurseID", NurseID);
                        command.Parameters.AddWithValue("@SectionTypeID", SectionTypeID);
                        command.Parameters.AddWithValue("@Salary", Salary);
                        command.Parameters.AddWithValue("@IsActive", isActive);

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

        public static bool DeleteRecord(int NurseID)
        {
            bool IsDone = false;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    
                    using(SqlCommand command=new SqlCommand("SP_DeleteNurseRecord",connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@NurseID", NurseID);

                        int rowaffected=command.ExecuteNonQuery();
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

        public static bool ChangeTheActivateStatus(int NurseID,bool isActive)
        {
            bool isDone = false;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "Update Nurses \r\nset IsActive=@IsActive where NurseID=@NurseID";

                    using(SqlCommand command=new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@NurseID", NurseID);
                        command.Parameters.AddWithValue("@IsActive", isActive);

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







    }
}
