using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsPateintRecordData
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

        public static DataTable GetAllRecordsInSys()
        {
            DataTable dt = new DataTable();

            try
            {

                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using(SqlCommand command =new SqlCommand("SP_GetAllPatientRecordInSys",connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        
                        using(SqlDataReader reader= command.ExecuteReader())
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

        public static DataTable GetAllRecordsForSpecificPatientByNationalNum(string NationalNum)
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection connectionn=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connectionn.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetAllRecordsForSpecificPatientByNationalNum", connectionn))
                    {
                        command.CommandType=CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@NationalNum", NationalNum);

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

        public static DataTable GetAllRecordsForSpecificPatientByID(int PatientID)
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand("SP_GetAllRecordsForSpecificPatientByID",connection))
                    {
                        command.CommandType= CommandType.StoredProcedure;
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

        public static bool GetFullRecordByID(int RecordID, ref DateTime DateOfArraivel,ref  int PatientID, ref string Symptoms, ref int? DoctorAssignedID, ref bool IsLeaved, ref string Diagnosis, ref DateTime? DateOfLeaved, ref int? RoomID)
        {
            bool isFound = false;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand("SP_GetPatientRecordByRecordID",connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@RecordID", RecordID);

                        using(SqlDataReader reader=command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                isFound = true;

                                PatientID = (int)reader[1];
                                DateOfArraivel = (DateTime)reader[2];
                                Symptoms = (string)reader[3];
                                DoctorAssignedID = reader[4] == System.DBNull.Value ? null : (int?)reader[4];
                                IsLeaved = Convert.ToBoolean(reader[5]);
                                Diagnosis = (string)reader[6];
                                DateOfLeaved = reader[7] == System.DBNull.Value ? null : (DateTime?)reader[7];
                                RoomID = reader[8] == System.DBNull.Value ? null : (int?)reader[8];

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

        public static bool GetTheMostUpdatePatientFullRecord(ref int RecordID,ref DateTime DateOfArraivel,int PetientID,ref string Symptoms,ref int?DoctorAssignedID,ref  bool IsLeaved,ref string Diagnosis,ref DateTime?DateOfLeaved,ref int?RoomID)
        {
            bool isFound = false;

            try
            {

                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using(SqlCommand command=new SqlCommand("SP_GetTheMostUpdatePatientFullRecord",connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PatientID", PetientID);


                        using (SqlDataReader readr = command.ExecuteReader())
                        {
                            if (readr.Read())
                            {
                                isFound = true;

                                RecordID = (int)readr[0];
                                DateOfArraivel = (DateTime)readr[2];
                                Symptoms = (string)readr[3];
                                DoctorAssignedID = readr[4] == System.DBNull.Value ? null : (int?)readr[4];
                                IsLeaved = Convert.ToBoolean(readr[5]);
                                Diagnosis = (string)readr[6];
                                DateOfLeaved = readr[7] == System.DBNull.Value ? null : (DateTime?)readr[7];
                                RoomID = readr[8] == System.DBNull.Value ? null : (int?)readr[8];
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

        public static int AddNewPatientRecordHS(int PatientID,DateTime DateOfArrvail,string Symptoms,int?DoctorAssignedID,bool IsLeaved,string Digonsis,int ? RoomID)
        {
            int NewID = -1;

            try
            {

                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    
                    using(SqlCommand command =new SqlCommand("SP_AddNewFullPatientRecord", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PatientID", PatientID);
                        command.Parameters.AddWithValue("@DateOfArrival", DateOfArrvail);
                        AddValueToParameterCommand(command, "@Symptoms", Symptoms);
                        AddValueToParameterCommand(command, "@DoctorAssignedID", DoctorAssignedID);
                        AddValueToParameterCommand(command, "@Dignosis", Digonsis);
                        command.Parameters.AddWithValue("@IsLeaved", IsLeaved);
                        AddValueToParameterCommand(command, "@RoomID", RoomID);

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

        public static bool UpdatePatientRecordHS(int RecordID,string Symptoms,int?DoctorAssignedID,bool IsLeaved,string Dignosis,int?RoomID)
        {
            bool isDone = false;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand("SP_UpdatePatientRecordHS", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@RecordID", RecordID);
                        AddValueToParameterCommand(command, "@Symptoms", Symptoms);
                        AddValueToParameterCommand(command, "@DoctorAssignedID", DoctorAssignedID);
                        AddValueToParameterCommand(command, "@Diagnosis", Dignosis);
                        command.Parameters.AddWithValue("@IsLeaved", IsLeaved);
                        AddValueToParameterCommand(command, "@RoomID", RoomID);

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

        public static bool DischargePatient(int RecordID)
        {
            bool IsDone = false;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand("DischargePatient",connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@RecordID", RecordID);

                        int rowaffected= command.ExecuteNonQuery();
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

        public static bool DeletePatientRecord(int RecordID)
        {
            bool IsDone = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_DeletePatientFullRecordHS", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@RecordID", RecordID);

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

        public static bool IsPatientHasAnActiveRecord(int PatientID)
        {
            bool isRight = false;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_IsPatientHasAnActiveRecord", connection))
                    {
                        command.CommandType=CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PatientID", PatientID);

                        SqlParameter output = new SqlParameter("@IsLeaved", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };

                        command.Parameters.Add(output);
                        command.ExecuteNonQuery();

                        isRight=output.Value==System.DBNull.Value?false:true;

                    }

                }
            }
            catch
            {
                //..
            }

            return isRight;
        }

       






    }


}
