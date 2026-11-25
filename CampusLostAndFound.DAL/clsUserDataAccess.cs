using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusLostAndFound.DAL
{
    public class clsUserDataAccess
    {


        public static bool GetUserInfoByUsernameAndPassword(string username, string password,
            ref int userID, ref string role, ref bool isActive)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", password);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    userID = (int)reader["UserID"];
                    role = reader["Role"] != DBNull.Value ? (string)reader["Role"] : "";
                    isActive = reader["IsActive"] != DBNull.Value ? (bool)reader["IsActive"] : false;
                }
                else
                {
                    isFound = false;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }


        public static bool IsUserExists(string username, string password)
        {
            bool isFound = false;

            SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query= "SELECT Found=1 FROM Users WHERE Username=@Username AND Password=@Password";

            SqlCommand command=new SqlCommand(query,connection);

            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", password);
            try
            {
                connection.Open();
                SqlDataReader reader=command.ExecuteReader();
                isFound=reader.HasRows;
                reader.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error checking user existence: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }


        public static int AddNewUser(string username, string password, string role, bool isActive)
        {
            int userID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Users (Username, Password, Role, IsActive) 
                     VALUES (@Username, @Password, @Role, @IsActive);
                     SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", password);
            command.Parameters.AddWithValue("@Role", role); 
            command.Parameters.AddWithValue("@IsActive", isActive);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    userID = insertedID;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error adding new user: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return userID;
        }



        public static bool UpdateUser(int userID, string username, string password, string role, bool isActive)
        {
            bool isUpdated = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE Users 
                     SET Username = @Username, 
                         Password = @Password, 
                         Role = @Role, 
                         IsActive = @IsActive 
                     WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", userID);
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", password);
            command.Parameters.AddWithValue("@Role", role);
            command.Parameters.AddWithValue("@IsActive", isActive);

            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    isUpdated = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating user: " + ex.Message);
                isUpdated = false;
            }
            finally
            {
                connection.Close();
            }

            return isUpdated;
        }


        public static bool DeleteUser(int userID)
        {
            bool isDeleted = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "DELETE FROM Users WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", userID);

            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    isDeleted = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting user: " + ex.Message);
                isDeleted = false;
            }
            finally
            {
                connection.Close();
            }

            return isDeleted;
        }



        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT UserID, Username, Role, IsActive FROM Users";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public static bool GetUserInfoByID(int userID, ref string username, ref string password, ref string role, ref bool isActive)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Users WHERE UserID = @UserID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", userID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    username = (string)reader["Username"];
                    password = (string)reader["Password"];
                    role = (string)reader["Role"];
                    isActive = (bool)reader["IsActive"];
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }


        public static bool IsUsernameExists(string username)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Users WHERE Username = @Username";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", username);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                isFound = reader.HasRows;
                reader.Close();
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }


    }
}
