using System.Collections.Generic;

namespace Aledrogo.Data.DataToSeed
{
    public class UserSeed
    {
        public string Id { get; set; }
        public string UserName { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string RoleName { get; private set; }

        public static UserSeed admin = new UserSeed { UserName = "admin@wp.pl", Email = "admin@wp.pl", Password = "zaqWSX123!", RoleName = "Admin" };
        public static UserSeed artur = new UserSeed { UserName = "artur@wp.pl", Email = "artur@wp.pl", Password = "zaqWSX123!", RoleName = "User" };
        public static UserSeed krzysztof = new UserSeed { UserName = "krzysztof@wp.pl", Email = "krzysztof@wp.pl", Password = "zaqWSX123!", RoleName = "User" };

        public static List<UserSeed> Users { get; } = new List<UserSeed>()
        {
            admin, artur, krzysztof
        };
    }
}
