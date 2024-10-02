using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsPatinetsData
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

        public static DataTable GetAllPatientRecord()
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using(SqlCommand command =new SqlCommand("SP_GetAllPatientsInSys",connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                       
                        using(SqlDataReader reader = command.ExecuteReader())
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

        public static bool GetFullRecordByID(int PatientID,ref int PersonID,ref string Nationality,ref string Address,ref int? BloodTypeID,ref string RelativeNumber)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_GetPatinetFullRecordByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PatientID", PatientID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                PersonID = (int)reader[1];
                                Nationality = (string)reader[2];
                                Address = (string)reader[3];
                                BloodTypeID = reader[4] == System.DBNull.Value ? null : (int?)reader[4];
                                RelativeNumber = (string)reader[5];

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

        public static bool GetFullRecordByNationalNum(string NationalNum,ref int PatientID,ref int PersonID,ref string Nationality,ref string Address,ref int? BloodTypeID,ref string RelativeNumber)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_GetPatientFullRecordByNationalNum", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@NationalNum", NationalNum);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                PatientID = (int)reader[0];
                                PersonID = (int)reader[1];
                                Nationality = (string)reader[2];
                                Address = (string)reader[3];
                                BloodTypeID = reader[4] == System.DBNull.Value ? null : (int?)reader[4];
                                RelativeNumber = (string)reader[5];

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

        public static int AddNewRecord(int PersonID, string Nationality, string Address, int? BloodTypeID, string RelativeNumber)
        {
            int NewID = -1;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_AddNewPatientRecord", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@Nationality", Nationality);
                        command.Parameters.AddWithValue("@Address", Address);
                        AddValueToParameterCommand(command, "@BloodTypeID", BloodTypeID);
                        command.Parameters.AddWithValue("RelativeNumber", RelativeNumber);

                        object reader = command.ExecuteScalar();
                        if (reader != null && int.TryParse(reader.ToString(), out int value))
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

        public static bool UpdateRecord(int PatientID,string Address,int ?BloodTypeID,string RelativeNumber)
        {
            bool IsDone = false;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand("SP_UpdatePatientRecord",connection))
                    {
                     
                        command.CommandType=CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PatientID", PatientID);
                        command.Parameters.AddWithValue("@Address", Address);
                        command.Parameters.AddWithValue("@RelativeNumber", RelativeNumber);
                        AddValueToParameterCommand(command, "@BloodTypeID", BloodTypeID);

                        int rowaffected = command.ExecuteNonQuery();
                        if(rowaffected > 0)
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
        
        public static bool DeleteRecord(int PatientID)
        {
            bool isDone=false;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand("SP_DeletePatientRecord",connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PatientID", PatientID);

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
        
        public static bool IsPatientExitsInSys(string NationalNum)
        {
            bool IsExits = false;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using(SqlCommand command=new SqlCommand("SP_IsPatientExits",connection))
                    {
                        command.CommandType=CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@NationalNum", NationalNum);

                        object reader=command.ExecuteScalar();
                        if(reader!=null && int.TryParse(reader.ToString(),out int value))
                        {
                            IsExits = true;
                        }
                    }
                }
            }
            catch
            {
               //...
            }

            return IsExits;
        }


        public static DataTable GetAllTestForPatientThatIsNotPaid(int PaitentID)
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand("SP_GetAllTestForPaitentThatIsNotPaid", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PatientID", PaitentID);

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

        public static DataTable GetAllSurgeryProcederForPatientThatIsNotPaid(int PatientID)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_GetAllSurgeryProcederForPatientThatIsNotPaid", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PatientID", PatientID);

                        using(SqlDataReader reader=command.ExecuteReader())
                        {
                            if(reader.HasRows)
                            {
                                dt.Load(reader) ;
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

        public static DataTable GetPatientRecord(int PatientID)
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand("SP_GetPatientRecord", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PatientID", PatientID);

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


        public static decimal GetTotalTestsCostForPatient(int PatientID)
        {
            decimal Cost = 0;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using(SqlCommand command=new SqlCommand("SP_GetTotalTestsCostForPatient", connection))
                    {
                        command.CommandType=CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PatientID", PatientID);

                        object reader= command.ExecuteScalar();
                        if(reader!=null && decimal.TryParse(reader.ToString(),out decimal value))
                        {
                            Cost = value;
                        }
                    }
                }
            }
            catch
            {
                //..
            }

            return Cost;
        }

        public static decimal GetTotalSurgeryProcedureCostForPatient(int PatientID)
        {
            decimal Cost = 0;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand("SP_GetTotalSurgeryProcedureCostForPatient", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PatientID", PatientID);
                        object reader = command.ExecuteScalar();

                        if (reader != null && decimal.TryParse(reader.ToString(), out decimal value))
                        {
                            Cost = value;
                        }

                    }
                }
            }
            catch
            {
                //...
            }

            return Cost;
        }

        public static bool MakeTestIsPaidForPatient(int TestID)
        {
            bool IsDone = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_MakeTestIsPaidForPatient", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@TestID", TestID);

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

        public static bool MakeSuregryProcedurePaidForPatient(int SurgeryID)
        {
            bool IsDone = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_MakeSurgeryPaidForPatient", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@SurgeryId", SurgeryID);

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








    }
}
