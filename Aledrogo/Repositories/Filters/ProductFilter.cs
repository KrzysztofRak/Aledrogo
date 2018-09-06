using Aledrogo.Models;
using Aledrogo.Models.Enums;
using Aledrogo.Repositories.Filters.FilterDTOs;
using System;
using System.Collections.Generic;

namespace Aledrogo.ModelFilters
{
    public class ProductFilter
    {
        public static readonly int CATEGORY_NOT_SELECTED = 0;
        public static readonly int PRICE_UNDEFINED = 0;

        public string SearchName { get; set; } = String.Empty;
        public int CategoryId { get; set; } = CATEGORY_NOT_SELECTED;
        public decimal MinPrice { get; set; } = PRICE_UNDEFINED;
        public decimal MaxPrice { get; set; } = PRICE_UNDEFINED;
        public OfferType OfferType { get; set; } = OfferType.ANY;

        public ICollection<int> ProductStatesIds { get; set; } = new List<int>();
        public ICollection<int> DeliveryMethodsIds { get; set; } = new List<int>();

        public ICollection<SpecificFieldFilter> SpecificFieldsFilters { get; set; } = new List<SpecificFieldFilter>();
    }
}
