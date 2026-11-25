using CampusLostAndFound.BLL;

namespace CampusLostAndFound
{





    public static class clsGlobal
    {
        public static clsUser CurrentUser;



        public static string EscapeRowFilterValue(string value)
        {
            if (string.IsNullOrEmpty(value))
                return string.Empty;

            return value
                .Replace("[", "[[]")
                .Replace("]", "[]]")
                .Replace("*", "[*]")
                .Replace("%", "[%]")
                .Replace("'", "''");
        }


    }



}