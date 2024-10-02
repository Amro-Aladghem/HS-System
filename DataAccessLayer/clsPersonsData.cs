using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO.IsolatedStorage;

namespace DataAccessLayer
{
    public class clsPersonsData
    {

        private static void AddValueToParameterCommand(SqlCommand command ,string ColoumnName,object value)
        {
            if(value==System.DBNull.Value)
            {
                command.Parameters.AddWithValue("ColoumnName", System.DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("ColoumnName", value);
            }


        }
        public static bool GetFullRecordByID(int PersonID,ref string FirstName,ref string SecondName,ref string LastName,ref string PhoneNumber,ref string Email,ref string NationalNum,ref bool Gendor,ref DateTime DateOfBirth)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connectionn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connectionn.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetPersonRecordByID", connectionn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PersonID", PersonID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                FirstName = (string)reader[1];
                                SecondName = reader[2]?.ToString();
                                LastName = (string)reader[3];
                                PhoneNumber = (string)reader[4];
                                Email = reader[5]?.ToString();
                                NationalNum = (string)reader[6];
                                Gendor = Convert.ToBoolean(reader[7]);
                                DateOfBirth =Convert.ToDateTime(reader[8]);
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

        public static bool GetFullRecordByNationalNum(ref int PersonID, ref string FirstName, ref string SecondName, ref string LastName, ref string PhoneNumber, ref string Email,  string NationalNum, ref bool Gendor, ref DateTime DateOfBirth)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connectionn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connectionn.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetPersonRecordByNationalNum", connectionn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@NationalNum",NationalNum);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                PersonID = (int)reader[0];
                                FirstName = (string)reader[1];
                                SecondName = reader[1]?.ToString();
                                LastName = (string)reader[2];
                                PhoneNumber = (string)reader[3];
                                Email = reader[4]?.ToString();
                                Gendor = Convert.ToBoolean(reader[7]);
                                DateOfBirth =Convert.ToDateTime(reader[8]);

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

        public static int  AddNewPersonRecord( string FirstName, string SecondName, string LastName, string PhoneNumber,  string Email, string NationalNum,  bool Gendor,  DateTime DateOfBirth)
        {
            int NewID = -1;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    
                    using(SqlCommand command=new SqlCommand("SP_AddNewPersonRecord",connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        command.Parameters.AddWithValue("@SecondName", SecondName);
                        command.Parameters.AddWithValue("@LastName", LastName);
                        command.Parameters.AddWithValue("@PhoneNum", PhoneNumber);
                        command.Parameters.AddWithValue("@Email", Email);
                        command.Parameters.AddWithValue("@Gendor", Gendor);
                        command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                        command.Parameters.AddWithValue("@NationalNum", NationalNum);

                        object reader = command.ExecuteScalar();
                        if (reader != null && int.TryParse(reader.ToString(),out int value))
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

        public static bool UpdatePersonRecord(int PersonID, string PhoneNumber, string Email)
        {
            bool isDone = false;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_UpdatePersonRecord", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PhoneNum", PhoneNumber);
                        command.Parameters.AddWithValue("@Email", Email);
                        command.Parameters.AddWithValue("@PersonID", PersonID);

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

        public static bool DeletePerson(int PersonID)
        {
            bool isDone = false;

            try
            {
                using(SqlConnection connection =new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    
                    using(SqlCommand command =new SqlCommand("SP_DeletePerson",connection))
                    {
                        command.CommandType= CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PersonID", PersonID);

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
                //...
            }

            return isDone;
        }














    }
}
