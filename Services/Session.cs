using POS_V1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_V1.Services
{
    public static class Session
    {
        public static int CurrentUserId { get; set; }
        public static string CurrentUsername { get; set; }
        public static string CurrentFirstName { get; set; }
        public static int CurrentUserRole { get; set; }
        public static bool IsLoggedIn { get; set; } = false;

        public static void SetSession(LoginModel user)
        {
            if (user != null)
            {
                CurrentUserId = user.Id;
                CurrentUsername = user.Username;
                CurrentFirstName = user.FirstName;
                CurrentUserRole = (int)user.Role;
                IsLoggedIn = true;
            }

            Console.WriteLine($@"
            === User Logged In ===
            ID        : {user.Id}
            Username  : {user.Username}
            FirstName : {user.FirstName}
            Role      : {(int)user.Role}
            IsLoggedIn: {IsLoggedIn}
            ");

        }

        public static void ClearSession()
        {
            CurrentUserId = 0;
            CurrentUsername = null;
            CurrentFirstName = null;
            CurrentUserRole = 0;
            IsLoggedIn = false;
        }
    }
}
