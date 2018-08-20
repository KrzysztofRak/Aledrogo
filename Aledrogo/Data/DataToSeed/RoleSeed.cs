using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aledrogo.Data.DataToSeed
{
    public class RoleSeed
    {
        public static List<string> Roles { get; } = new List<string>()
        {
            "Admin", "User"
        };
    }
}
