using System.Collections.Generic;

namespace Aledrogo.Data.DataToSeed
{
    public interface IDataToSeed
    {
        IEnumerable<object> Items { get; }
    }
}
