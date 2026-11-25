using System;
using System.Data;
using CampusLostAndFound.DAL;

namespace CampusLostAndFound.BLL
{
    public class clsItem
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string Category { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }
        public string ItemType { get; set; } // "Lost" or "Found"
        public DateTime ItemDate { get; set; }
        public string Location { get; set; }
        public string Status { get; set; }   // "Open", "Claimed", "Returned"
        public int CreatedBy { get; set; }

        public clsItem()
        {
            this.ItemID = -1;
            this.ItemName = "";
            this.Category = "";
            this.Color = "";
            this.Description = "";
            this.ItemType = "Lost";
            this.ItemDate = DateTime.Now;
            this.Location = "";
            this.Status = "Open";
            this.CreatedBy = -1;
            this.Mode = enMode.AddNew;
        }

        private clsItem(int itemID, string itemName, string category, string color,
            string description, string itemType, DateTime itemDate, string location,
            string status, int createdBy)
        {
            this.ItemID = itemID;
            this.ItemName = itemName;
            this.Category = category;
            this.Color = color;
            this.Description = description;
            this.ItemType = itemType;
            this.ItemDate = itemDate;
            this.Location = location;
            this.Status = status;
            this.CreatedBy = createdBy;
            this.Mode = enMode.Update;
        }

        public static clsItem Find(int itemID)
        {
            string itemName = "", category = "", color = "", description = "", itemType = "", location = "", status = "";
            DateTime itemDate = DateTime.Now;
            int createdBy = -1;

            if (clsItemDataAccess.GetItemInfoByID(itemID, ref itemName, ref category, ref color,
                ref description, ref itemType, ref itemDate, ref location, ref status, ref createdBy))
            {
                return new clsItem(itemID, itemName, category, color, description, itemType, itemDate, location, status, createdBy);
            }
            return null;
        }

        private bool _AddNewItem()
        {
            this.ItemID = clsItemDataAccess.AddNewItem(this.ItemName, this.Category, this.Color,
                this.Description, this.ItemType, this.ItemDate, this.Location, this.Status, this.CreatedBy);
            return (this.ItemID != -1);
        }

        private bool _UpdateItem()
        {
            return clsItemDataAccess.UpdateItem(this.ItemID, this.ItemName, this.Category, this.Color,
                this.Description, this.ItemType, this.ItemDate, this.Location, this.Status);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewItem())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateItem();
            }
            return false;
        }

        public static bool DeleteItem(int itemID)
        {
            return clsItemDataAccess.DeleteItem(itemID);
        }

        public static DataTable GetAllLostItems()
        {
            return clsItemDataAccess.GetItemsByType("Lost");
        }

        public static DataTable GetAllFoundItems()
        {
            return clsItemDataAccess.GetItemsByType("Found");
        }
    }
}