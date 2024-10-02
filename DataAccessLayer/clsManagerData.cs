using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public  class clsManagerData
    {

        public static DataTable GetAllManagers()
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand("SP_GetAllManagers", connection))
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

        public static int AddNewManager(int UserID,int SectionTypeID)
        {
            int NewID = -1;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command =new SqlCommand("SP_AddNewManager", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@UserID", UserID);
                        command.Parameters.AddWithValue("@SectionID", SectionTypeID);

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
                //./
            }

            return NewID;
        }

        public static bool UpdateSectionForManager(int ManagerID,int SectionTypeID)
        {
            bool IsDone = false;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand("UpdateSectionForManager", connection))
                    {
                        command.CommandType=CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@MangerID", ManagerID);
                        command.Parameters.AddWithValue("@SectionID", SectionTypeID);

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

        public static bool DeleteManager(int ManagerID)
        {
            bool IsDone =false;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();  
                    using(SqlCommand command =new SqlCommand("SP_DeleteManager", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ManagerID", ManagerID);

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

        public static bool IsManagerExsits(int ManagerID)
        {
            bool IsExsits = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_IsManagerExsits", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ManagerID", ManagerID);

                        SqlParameter result = new SqlParameter("@Result", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.ReturnValue
                        };

                        command.Parameters.Add(result);
                        command.ExecuteNonQuery();

                        if((int)result.Value==1)
                        {
                            IsExsits = true;
                        }
                    }
                }
            }
            catch
            {
                //..
            }

            return IsExsits;
        }



    }
}
