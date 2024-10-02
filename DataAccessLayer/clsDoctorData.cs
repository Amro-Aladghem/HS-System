using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public  class clsDoctorData
    {
        private static void AddValueToParameterCommand(SqlCommand command, string ColoumnName, object value)
        {
            if (value == System.DBNull.Value||value==null)
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

                    using(SqlCommand command =new SqlCommand("SP_GetAllDoctorsInTheSys",connection))
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
                //...
            }

            return dt;
        }

        public static  bool GetFullRecordByID(int DoctorID,ref int PersonID,ref int SpecialestTypeID,ref int SectionID,ref int? RoomID,ref bool isAvailable,ref bool isActive,ref decimal Salary,ref decimal ?AppointmentCost)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetDoctorByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@DoctorID", DoctorID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                PersonID = (int)reader[1];
                                SpecialestTypeID = (int)reader[2];
                                SectionID = (int)reader[3];
                                if (reader[4] == System.DBNull.Value)
                                {
                                    RoomID = null;
                                }
                                else
                                {
                                    RoomID = (int)reader[4];
                                }
                                isAvailable = (bool)reader[5];
                                isActive = (bool)reader[6];
                                Salary = (decimal)reader[7];
                                if (reader[8]==System.DBNull.Value)
                                {
                                    AppointmentCost = null;
                                }
                                else
                                {
                                    AppointmentCost = (decimal)reader[8];
                                }

                            }
                        }

                    }

                }


            }
            catch
            {
             //....
            }

            return isFound;
        }

        public static  bool GetFullRecordByName(string FirstName,string LastName,ref int DoctorID,ref int PersonID,ref int SpecialestTypeID,ref int SectionID,ref int? RoomID,ref bool isAvailable,ref bool isActive,ref decimal Salary,ref decimal ?AppointmentCost)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetDoctorRecordByName", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        command.Parameters.AddWithValue("@LastName", LastName);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                DoctorID = (int)reader[0];
                                PersonID = (int)reader[1];
                                SpecialestTypeID = (int)reader[2];
                                SectionID = (int)reader[3];
                                if (reader[4] == System.DBNull.Value)
                                {
                                    RoomID = null;
                                }
                                else
                                {
                                    RoomID = (int)reader[4];
                                }
                                isAvailable = (bool)reader[5];
                                isActive = (bool)reader[6];
                                Salary = (decimal)reader[7];
                                if (reader[8]==System.DBNull.Value)
                                {
                                    AppointmentCost = null;
                                }
                                else
                                {
                                    AppointmentCost = (decimal)reader[8];
                                }

                            }
                        }

                    }

                }


            }
            catch
            {
             //....
            }

            return isFound;
        }

        public static int AddNewRecordToTheSys(   int PersonID,  int SpecialestTypeID,  int SectionID,  int? RoomID,  bool isAvailable,  bool isActive,  decimal Salary,  decimal? AppointmentCost)
        {
            int NewID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand("SP_AddNewDoctorReocrd",connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@SpecialestTypeID", SpecialestTypeID);
                        command.Parameters.AddWithValue("@SectionTypeID", SectionID);
                        command.Parameters.AddWithValue("@IsAvailable", isAvailable);
                        command.Parameters.AddWithValue("@IsActive", isActive);
                        command.Parameters.AddWithValue("@Salary", Salary);
                        AddValueToParameterCommand(command, "@Appointment", AppointmentCost);
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

        public static bool UpdateRecord(int DoctorID,int SpecialestTypeID,int SectionID,decimal Salary,int? RoomID,decimal? AppointmentCost,bool isActive)
        {
            bool isDone = false;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using(SqlCommand command =new SqlCommand("SP_UpdateDoctorRecord",connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@DoctorID", DoctorID);
                        command.Parameters.AddWithValue("@SpecialestTypeID", SpecialestTypeID);
                        command.Parameters.AddWithValue("@SectionID", SectionID);
                        command.Parameters.AddWithValue("@Salary", Salary);
                        AddValueToParameterCommand(command, "@RoomID", RoomID);
                        AddValueToParameterCommand(command, "@AppointmentCost", AppointmentCost);

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
        public static bool DeleteRecord(int DoctorID)
        {
            bool isDone = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_DeleteDoctorRecord", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@DoctorID", DoctorID);

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

        public static bool ChangeActiveStatus(int DoctorID,bool isActive)
        {
            bool isDone = false;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "Update Doctors \r\nset IsActive=@IsActive where DoctorID=@DoctorID";

                    using(SqlCommand command=new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@IsActive", isActive);
                        command.Parameters.AddWithValue("@DoctorID", DoctorID);

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

        public static decimal GetAppointmentCostForADoctor(int DoctorID)
        {
            decimal Cost = 0;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "select AppointmentCost from Doctors where DoctorID=@DoctorID";
                    
                    using(SqlCommand command =new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@DoctorID", DoctorID);

                        object reader=command.ExecuteScalar();
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

        public static DataTable GetAllAvailableDoctorForPatients()
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection connectionn=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connectionn.Open();
                    using(SqlCommand command=new SqlCommand("SP_GetAllAvailableDoctor",connectionn))
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




















    }
}
