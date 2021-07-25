
namespace Comma.CustomClasses
{
    class GlobalData
    {
        public static string userID = "";
        public static string userFullName = "";
        public static string adminUser = "Admin";
        public static string customerUser = "Customer";
        public static string userType = customerUser;

        // ========== MANAGE ROOMS (EDIT/REMOVE) ============ //
        public static string editRoom = "EDIT ROOM";
        public static string removeRoom = "REMOVE ROOM";
        // ========== ROOM RENT TYPE (DAILY/HOURLY) ========= //
        public static string hourlyRoom = "Hourly";
        public static string dailyRoom = "Daily";
        // ========== ACCEPT & REJECT RENT TEXT ============= //
        public static string acceptedRentNotification = "Your Rent Request has been Accepted !";
        public static string declinedRentNotification = "Your Rent Request has been Declined !";
    }
}
