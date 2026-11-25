using System;
using System.Data;
using CampusLostAndFound.DAL;

namespace CampusLostAndFound.BLL
{
    public class clsUser
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public bool IsActive { get; set; }

        public clsUser()
        {
            this.UserID = -1;
            this.Username = "";
            this.Password = "";
            this.Role = "User";
            this.IsActive = true;
            this.Mode = enMode.AddNew;
        }

        private clsUser(int userID, string username, string password, string role, bool isActive)
        {
            this.UserID = userID;
            this.Username = username;
            this.Password = password;
            this.Role = role;
            this.IsActive = isActive;
            this.Mode = enMode.Update;
        }

        public static clsUser Find(string username, string password)
        {
            int userID = -1;
            string role = "";
            bool isActive = false;

            if (clsUserDataAccess.GetUserInfoByUsernameAndPassword(username, password, ref userID, ref role, ref isActive))
                return new clsUser(userID, username, password, role, isActive);
            else
                return null;
        }

        public static clsUser Find(int userID)
        {
            string username = "", password = "", role = "";
            bool isActive = false;

            if (clsUserDataAccess.GetUserInfoByID(userID, ref username, ref password, ref role, ref isActive))
                return new clsUser(userID, username, password, role, isActive);
            else
                return null;
        }

        private bool _AddNewUser()
        {
            this.UserID = clsUserDataAccess.AddNewUser(this.Username, this.Password, this.Role, this.IsActive);
            return (this.UserID != -1);
        }

        private bool _UpdateUser()
        {
            return clsUserDataAccess.UpdateUser(this.UserID, this.Username, this.Password, this.Role, this.IsActive);
        }

        public static bool IsUserExists(string username)
        {
            return clsUserDataAccess.IsUsernameExists(username);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateUser();
            }
            return false;
        }

        public static bool DeleteUser(int userID)
        {
            return clsUserDataAccess.DeleteUser(userID);
        }

        public static DataTable GetAllUsers()
        {
            return clsUserDataAccess.GetAllUsers();
        }
    }
}