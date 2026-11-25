using System;
using System.Data;
using System.Data.SqlClient;

namespace CampusLostAndFound.DAL
{
    public class clsClaimDataAccess
    {
        public static bool GetClaimInfoByID(int claimID, ref int itemID, ref string claimantName,
            ref string phone, ref string verificationResult, ref string claimStatus, ref int createdBy)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Claims WHERE ClaimID = @ClaimID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClaimID", claimID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    itemID = reader["ItemID"] != DBNull.Value ? (int)reader["ItemID"] : -1;
                    claimantName = (string)reader["ClaimantName"];
                    phone = (string)reader["Phone"];
                    verificationResult = reader["VerificationResult"] != DBNull.Value ? (string)reader["VerificationResult"] : "";
                    claimStatus = (string)reader["ClaimStatus"];
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

        public static int AddNewClaim(int itemID, string claimantName, string phone,
            string verificationResult, string claimStatus, int createdBy)
        {
            int claimID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Claims (ItemID, ClaimantName, Phone, VerificationResult, ClaimStatus, CreatedBy)
                             VALUES (@ItemID, @ClaimantName, @Phone, @VerificationResult, @ClaimStatus, @CreatedBy);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ItemID", itemID == -1 ? (object)DBNull.Value : itemID);
            command.Parameters.AddWithValue("@ClaimantName", claimantName);
            command.Parameters.AddWithValue("@Phone", phone);
            command.Parameters.AddWithValue("@VerificationResult", string.IsNullOrWhiteSpace(verificationResult) ? (object)DBNull.Value : verificationResult);
            command.Parameters.AddWithValue("@ClaimStatus", claimStatus);
            command.Parameters.AddWithValue("@CreatedBy", createdBy == -1 ? (object)DBNull.Value : createdBy);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    claimID = insertedID;
            }
            catch { }
            finally
            {
                connection.Close();
            }

            return claimID;
        }

        public static bool UpdateClaim(int claimID, int itemID, string claimantName, string phone,
            string verificationResult, string claimStatus)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE Claims 
                             SET ItemID = @ItemID,
                                 ClaimantName = @ClaimantName,
                                 Phone = @Phone,
                                 VerificationResult = @VerificationResult,
                                 ClaimStatus = @ClaimStatus
                             WHERE ClaimID = @ClaimID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClaimID", claimID);
            command.Parameters.AddWithValue("@ItemID", itemID == -1 ? (object)DBNull.Value : itemID);
            command.Parameters.AddWithValue("@ClaimantName", claimantName);
            command.Parameters.AddWithValue("@Phone", phone);
            command.Parameters.AddWithValue("@VerificationResult", string.IsNullOrWhiteSpace(verificationResult) ? (object)DBNull.Value : verificationResult);
            command.Parameters.AddWithValue("@ClaimStatus", claimStatus);

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

        public static bool DeleteClaim(int claimID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "DELETE FROM Claims WHERE ClaimID = @ClaimID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClaimID", claimID);

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

        public static DataTable GetAllClaims()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT Claims.ClaimID, Claims.ItemID, 
                                    ISNULL(Items.ItemName, 'Unknown') AS ItemName,
                                    Claims.ClaimantName, Claims.Phone, 
                                    Claims.VerificationResult, Claims.ClaimStatus,
                                    ISNULL(Users.Username, 'System') AS ProcessedBy
                             FROM Claims
                             LEFT JOIN Items ON Claims.ItemID = Items.ItemID
                             LEFT JOIN Users ON Claims.CreatedBy = Users.UserID
                             ORDER BY Claims.ClaimID DESC";

            SqlCommand command = new SqlCommand(query, connection);

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

        public static bool HasApprovedClaimForItem(int itemID)
        {
            bool hasApproved = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found = 1 FROM Claims WHERE ItemID = @ItemID AND ClaimStatus = 'Approved'";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ItemID", itemID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                hasApproved = (result != null);
            }
            catch { }
            finally
            {
                connection.Close();
            }

            return hasApproved;
        }


        public static bool HasActiveClaimForItem(int itemID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"SELECT Found = 1 FROM Claims 
                         WHERE ItemID = @ItemID AND ClaimStatus IN ('Pending', 'Approved')";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ItemID", itemID);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    isFound = (result != null);
                }
                catch
                {
                    isFound = false;
                }
            }

            return isFound;
        }
    }
}