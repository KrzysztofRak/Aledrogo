using Aledrogo.Models;
using System.Collections.Generic;
using System.Linq;

namespace Aledrogo.Data.DataToSeed
{
    public static class OrderSeed
    {
        public static Order telefon_xiaomi_artur_order = new Order()
        {
            CustomerId = UserSeed.artur.Id,
            Address = AddressSeed.artur_address2,
            Product = ProductSeed.telefon_xiaomi,
            Quantity = 1,
            Value = 500,
            DeliveryMethod = Product_DeliveryMethodSeed.telefon_xiaomi_paczkomaty.DeliveryMethod,
            DeliveryValue = Product_DeliveryMethodSeed.telefon_xiaomi_paczkomaty.Price,
            Paid = true
        };

        public static Order laptop_uzywany_test1_order = new Order()
        {
            CustomerId = UserSeed.test1.Id,
            Address = AddressSeed.test1_address1,
            Product = ProductSeed.laptop_uzywany,
            Quantity = 1,
            Value = 1200,
            DeliveryMethod = Product_DeliveryMethodSeed.laptop_uzywany_przesylka_kurierska.DeliveryMethod,
            DeliveryValue = Product_DeliveryMethodSeed.laptop_uzywany_przesylka_kurierska.Price
        };

        public static Order telewizor_test3_order = new Order()
        {
            CustomerId = UserSeed.test3.Id,
            Address = AddressSeed.test3_address1,
            Product = ProductSeed.telewizor,
            Quantity = 1,
            Value = 980,
            DeliveryMethod = Product_DeliveryMethodSeed.telefon_xiaomi_odbior_osobisty_po_przedplacie.DeliveryMethod,
            DeliveryValue = Product_DeliveryMethodSeed.telefon_xiaomi_odbior_osobisty_po_przedplacie.Price,
            Paid = true
        };

        public static Order etui_artur_order = new Order()
        {
            CustomerId = UserSeed.artur.Id,
            Address = AddressSeed.artur_address1,
            Product = ProductSeed.etui,
            Quantity = 3,
            Value = ProductSeed.etui.Price,
            DeliveryMethod = Product_DeliveryMethodSeed.etui_paczkomaty.DeliveryMethod,
            DeliveryValue = Product_DeliveryMethodSeed.etui_paczkomaty.Price
        };

        public static Order powerbank_krzysztof_order = new Order()
        {
            CustomerId = UserSeed.krzysztof.Id,
            Address = AddressSeed.krzysztof_address2,
            Product = ProductSeed.powerbank,
            Quantity = 5,
            Value = ProductSeed.powerbank.Price,
            DeliveryMethod = Product_DeliveryMethodSeed.powerbank_list_polecony_priorytetowy.DeliveryMethod,
            DeliveryValue = Product_DeliveryMethodSeed.powerbank_list_polecony_priorytetowy.Price,
            Paid = true
        };

        public static Order konsola_ps4_test2_order = new Order()
        {
            CustomerId = UserSeed.test2.Id,
            Address = AddressSeed.test2_address1,
            Product = ProductSeed.konsola_ps4,
            Quantity = 2,
            Value = ProductSeed.konsola_ps4.Price,
            DeliveryMethod = Product_DeliveryMethodSeed.konsola_ps4_przesylka_kurierska.DeliveryMethod,
            DeliveryValue = Product_DeliveryMethodSeed.konsola_ps4_przesylka_kurierska.Price
        };

        public static List<Order> Orders = new List<Order>()
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
