using Aledrogo.Models;
using System.Collections.Generic;

namespace Aledrogo.Data.DataToSeed
{
    public class OrderSeed : IDataToSeed
    {
        public static Order telefon_xiaomi_artur_order = new Order()
        {
            CustomerId = UserSeed.artur.Id,
            Address = AddressSeed.artur_address2,
            Product = ProductSeed.telefon_xiaomi,
            Quantity = 1,
            ProductPrice = 500,
            DeliveryMethod = Product_DeliveryMethodSeed.telefon_xiaomi_paczkomaty.DeliveryMethod,
            DeliveryPrice = Product_DeliveryMethodSeed.telefon_xiaomi_paczkomaty.Price,
            PaymentCompleted = true
        };

        public static Order laptop_uzywany_test1_order = new Order()
        {
            CustomerId = UserSeed.test1.Id,
            Address = AddressSeed.test1_address1,
            Product = ProductSeed.laptop_uzywany,
            Quantity = 1,
            ProductPrice = 1200,
            DeliveryMethod = Product_DeliveryMethodSeed.laptop_uzywany_przesylka_kurierska.DeliveryMethod,
            DeliveryPrice = Product_DeliveryMethodSeed.laptop_uzywany_przesylka_kurierska.Price
        };

        public static Order telewizor_test3_order = new Order()
        {
            CustomerId = UserSeed.test3.Id,
            Address = AddressSeed.test3_address1,
            Product = ProductSeed.telewizor,
            Quantity = 1,
            ProductPrice = 980,
            DeliveryMethod = Product_DeliveryMethodSeed.telefon_xiaomi_odbior_osobisty_po_przedplacie.DeliveryMethod,
            DeliveryPrice = Product_DeliveryMethodSeed.telefon_xiaomi_odbior_osobisty_po_przedplacie.Price,
            PaymentCompleted = true
        };

        public static Order etui_artur_order = new Order()
        {
            CustomerId = UserSeed.artur.Id,
            Address = AddressSeed.artur_address1,
            Product = ProductSeed.etui,
            Quantity = 3,
            ProductPrice = ProductSeed.etui.Price,
            DeliveryMethod = Product_DeliveryMethodSeed.etui_paczkomaty.DeliveryMethod,
            DeliveryPrice = Product_DeliveryMethodSeed.etui_paczkomaty.Price
        };

        public static Order powerbank_krzysztof_order = new Order()
        {
            CustomerId = UserSeed.krzysztof.Id,
            Address = AddressSeed.krzysztof_address2,
            Product = ProductSeed.powerbank,
            Quantity = 5,
            ProductPrice = ProductSeed.powerbank.Price,
            DeliveryMethod = Product_DeliveryMethodSeed.powerbank_list_polecony_priorytetowy.DeliveryMethod,
            DeliveryPrice = Product_DeliveryMethodSeed.powerbank_list_polecony_priorytetowy.Price,
            PaymentCompleted = true
        };

        public static Order konsola_ps4_test2_order = new Order()
        {
            CustomerId = UserSeed.test2.Id,
            Address = AddressSeed.test2_address1,
            Product = ProductSeed.konsola_ps4,
            Quantity = 2,
            ProductPrice = ProductSeed.konsola_ps4.Price,
            DeliveryMethod = Product_DeliveryMethodSeed.konsola_ps4_przesylka_kurierska.DeliveryMethod,
            DeliveryPrice = Product_DeliveryMethodSeed.konsola_ps4_przesylka_kurierska.Price
        };

        public IEnumerable<object> Items { get; } = new List<Order>()
        {
            telefon_xiaomi_artur_order,
            laptop_uzywany_test1_order,
            telewizor_test3_order,
            etui_artur_order,
            powerbank_krzysztof_order,
            konsola_ps4_test2_order
        };
    }
}
