using System.Data;
using CampusLostAndFound.DAL;

namespace CampusLostAndFound.BLL
{
    public class clsDashboard
    {
        public int TotalLostItems { get; set; }
        public int TotalFoundItems { get; set; }
        public int TotalClaims { get; set; }
        public int TotalUsers { get; set; }

        public clsDashboard()
        {
            TotalLostItems = 0;
            TotalFoundItems = 0;
            TotalClaims = 0;
            TotalUsers = 0;
        }

        public static clsDashboard GetSummary()
        {
            int lost = 0, found = 0, claims = 0, users = 0;

            clsDashboardDataAccess.GetDashboardStats(ref lost, ref found, ref claims, ref users);

            clsDashboard summary = new clsDashboard();
            summary.TotalLostItems = lost;
            summary.TotalFoundItems = found;
            summary.TotalClaims = claims;
            summary.TotalUsers = users;

            return summary;
        }

        public static DataTable GetRecentItems()
        {
            return clsDashboardDataAccess.GetRecentItems();
        }
    }
}