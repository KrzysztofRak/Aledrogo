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

        public ICollection<ProductState> ProductStates { get; set; } = new List<ProductState>();
        public ICollection<TypeOfOffer> TypesOfOffers { get; set; } = new List<TypeOfOffer>();
        public ICollection<DeliveryMethodType> DeliveryMethodTypes { get; set; } = new List<DeliveryMethodType>();

        public ICollection<SpecificFieldValueDTO> SpecificFieldsValues { get; set; }
    }
}
