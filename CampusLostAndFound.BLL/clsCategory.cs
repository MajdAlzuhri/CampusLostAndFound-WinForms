using System.Data;
using CampusLostAndFound.DAL;

namespace CampusLostAndFound.BLL
{
    public class clsCategory
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        public clsCategory()
        {
            CategoryID = -1;
            CategoryName = string.Empty;
        }

        public static DataTable GetAllCategories()
        {
            return clsCategoryData.GetAllCategories();
        }

        public static bool AddCategory(string categoryName)
        {
            if (string.IsNullOrWhiteSpace(categoryName) || clsCategoryData.IsCategoryExist(categoryName.Trim()))
                return false;

            return clsCategoryData.AddNewCategory(categoryName.Trim()) != -1;
        }

        public static bool UpdateCategory(int categoryID, string newName)
        {
            if (categoryID <= 0 || string.IsNullOrWhiteSpace(newName) || clsCategoryData.IsCategoryExist(newName.Trim()))
                return false;

            return clsCategoryData.UpdateCategory(categoryID, newName.Trim());
        }

        public static bool DeleteCategory(int categoryID)
        {
            return clsCategoryData.DeleteCategory(categoryID);
        }
    }
}