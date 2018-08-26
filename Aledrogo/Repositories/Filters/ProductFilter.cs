using Aledrogo.Models;
using Aledrogo.Models.Enums;
using Aledrogo.Repositories.Cache.CacheDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aledrogo.ModelFilters
{
    public class ProductFilter
    {
        public string SearchString { get; set; } = String.Empty;
        public int CategoryId { get; set; }
        public decimal MinPrice { get; set; } = 0;
        public decimal MaxPrice { get; set; } = 0;

        public ICollection<ProductState> ProductStates { get; set; } = null;
        public ICollection<TypeOfOffer> TypesOfOffers { get; set; } = null;
        public ICollection<DeliveryMethodType> DeliveryMethodTypes { get; set; } = null;
        public ICollection<SpecificFieldValueDTO> SpecificFieldsValues { get; set; }
    }
}
