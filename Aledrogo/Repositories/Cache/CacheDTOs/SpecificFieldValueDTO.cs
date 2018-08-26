using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aledrogo.Repositories.Cache.CacheDTOs
{
    public class SpecificFieldValueDTO
    {
        public int CategoryId { get; set; }
        public int ProductId { get; set; }
        public string Value { get; set; }
    }
}
