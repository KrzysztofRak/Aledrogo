using System.Collections.Generic;

namespace Aledrogo.Data.DataToSeed
{
    public class RoleSeed : IDataToSeed
    {
        public IEnumerable<object> Items { get; } = new List<string>()
        {
            "Admin", "User"
        };
    }
}
