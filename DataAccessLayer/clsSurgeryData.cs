using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsSurgeryData
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

        public static DataTable GetAllProcedureInSys()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_GetAllSurgeryInSys", connection))
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

        public static DataTable GetAllProcedureForSpecificPatient(int PatientID)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetAllSurgeryProcedureForPatient", connection))
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
                //..
            }

            return dt;
        }

        public static bool GetSurgeryProceduerFullRecord(int ProcedureID, ref DateTime Date, ref TimeSpan Time, ref int FirstDoctorID, ref int? SecondDoctorID, ref int? ThirdDoctorID,
                                                         ref int FirstNurseID, ref int? SecondNurseID, ref int PatientID, ref int ProcedureTypeID, ref bool IsFinish, ref int RoomID)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_GetProcedureFullRecordByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ProcedureID", ProcedureID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                Date = (DateTime)reader[1];
                                Time = (TimeSpan)reader[2];
                                FirstDoctorID = (int)reader[3];
                                SecondDoctorID = reader[4] == System.DBNull.Value ? null : (int?)reader[4];
                                ThirdDoctorID = reader[5] == System.DBNull.Value ? null : (int?)reader[5];
                                FirstNurseID = (int)reader[6];
                                SecondNurseID = reader[7] == System.DBNull.Value ? null : (int?)reader[7];
                                PatientID = (int)reader[8];
                                ProcedureTypeID = (int)reader[9];
                                IsFinish = Convert.ToBoolean(reader[10]);
                                RoomID = (int)reader[11];
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


        public static int AddNewSugeryProcedureToSys(DateTime Date, TimeSpan Time, int FirstDoctorID, int? SecondDoctorID, int? ThirdDoctorID,
                                                         int FirstNurseID, int? SecondNurseID, int PatientID, int ProcedureTypeID, bool IsFinish, int RoomID)
        {
            int NewID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_AddNewSugeryProcedureRecord", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Date", Date);
                        command.Parameters.AddWithValue("@Time", Time);
                        command.Parameters.AddWithValue("@FirstDoctorID", FirstDoctorID);
                        AddValueToParameterCommand(command, "@SecondDoctorID", SecondDoctorID);
                        AddValueToParameterCommand(command, "@ThirdDoctorID", ThirdDoctorID);
                        command.Parameters.AddWithValue("@FirstNurseID", FirstNurseID);
                        AddValueToParameterCommand(command, "@SecondNurseID", SecondNurseID);
                        command.Parameters.AddWithValue("@PatientID", PatientID);
                        command.Parameters.AddWithValue("@ProcedureTypeID", ProcedureTypeID);
                        command.Parameters.AddWithValue("@IsFinished", IsFinish);
                        command.Parameters.AddWithValue("@RoomID", RoomID);

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

        public static bool UpdateSugeryProcedureRecord(int RecordID, DateTime Date, TimeSpan Time, int FirstDoctorID, int? SecondDoctorID, int? ThirdDoctorID,
                                                         int FirstNurseID, int? SecondNurseID, int PatientID, int ProcedureTypeID, bool IsFinish, int RoomID)
        {

            bool IsDone = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_UpdateSurgeryProcedureRecord", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@RecordID", RecordID);
                        command.Parameters.AddWithValue("@Date", Date);
                        command.Parameters.AddWithValue("@Time", Time);
                        command.Parameters.AddWithValue("@FirstDoctorID", FirstDoctorID);
                        AddValueToParameterCommand(command, "@SecondDoctorID", SecondDoctorID);
                        AddValueToParameterCommand(command, "@ThirdDoctorID", ThirdDoctorID);
                        command.Parameters.AddWithValue("@FirstNurseID", FirstNurseID);
                        AddValueToParameterCommand(command, "@SecondNurseID", SecondNurseID);
                        command.Parameters.AddWithValue("@PatientID", PatientID);
                        command.Parameters.AddWithValue("@ProcedureTypeID", ProcedureTypeID);
                        command.Parameters.AddWithValue("@IsFinished", IsFinish);
                        command.Parameters.AddWithValue("@RoomID", RoomID);

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

        public static bool DeleteSurgeryProcedureRecord(int RecordID)
        {
            bool IsDone = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_DeleteSurgeryRecord", connection))
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

        public static DataTable GetAllSurgeryRoomsInHS()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetAllSurgeryRoomInHS", connection))
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

        public static decimal GetSurgeryProcedureCostByName(string ProcedureName)
        {
            decimal Cost = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("GetProcedureTypeCostByName", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ProcedureName", ProcedureName);

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
                //..
            }

            return Cost;
        }

        public static decimal GetSurgeryProcedureCostByID(int ProcedureTypeID)
        {
            decimal Cost = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetProcedureTypeCostByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ProcedureTypeID", ProcedureTypeID);

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
                //..
            }

            return Cost;
        }

        public static bool IsSurgeryProcedureCanbeAtThisTime(DateTime Date, TimeSpan Time, int RoomID)
        {
            bool IsRight = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_CheckIfTheTimeOfProcedureConflictWithOther", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Date", Date);
                        command.Parameters.AddWithValue("@Time", Time);
                        command.Parameters.AddWithValue("@RoomID", RoomID);

                        SqlParameter reuslt = new SqlParameter("@Result", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.ReturnValue
                        };

                        command.Parameters.Add(reuslt);
                        command.ExecuteNonQuery();

                        if ((int)reuslt.Value == 0)
                        {
                            IsRight = true;
                        }

                    }
                }
            }
            catch
            {
                //..
            }

            return IsRight;
        }

        public static DataTable GetAllSurgeryDoctorsInSys()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetAllSurgeryDoctorsInSys", connection))
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

        public static DataTable GetAllSurgerNurseInSys()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_GetAllSurgeryNurseInSys", connection))
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

        public static int GetSurgerTypeIDByName(string SurgeryTypeName)
        {
            int ID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("GetSurgeryTypeIDByName", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Name", SurgeryTypeName);

                        SqlParameter Parameter = new SqlParameter("@Result", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.ReturnValue
                        };

                        command.Parameters.Add(Parameter);
                        command.ExecuteNonQuery();
                        
                        if(Parameter!=null)
                        {
                            ID = (int)Parameter.Value;
                        }
                    }
                }
            }

            catch
            {
                //..
            }
        

            return ID;
        }
        
        public static DataTable GetAllSugeryTypesInSys()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand("SP_GetAllSurgeryType", connection))
                    {
                        command.CommandType=CommandType.StoredProcedure;

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

        public static string GetSurgeryTypeNameByID(int surgeryTypeId)
        {
            string Name = "";


            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_GetSrugeryTypeNameByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ID", surgeryTypeId);

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

        public static bool FinishTheSurgeryProcedure(int SugeryProcedureID)
        {
            bool IsDone = false;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand("SP_FinishTheSurgeryProcedure", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ID", SugeryProcedureID);

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
