using Aledrogo.Models;
using System.Collections.Generic;
using System.Linq;

namespace Aledrogo.Data.DataToSeed
{
    public static class OrderSeed
    {
        public static List<Order> Orders = new List<Order>()
        {
            new Order()
            {
                CustomerId = UserSeed.artur.Id,
                Address = AddressSeed.artur_address2,
                Name = ProductSeed.telefon_xiaomi.Name,
                Product = ProductSeed.telefon_xiaomi,
                Quantity = 1, Value = 800,
                DeliveryMethod = Product_DeliveryMethodSeed.telefon_xiaomi_paczkomaty.DeliveryMethod,
                DeliveryValue = Product_DeliveryMethodSeed.telefon_xiaomi_paczkomaty.Price,
            },

            new Order()
            {
                CustomerId = UserSeed.test1.Id,
                Address = AddressSeed.test1_address1,
                Name = ProductSeed.laptop_uzywany.Name,
                Product = ProductSeed.laptop_uzywany,
                Quantity = 1, Value = 1200,
                DeliveryMethod = Product_DeliveryMethodSeed.laptop_uzywany_przesylka_kurierska.DeliveryMethod,
                DeliveryValue = Product_DeliveryMethodSeed.laptop_uzywany_przesylka_kurierska.Price,
            },

            new Order()
            {
                CustomerId = UserSeed.test3.Id,
                Address = AddressSeed.test3_address1,
                Name = ProductSeed.telewizor.Name,
                Product = ProductSeed.telewizor,
                Quantity = 1, Value = 980,
                DeliveryMethod = Product_DeliveryMethodSeed.telefon_xiaomi_odbior_osobisty_po_przedplacie.DeliveryMethod,
                DeliveryValue = Product_DeliveryMethodSeed.telefon_xiaomi_odbior_osobisty_po_przedplacie.Price,
            }
        };
    }
}
