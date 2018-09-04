using Aledrogo.Models.Enums;
using Aledrogo.Repositories.Cache.CacheDTOs;
using System;
using System.Collections.Generic;

namespace Aledrogo.ModelFilters
{
    public class ProductFilter
    {
        public static readonly int CATEGORY_NOT_SELECTED = 0;
        public static readonly int PRICE_UNDEFINED = 0;

        public string SearchString { get; set; } = String.Empty;
        public int CategoryId { get; set; } = CATEGORY_NOT_SELECTED;
        public decimal MinPrice { get; set; } = PRICE_UNDEFINED;
        public decimal MaxPrice { get; set; } = PRICE_UNDEFINED;
        public TypeOfOffer TypeOfOffer { get; set; } = TypeOfOffer.ANY;

        public ICollection<int> ProductStateIds { get; set; } = new List<int>();
        public ICollection<int> DeliveryMethodIds { get; set; } = new List<int>();

        public ICollection<SpecificFieldValueDTO> SpecificFieldsValues { get; set; } = new List<SpecificFieldValueDTO>();
    }
}
