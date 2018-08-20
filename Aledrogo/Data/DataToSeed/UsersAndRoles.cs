using Aledrogo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aledrogo.Data
{
    public static partial class DataToSeed
    {
        public class User
        {
            public string UserName { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public string RoleName { get; set; }
        }

        public static List<User> Users { get; } = new List<User>()
        {
            new User {UserName = "admin@wp.pl", Email = "admin@wp.pl", Password = "zaqWSX123!", RoleName = "Admin"},
            new User {UserName = "artur@wp.pl", Email = "artur@wp.pl", Password = "zaqWSX123!", RoleName = "User"},
            new User {UserName = "krzysztof@wp.pl", Email = "krzysztof@wp.pl", Password = "zaqWSX123!", RoleName = "User"}
        };

        public static List<string> Roles { get; } = new List<string>()
        {
            "Admin", "User"
        };
    }
}
