using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Aledrogo.Tests
{
    [CollectionDefinition("Services Collection")]
    public class ServicesCollection : ICollectionFixture<ServicesFixture>
    {
    }
}
