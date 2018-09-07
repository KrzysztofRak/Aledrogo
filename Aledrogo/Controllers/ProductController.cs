using Aledrogo.Data.DataToSeed;
using Aledrogo.DTO;
using Aledrogo.ModelFilters;
using Aledrogo.Models.Enums;
using Aledrogo.Repositories;
using Aledrogo.Repositories.Filters.FilterDTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Aledrogo.Controllers
{
    [Route("api/[controller]")]

    public class ProductController : Controller
    {
        private readonly IProductRepository _repo;

        public ProductController(IProductRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetByFilter(int? pageIndex = null, int? pageSize = null)
        {
            try
            {
                ProductFilter productFilter = new ProductFilter();
               // productFilter.SearchName = "Redmi Note";
                //productFilter.MinPrice = 200;
                //productFilter.MaxPrice = 1400;
                //productFilter.CategoryId = 2;

                //productFilter.OfferType = OfferType.AUCTION | OfferType.BUY_IT_NOW;

                //productFilter.ProductStatesIds.Add(ProductStateSeed.uzywany.Id);
                //productFilter.ProductStatesIds.Add(ProductStateSeed.powystawowy.Id);
                //productFilter.ProductStatesIds.Add(ProductStateSeed.uszkodzony.Id);

                //productFilter.DeliveryMethodsIds.Add(DeliveryMethodSeed.przesylka_kurierska.Id);
                //productFilter.DeliveryMethodsIds.Add(DeliveryMethodSeed.odbior_osobisty_po_przedplacie.Id);

                //productFilter.SpecificFieldsFilters.Add(new SpecificFieldFilter() { SpecificFieldId = SpecificFieldSeed.interfejs.Id, SpecificFieldValueId = SpecificFieldValueSeed.interfejs_miui_9.Id });
                //productFilter.SpecificFieldsFilters.Add(new SpecificFieldFilter() { SpecificFieldId = SpecificFieldSeed.kolor.Id, SpecificFieldValueId = SpecificFieldValueSeed.kolor_czarny.Id });
                //productFilter.SpecificFieldsFilters.Add(new SpecificFieldFilter() { SpecificFieldId = SpecificFieldSeed.ilosc_kolorow.Id, MinValue = 13000000, MaxValue = 30000000 });


               var products = await _repo.GetByFilter(productFilter, pageIndex, pageSize);

                return new JsonResult(products);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}