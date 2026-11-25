using System;
using System.Data;
using System.Data.SqlClient;

namespace CampusLostAndFound.DAL
{
    public class clsDashboardDataAccess
    {
        public static bool GetDashboardStats(ref int totalLost, ref int totalFound, ref int totalClaims, ref int totalUsers)
        {
            bool isSuccess = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"
                SELECT 
                    (SELECT COUNT(*) FROM Items WHERE ItemType = 'Lost') AS TotalLost,
                    (SELECT COUNT(*) FROM Items WHERE ItemType = 'Found') AS TotalFound,
                    (SELECT COUNT(*) FROM Claims) AS TotalClaims,
                    (SELECT COUNT(*) FROM Users) AS TotalUsers";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    totalLost = (int)reader["TotalLost"];
                    totalFound = (int)reader["TotalFound"];
                    totalClaims = (int)reader["TotalClaims"];
                    totalUsers = (int)reader["TotalUsers"];
                    isSuccess = true;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                isSuccess = false;
            }
            finally
            {
                connection.Close();
            }

            return isSuccess;
        }

        public static DataTable GetRecentItems()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"
                SELECT TOP 10 
                    ItemID, 
                    ItemName, 
                    Category, 
                    ItemType, 
                    Location, 
                    ItemDate, 
                    Status 
                FROM Items 
                ORDER BY ItemID DESC";

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
    }
}