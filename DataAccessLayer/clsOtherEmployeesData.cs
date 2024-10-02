using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsOtherEmployeesData
    {
        public static DataTable GetAllRecordsInSys()
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand("SP_GetAllEmployeeInSys",connection))
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

        public static bool GetFullRecordByID(int EmployeeID,ref int PersonID,ref int RolesOfJobID,ref int SectionID,ref DateTime DateOfSet,ref decimal Salary)
        {
            bool isFound = false;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand("SP_GetEmployeeRecordByID",connection))
                    {
                        command.CommandType=CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@EmployeeID", EmployeeID);

                        using(SqlDataReader reader=command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                isFound = true;

                                PersonID = (int)reader[1];
                                RolesOfJobID = (int)reader[2];
                                SectionID = (int)reader[3];
                                DateOfSet = (DateTime)reader[4];
                                Salary = (decimal)reader[5];

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

        public static bool GetFullRecordByName(string FirstName,string LastName,ref int EmployeeID, ref int PersonID, ref int RolesOfJobID, ref int SectionID, ref DateTime DateOfSet,ref decimal Salary)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_GetEmployeeRecordByName", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        command.Parameters.AddWithValue("@LastName", LastName);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                EmployeeID = (int)reader[0];
                                PersonID = (int)reader[1];
                                RolesOfJobID = (int)reader[2];
                                SectionID = (int)reader[3];
                                DateOfSet = (DateTime)reader[4];
                                Salary = (decimal)reader[5];

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

        public static int AddNewRecord(int PersonID,int RolesOfJobID,int SectionID,decimal Salary)
        {
            int NewID = -1;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand("SP_AddNewEmployee",connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@RolesTypeID", RolesOfJobID);
                        command.Parameters.AddWithValue("@SectionID", SectionID);
                        command.Parameters.AddWithValue("@Salary", Salary);

                        object reader= command.ExecuteScalar();
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

        public static bool UdpateRecord(int EmployeeID, int RolesOfJobID, int SectionID, decimal Salary)
        {
            bool isDone= false;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_UpdateEmployeeRecord", connection))
                    {
                        command.CommandType=CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                        command.Parameters.AddWithValue("@RolesTypeID", RolesOfJobID);
                        command.Parameters.AddWithValue("@SectionID", SectionID);
                        command.Parameters.AddWithValue("@Salary", Salary);

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

        public static bool DeleteRecord(int EmployeeID)
        {
            bool isDone= false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand("DeleteEmployeeRecord",connection))
                    {
                        command.CommandType= CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@EmployeeID", EmployeeID);

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


    }
}
