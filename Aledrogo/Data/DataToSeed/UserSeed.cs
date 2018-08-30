using Aledrogo.Data.DataToSeed.DTO;
using System.Collections.Generic;

namespace Aledrogo.Data.DataToSeed
{
    public class UserSeed : IDataToSeed
    {
        public static UserSeedDTO admin = new UserSeedDTO { UserName = "admin@wp.pl", Email = "admin@wp.pl", Password = "zaqWSX123!", RoleName = "Admin" };
        public static UserSeedDTO artur = new UserSeedDTO { UserName = "artur@wp.pl", Email = "artur@wp.pl", Password = "zaqWSX123!", RoleName = "User" };
        public static UserSeedDTO krzysztof = new UserSeedDTO { UserName = "krzysztof@wp.pl", Email = "krzysztof@wp.pl", Password = "zaqWSX123!", RoleName = "User" };
        public static UserSeedDTO test1 = new UserSeedDTO { UserName = "test1@wp.pl", Email = "test1@wp.pl", Password = "zaqWSX123!", RoleName = "User" };
        public static UserSeedDTO test2 = new UserSeedDTO { UserName = "test2@wp.pl", Email = "test2@wp.pl", Password = "zaqWSX123!", RoleName = "User" };
        public static UserSeedDTO test3 = new UserSeedDTO { UserName = "test3@wp.pl", Email = "test3@wp.pl", Password = "zaqWSX123!", RoleName = "User" };

        public IEnumerable<object> Items { get; } = new List<UserSeedDTO>()
        {
            admin, artur, krzysztof, test1, test2, test3
        };
    }
}
