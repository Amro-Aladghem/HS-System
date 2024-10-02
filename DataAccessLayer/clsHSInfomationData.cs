using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsHSInfomationData
    {
        public static DataTable GetAllSpecialestTypes()
        {
            DataTable  dt=new DataTable();

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand("GetAllSpecialistNameInSyS",connection)) 
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

        public static int GetSpecialestTypeIDByName(string name)
        {
            int ID = -1;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand("SP_GetSpecialestTypeIDByName",connection))
                    {
                        command.CommandType=CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Name", name);

                        object reader=command.ExecuteScalar();
                        if(reader!=null && int.TryParse(reader.ToString(),out int Value))
                        {
                            ID = Value;
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

        public static DataTable GetAllSectionsInSys()
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand("SP_GetAllSectionsInSys",connection))
                    {
                        command.CommandType= CommandType.StoredProcedure;
                       
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

        public static int GetSectionIDByName(string Name)
        {
            int ID = -1;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_GetSectionIDByName", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Name", Name);

                        object reader = command.ExecuteScalar();
                        if (reader != null && int.TryParse(reader.ToString(), out int Value))
                        {
                            ID = Value;
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

        public static DataTable GetAllJobRoleTypes()
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand("SP_GetAllJobRoleInSys",connection))
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

        public static int GetJobRoleIDByName(string Name)
        {
            int ID = -1;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand("SP_GetJobRoleIDByName",connection))
                    {
                        command.CommandType=CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Name", Name);

                        object reader = command.ExecuteScalar();
                        if (reader != null && int.TryParse(reader.ToString(), out int Value))
                        {
                            ID = Value;
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

        public static string GetSpecialestNameByID(int SpecialestID)
        {
            string Name = "";

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "select SpecialestName From SpecialestTypes where SpecialestTypeID=@ID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", SpecialestID);

                        using(SqlDataReader reader =command.ExecuteReader())
                        {
                            if(reader.Read())
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

        public static string GetSectionNameByID(int SectionID)
        {
            string Name = "";

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "select SectionName from SectionTypes where SectionTypeID=@ID";

                    using(SqlCommand command =new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@ID", SectionID);

                        using(SqlDataReader reader=command.ExecuteReader())
                        {
                            if(reader.Read())
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

        public static string GetJobRoleNameByID(int JobRoleID)
        {
            string Name = "";

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "select r.RoleName  from RolesOfJobTypes r where RoleTypeID=@ID";

                    using(SqlCommand command =new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@ID", JobRoleID);
                        
                        using(SqlDataReader reader=command.ExecuteReader())
                        {
                            if(reader.Read())
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
       
        public static DataTable GetAllAvailableRoomForDoctor()
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand("SP_GetAllAvailableRoomForDoctor",connection))
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

        public static int GetRoomNumberByID(int RoomID)
        {
            int RoomNum = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "select s.RoomNumber from HospitalRooms s where RoomID=@RoomID";

                    using(SqlCommand command=new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@RoomID", RoomID);
                        
                        object reader=command.ExecuteScalar();
                        if(reader!=null && int.TryParse(reader.ToString()  ,out int value))
                        {
                            RoomNum = value;
                        }
                    }
                }
            }
            catch
            {
                //..
            }

            return RoomNum;
        }

        public static int GetRoomIDByNumberOfIt(int RoomNumber)
        {
            int RoomID = -1;

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "select s.RoomID from HospitalRooms s where RoomNumber=@RoomNumber";

                    using(SqlCommand command=new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@RoomNumber", RoomNumber);
                        object reader=command.ExecuteScalar();

                        if(reader!=null && int.TryParse(reader.ToString(),out int value))
                        {
                            RoomID = value;
                        }
                    }
                }
            }
            catch
            {
                //..
            }

            return RoomID; 
        }

        public static string GetBloodeTypeNameByID(int BloodeTypeID)
        {
            string Name = "";

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_GetBloodeTypeNameByID",connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ID", BloodeTypeID);

                        using(SqlDataReader reader=command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                Name = (string)reader[0];
                            }
                        }
                    }
                }
            }
            catch
            {
                //...
            }

            return Name;
        }

        public static DataTable GetAllAvailableRoomForPatients()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using(SqlCommand command=new SqlCommand("SP_GetAllAvailableRoomForPatients",connection))
                    {
                        command.CommandType=CommandType.StoredProcedure;

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

        public static DataTable GetAllRoomsInSys()
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand("SP_GetAllRoomsInSys",connection))
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

        public static DataTable GetWareHouseRooms()
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command=new SqlCommand("SP_GetAllWareHouseRoomsInSys", connection))
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


    }
}
