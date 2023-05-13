using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Library
{
    static class Userlogin
    {


        // static data members or static fields
        private static string UserID;
        private static string UserName;
        private static string UserPassword;
        /*private static string UserType;*/

        // static methods : setter method
        public static void setUserID(string userID)
        {
            UserID = userID;
        }

        public static void setUserName(string userName)
        {
            UserName = userName;
        }

        public static void setUserPassword(string userPassword)
        {
            UserPassword = userPassword;
        }


        // static method : getter method
        public static string getUserID()
        {
            return UserID;
        }

        public static string getUserName()
        {
            return UserName;
        }

        public static string getUserPassword()
        {
            return UserPassword;
        }



        // clear user login info
        public static void ClearSessions()
        {
            UserID = string.Empty;
            UserName = string.Empty;
            UserPassword = string.Empty;
        }
    }
}
