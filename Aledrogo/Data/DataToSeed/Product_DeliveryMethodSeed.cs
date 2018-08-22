using Aledrogo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aledrogo.Data.DataToSeed
{
    public static class Product_DeliveryMethodSeed
    {
            public static Product_DeliveryMethod telefon_xiaomi_przesylka_kurierska = new Product_DeliveryMethod() { Product = ProductSeed.telefon_xiaomi, DeliveryMethod = DeliveryMethodSeed.przesylka_kurierska, Price = 18.00m };
            public static Product_DeliveryMethod telefon_xiaomi_paczkomaty = new Product_DeliveryMethod() { Product = ProductSeed.telefon_xiaomi, DeliveryMethod = DeliveryMethodSeed.paczkomaty };
            public static Product_DeliveryMethod telefon_xiaomi_paczka_pocztowa_ekonomiczna = new Product_DeliveryMethod() { Product = ProductSeed.telefon_xiaomi, DeliveryMethod = DeliveryMethodSeed.paczka_pocztowa_ekonomiczna, Price = 14.00m };
            public static Product_DeliveryMethod telefon_xiaomi_odbior_osobisty_po_przedplacie = new Product_DeliveryMethod() { Product = ProductSeed.telefon_xiaomi, DeliveryMethod = DeliveryMethodSeed.odbior_osobisty_po_przedplacie };
            public static Product_DeliveryMethod telefon_xiaomi_list_polecony_priorytetowy = new Product_DeliveryMethod() { Product = ProductSeed.telefon_xiaomi, DeliveryMethod = DeliveryMethodSeed.list_polecony_priorytetowy, Price = 8.60m };
            public static Product_DeliveryMethod telefon_xiaomi_list_ekonomiczny = new Product_DeliveryMethod() { Product = ProductSeed.telefon_xiaomi, DeliveryMethod = DeliveryMethodSeed.list_ekonomiczny, Price = 4.00m };
            public static Product_DeliveryMethod telefon_xiaomi_list_priorytetowy = new Product_DeliveryMethod() { Product = ProductSeed.telefon_xiaomi, DeliveryMethod = DeliveryMethodSeed.list_priorytetowy, Price = 6.50m };

            public static Product_DeliveryMethod arduino_paczkomaty = new Product_DeliveryMethod() { Product = ProductSeed.arduino, DeliveryMethod = DeliveryMethodSeed.paczkomaty };
            public static Product_DeliveryMethod arduino_list_ekonomiczny = new Product_DeliveryMethod() { Product = ProductSeed.arduino, DeliveryMethod = DeliveryMethodSeed.list_ekonomiczny, Price = 3.20m };
            public static Product_DeliveryMethod arduino_przesylka_kurierska = new Product_DeliveryMethod() { Product = ProductSeed.arduino, DeliveryMethod = DeliveryMethodSeed.przesylka_kurierska, Price = 18.00m };
            public static Product_DeliveryMethod arduino_list_polecony_priorytetowy = new Product_DeliveryMethod() { Product = ProductSeed.arduino, DeliveryMethod = DeliveryMethodSeed.list_polecony_priorytetowy, Price = 7.00m };
            public static Product_DeliveryMethod arduino_list_priorytetowy = new Product_DeliveryMethod() { Product = ProductSeed.arduino, DeliveryMethod = DeliveryMethodSeed.list_priorytetowy, Price = 4.00m };
            public static Product_DeliveryMethod arduino_odbior_osobisty_po_przedplacie = new Product_DeliveryMethod() { Product = ProductSeed.arduino, DeliveryMethod = DeliveryMethodSeed.odbior_osobisty_po_przedplacie };

            public static Product_DeliveryMethod komputer_nowy_przesylka_kurierska = new Product_DeliveryMethod() { Product = ProductSeed.komputer_nowy, DeliveryMethod = DeliveryMethodSeed.przesylka_kurierska, Price = 0.00m };
            public static Product_DeliveryMethod komputer_nowy_paczka_pocztowa_ekonomiczna = new Product_DeliveryMethod() { Product = ProductSeed.komputer_nowy, DeliveryMethod = DeliveryMethodSeed.paczka_pocztowa_ekonomiczna, Price = 0.00m };
            public static Product_DeliveryMethod komputer_nowy_paczkomaty = new Product_DeliveryMethod() { Product = ProductSeed.komputer_nowy, DeliveryMethod = DeliveryMethodSeed.paczkomaty };
            public static Product_DeliveryMethod komputer_nowy_odbior_osobisty_po_przedplacie = new Product_DeliveryMethod() { Product = ProductSeed.komputer_nowy, DeliveryMethod = DeliveryMethodSeed.odbior_osobisty_po_przedplacie };

            public static Product_DeliveryMethod powerbank_list_ekonomiczny = new Product_DeliveryMethod() { Product = ProductSeed.powerbank, DeliveryMethod = DeliveryMethodSeed.list_ekonomiczny, Price = 3.00m };
            public static Product_DeliveryMethod powerbank_list_polecony_priorytetowy = new Product_DeliveryMethod() { Product = ProductSeed.powerbank, DeliveryMethod = DeliveryMethodSeed.list_polecony_priorytetowy, Price = 7.00m };
            public static Product_DeliveryMethod powerbank_list_priorytetowy = new Product_DeliveryMethod() { Product = ProductSeed.powerbank, DeliveryMethod = DeliveryMethodSeed.list_priorytetowy, Price = 5.00m };
            public static Product_DeliveryMethod powerbank_paczkomaty = new Product_DeliveryMethod() { Product = ProductSeed.powerbank, DeliveryMethod = DeliveryMethodSeed.paczkomaty };

            public static Product_DeliveryMethod laptop_uzywany_przesylka_kurierska = new Product_DeliveryMethod() { Product = ProductSeed.laptop_uzywany, DeliveryMethod = DeliveryMethodSeed.przesylka_kurierska, Price = 18.00m };
            public static Product_DeliveryMethod laptop_uzywany_paczka_pocztowa_ekonomiczna = new Product_DeliveryMethod() { Product = ProductSeed.laptop_uzywany, DeliveryMethod = DeliveryMethodSeed.paczka_pocztowa_ekonomiczna, Price = 18.00m };
            public static Product_DeliveryMethod laptop_uzywany_paczkomaty = new Product_DeliveryMethod() { Product = ProductSeed.laptop_uzywany, DeliveryMethod = DeliveryMethodSeed.paczkomaty };

            public static Product_DeliveryMethod etui_list_polecony_priorytetowy = new Product_DeliveryMethod() { Product = ProductSeed.etui, DeliveryMethod = DeliveryMethodSeed.list_polecony_priorytetowy, Price = 7.50m };
            public static Product_DeliveryMethod etui_list_priorytetowy = new Product_DeliveryMethod() { Product = ProductSeed.etui, DeliveryMethod = DeliveryMethodSeed.list_priorytetowy, Price = 4.50m };
            public static Product_DeliveryMethod etui_paczkomaty = new Product_DeliveryMethod() { Product = ProductSeed.etui, DeliveryMethod = DeliveryMethodSeed.paczkomaty };

            public static Product_DeliveryMethod pralka_przesylka_kurierska = new Product_DeliveryMethod() { Product = ProductSeed.pralka, DeliveryMethod = DeliveryMethodSeed.przesylka_kurierska, Price = 50.00m };
            public static Product_DeliveryMethod pralka_paczka_pocztowa_ekonomiczna = new Product_DeliveryMethod() { Product = ProductSeed.pralka, DeliveryMethod = DeliveryMethodSeed.paczka_pocztowa_ekonomiczna, Price = 45.00m };

            public static Product_DeliveryMethod ladowarka_list_polecony_priorytetowy = new Product_DeliveryMethod() { Product = ProductSeed.ladowarka, DeliveryMethod = DeliveryMethodSeed.list_polecony_priorytetowy, Price = 6.80m };
            public static Product_DeliveryMethod ladowarka_paczkomaty = new Product_DeliveryMethod() { Product = ProductSeed.ladowarka, DeliveryMethod = DeliveryMethodSeed.paczkomaty };

            public static Product_DeliveryMethod telewizor_paczka_pocztowa_ekonomiczna = new Product_DeliveryMethod() { Product = ProductSeed.telewizor, DeliveryMethod = DeliveryMethodSeed.paczka_pocztowa_ekonomiczna, Price = 22.00m };

            public static Product_DeliveryMethod konsola_ps4_przesylka_kurierska = new Product_DeliveryMethod() { Product = ProductSeed.konsola_ps4, DeliveryMethod = DeliveryMethodSeed.przesylka_kurierska, Price = 13.90m };

        public static List<Product_DeliveryMethod> Products_DeliveryMethods = new List<Product_DeliveryMethod>()
        {

        };
    }
}
