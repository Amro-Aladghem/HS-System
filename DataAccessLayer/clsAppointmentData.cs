using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsAppointmentData
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

        public static DataTable GetAllAppointmetnsInSys()
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand("SP_GetAllAppointmentsInSys",connection))
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

        public static bool GetFullRecordForAppointmentByID(int AppointmentID,ref string PersonFirstName,ref string PersonLastName,ref string phoneNumber,ref string Address,ref int DoctorID,ref bool IsActive,ref DateTime DateOfAppointment,ref TimeSpan Time)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_GetAppointmentFullRecordByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@AppointmentID", AppointmentID);

                        using(SqlDataReader reader=command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                isFound = true;

                                PersonFirstName = (string)reader[1];
                                PersonLastName = (string)reader[2];
                                phoneNumber = (string)reader[3];
                                Address = (string)reader[4];
                                DoctorID = (int)reader[5];
                                IsActive = Convert.ToBoolean(reader[6]);
                                DateOfAppointment = (DateTime)reader[7];
                                Time = (TimeSpan)reader[8];
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

        public static bool GetFullRecordForAppointmentByName(ref int AppointmentID,string PersonFirstName,string PersonLastName, ref string phoneNumber, ref string Address, ref int DoctorID, ref bool IsActive, ref DateTime DateOfAppointment, ref TimeSpan Time)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_GetAppointmentFullRecordByName", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@FirstName", PersonFirstName) ;
                        command.Parameters.AddWithValue("@LastName", PersonLastName);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                AppointmentID = (int)reader[0];
                                phoneNumber = (string)reader[3];
                                Address = (string)reader[4];
                                DoctorID = (int)reader[5];
                                IsActive = Convert.ToBoolean(reader[6]);
                                DateOfAppointment = (DateTime)reader[7];
                                Time = (TimeSpan)reader[8];
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

        public static int AddNewAppointment(string PersonFirstName,  string PersonLastName,  string phoneNumber,  string Address,  int DoctorID,  bool IsActive,  DateTime DateOfAppointment, TimeSpan Time,int ? PatientID)
        {
            int NewID = -1;

            try
            {
                using(SqlConnection connection= new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand("SP_AddNewAppointment",connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PersonFirstName", PersonFirstName);
                        command.Parameters.AddWithValue("@PersonLastName", PersonLastName);
                        command.Parameters.AddWithValue("@Phone", phoneNumber);
                        command.Parameters.AddWithValue("@Address", Address);
                        command.Parameters.AddWithValue("@DoctorID", DoctorID);
                        command.Parameters.AddWithValue("@IsActive", IsActive);
                        command.Parameters.AddWithValue("@DateOfAppointment", DateOfAppointment);
                        command.Parameters.AddWithValue("@Time", Time.ToString(@"hh\:mm"));
                        AddValueToParameterCommand(command, "@PatientID", PatientID);

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

        public static bool UpdateAppointentRecord(int AppointmentID,string Phone,string Address,int DoctorID,bool IsActive,DateTime DateOfAppointment,TimeSpan Time)
        {
            bool IsDone = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand("SP_UpdateAppointmentRecord", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Phone", Phone);
                        command.Parameters.AddWithValue("@Address", Address);
                        command.Parameters.AddWithValue("@DoctorID", DoctorID);
                        command.Parameters.AddWithValue("@IsActive", IsActive);
                        command.Parameters.AddWithValue("@DateOfAppointment", DateOfAppointment);
                        command.Parameters.AddWithValue("@Time", Time);
                        command.Parameters.AddWithValue("@AppointmentID", AppointmentID);

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

        public static bool DeleteAppointmentRecord(int AppintmentID)
        {
            bool IsDone = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand("SP_DeleteAppointment", connection))
                    {
                        command.CommandType=CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@AppointmentID", AppintmentID);

                        int rowaffected= command.ExecuteNonQuery();
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

        public static bool IsDoctorAvaialableForAppointment(int DoctorID, TimeSpan Time,DateTime DateOfAppointment)
        {
            bool IsRight = true;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_IsDoctorAvailableForMakeAppointment",connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@DoctorID", DoctorID);
                        command.Parameters.AddWithValue("@Time", Time);
                        command.Parameters.AddWithValue("@Date", DateOfAppointment);

                        SqlParameter resultPar = new SqlParameter("@Result", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.ReturnValue
                        };

                        command.Parameters.Add(resultPar);
                        command.ExecuteNonQuery();

                        if ((int)resultPar.Value == 1)
                        {
                            IsRight = false;
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

        public static DataTable GetAllActiveAppointmentForDoctor(int DoctorID)
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand("SP_GetAllActiveAppointmentForDoctor", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@DoctorID", DoctorID);

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

        public static decimal GetAppointmentCostForADoctor(int DoctorID)
        {
            decimal result = 0;

            try
            {
                using(SqlConnection connection =new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand("SP_GetAppointmentCostForADoctor", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@DoctorID", DoctorID);

                        object reader= command.ExecuteScalar();
                        if(reader!=null&& decimal.TryParse(reader.ToString(),out decimal value))
                        {
                            result = value;
                        }

                    }
                }
            }
            catch
            {
                //..
            }

            return result;
        }

        public static DataTable GetAllDoctorsWhoseHaveARoom()
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command =new SqlCommand("SP_GetAllDoctorsWhoseHaveARoom", connection))
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

        public static bool AddNewPrescription(int AppointemntID,string Discription)
        {
            int NewID = -1;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand("SP_AddNewPrescription", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@AppointmentID", AppointemntID);
                        command.Parameters.AddWithValue("@Discirption", Discription);

                        object reader=command.ExecuteScalar();
                        if(reader!=null&& int.TryParse(reader.ToString(),out int value))
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

            return NewID != -1;
        }

        public static DataTable GetAllPrescriptionsInSys()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand("SP_GetAllPrescriptionsInSys", connection))
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

        public static bool AddPatientIDToAppointmentRecord(int AppointmentID,int PatientID)
        {
            bool isDone = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand("SP_AddPatientRecordToAppointment", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@AppointmentID", AppointmentID);
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




    }
}
