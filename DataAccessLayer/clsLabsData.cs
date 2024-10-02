using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsLabsData
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

        public static DataTable GetAllLabTestshistory()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetAllLabsHistoryInSys", connection))
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

        public static bool GetFullRecordByID(int LabTestID, ref int PatientRecordId, ref int PatientID, ref int TestTypeID, ref bool IsPaid, ref DateTime DateOfTest,ref string FilePath,ref bool IsDone)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetLabTestFullRecordByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@TestId", LabTestID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                PatientRecordId = (int)reader[1];
                                PatientID = (int)reader[2];
                                TestTypeID = (int)reader[3];
                                IsPaid = Convert.ToBoolean(reader[4]);
                                DateOfTest = (DateTime)reader[5];
                                FilePath = (string)reader[6];
                                IsDone = (bool)reader[7];
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

        public static int AddNewTestLabRecord(int PatientRecordId, int PatientID, int TestTypeID, bool IsPaid, DateTime DateOfTest)
        {
            int NewId = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_AddNewLabTestRecord", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PatientRecordID", PatientRecordId);
                        command.Parameters.AddWithValue("@Patient", PatientID);
                        command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
                        command.Parameters.AddWithValue("@IsPaid", IsPaid);
                        command.Parameters.AddWithValue("@DateOfTest", DateOfTest);

                        object reader = command.ExecuteScalar();
                        if (reader != null && int.TryParse(reader.ToString(), out int value))
                        {
                            NewId = value;
                        }

                    }
                }
            }
            catch
            {
                //..
            }

            return NewId;
        }

        public static bool UpdateTestLabRecord(int TestID, int TestTypeID, bool IsPaid, DateTime DateOfTest,string FilePath,bool IsDone)
        {
            bool Isdone = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_UpdateLabTestRecord", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@TestID", TestID);
                        command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
                        command.Parameters.AddWithValue("@IsPaid", IsPaid);
                        command.Parameters.AddWithValue("@DateOfTest", DateOfTest);
                        command.Parameters.AddWithValue("@FilePath", FilePath);
                        command.Parameters.AddWithValue("@IsDone", IsDone);

                        int rowaffected = command.ExecuteNonQuery();
                        if (rowaffected > 0)
                        {
                            Isdone = true;
                        }
                    }
                }
            }
            catch
            {
                //..
            }

            return Isdone;
        }

        public static bool DeleteTestLabRecord(int TestID)
        {
            bool IsDone = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_DeleteLabTest", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@TestId", TestID);

                        int rowaffected = command.ExecuteNonQuery();
                        if (rowaffected > 0)
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

        public static DataTable GetAllTestsForPatient(int PatientID)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetAllTestsForPatient", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PatientID", PatientID);

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
                //...
            }

            return dt;
        }

        public static string GetTestTypeName(int TestTypeID)
        {
            string Name = "";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_GetTestTypeName", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
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

        public static int GetTestTypeIDByName(string TestTypeName)
        {

            int TestId = -1;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_GetTestTypeIDByName", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@TestTypeName", TestTypeName);

                        SqlParameter result = new SqlParameter("@Result", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.ReturnValue
                        };

                        command.Parameters.Add(result);
                        command.ExecuteNonQuery();

                        if (result != null)
                        {
                            TestId = (int)result.Value;
                        }
                    }
                }
            }
            catch
            {
                //..
            }

            return TestId;
        }

        public static decimal GetTestCost(int TestTypeID)
        {
            decimal TestCost = 0;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using(SqlCommand command=new SqlCommand("SP_GetTestTypeCost", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

                        object reader= command.ExecuteScalar(); 
                        if(reader!=null && decimal.TryParse(reader.ToString(),out decimal value))
                        {
                            TestCost = value;
                        }
                    }
                }
            }
            catch
            {
                //..
            }

            return TestCost;
        }

        public static DataTable GetAllTestTypeInSys()
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand("SP_GetAllLapTestType", connection))
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

        public static decimal GetTestCostByName(string TestTypeName)
        {
            decimal cost = 0;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand("SP_GetLabTestCostByName", connection))
                    {
                        command.CommandType=CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@TestTypeName", TestTypeName);

                        object reader = command.ExecuteScalar();
                        if (reader != null && decimal.TryParse(reader.ToString(),out decimal value))
                        {
                            cost = value;
                        }
                    }
                }
            }
            catch
            {
                //..
            }

            return cost;    
        }


    }
}





    
