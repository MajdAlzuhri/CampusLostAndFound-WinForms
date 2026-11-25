using System;
using System.Data;
using System.Data.SqlClient;

namespace CampusLostAndFound.DAL
{
    public class clsItemDataAccess
    {
        public static bool GetItemInfoByID(int itemID, ref string itemName, ref string category,
            ref string color, ref string description, ref string itemType, ref DateTime itemDate,
            ref string location, ref string status, ref int createdBy)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Items WHERE ItemID = @ItemID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ItemID", itemID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    itemName = (string)reader["ItemName"];
                    category = (string)reader["Category"];
                    color = reader["Color"] != DBNull.Value ? (string)reader["Color"] : "";
                    description = reader["Description"] != DBNull.Value ? (string)reader["Description"] : "";
                    itemType = (string)reader["ItemType"];
                    itemDate = (DateTime)reader["ItemDate"];
                    location = (string)reader["Location"];
                    status = (string)reader["Status"];
                    createdBy = reader["CreatedBy"] != DBNull.Value ? (int)reader["CreatedBy"] : -1;
                }
                reader.Close();
            }
            catch
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static int AddNewItem(string itemName, string category, string color, string description,
            string itemType, DateTime itemDate, string location, string status, int createdBy)
        {
            int itemID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Items (ItemName, Category, Color, Description, ItemType, ItemDate, Location, Status, CreatedBy)
                             VALUES (@ItemName, @Category, @Color, @Description, @ItemType, @ItemDate, @Location, @Status, @CreatedBy);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ItemName", itemName);
            command.Parameters.AddWithValue("@Category", category);
            command.Parameters.AddWithValue("@Color", string.IsNullOrWhiteSpace(color) ? (object)DBNull.Value : color);
            command.Parameters.AddWithValue("@Description", string.IsNullOrWhiteSpace(description) ? (object)DBNull.Value : description);
            command.Parameters.AddWithValue("@ItemType", itemType);
            command.Parameters.AddWithValue("@ItemDate", itemDate.Date);
            command.Parameters.AddWithValue("@Location", location);
            command.Parameters.AddWithValue("@Status", status);
            command.Parameters.AddWithValue("@CreatedBy", createdBy == -1 ? (object)DBNull.Value : createdBy);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    itemID = insertedID;
            }
            catch { }
            finally
            {
                connection.Close();
            }

            return itemID;
        }

        public static bool UpdateItem(int itemID, string itemName, string category, string color,
            string description, string itemType, DateTime itemDate, string location, string status)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE Items 
                             SET ItemName = @ItemName,
                                 Category = @Category,
                                 Color = @Color,
                                 Description = @Description,
                                 ItemType = @ItemType,
                                 ItemDate = @ItemDate,
                                 Location = @Location,
                                 Status = @Status
                             WHERE ItemID = @ItemID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ItemID", itemID);
            command.Parameters.AddWithValue("@ItemName", itemName);
            command.Parameters.AddWithValue("@Category", category);
            command.Parameters.AddWithValue("@Color", string.IsNullOrWhiteSpace(color) ? (object)DBNull.Value : color);
            command.Parameters.AddWithValue("@Description", string.IsNullOrWhiteSpace(description) ? (object)DBNull.Value : description);
            command.Parameters.AddWithValue("@ItemType", itemType);
            command.Parameters.AddWithValue("@ItemDate", itemDate.Date);
            command.Parameters.AddWithValue("@Location", location);
            command.Parameters.AddWithValue("@Status", status);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        public static bool DeleteItem(int itemID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "DELETE FROM Items WHERE ItemID = @ItemID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ItemID", itemID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        public static DataTable GetItemsByType(string itemType)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT Items.ItemID, Items.ItemName, Items.Category, Items.Color, 
                                    Items.ItemDate, Items.Location, Items.Status, 
                                    ISNULL(Users.Username, 'System') AS ReportedBy
                             FROM Items 
                             LEFT JOIN Users ON Items.CreatedBy = Users.UserID
                             WHERE Items.ItemType = @ItemType
                             ORDER BY Items.ItemID DESC";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ItemType", itemType);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    dt.Load(reader);
                reader.Close();
            }
            catch { }
            finally
            {
                connection.Close();
            }

            return dt;
        }
    }
}