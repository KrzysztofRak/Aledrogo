using Aledrogo.Models;
using System.Collections.Generic;

namespace Aledrogo.Data.DataToSeed
{
    public static class Product_SpecificFieldValueSeed
    {
        public static List<Product_SpecificFieldValue> Products_SpecificFieldValues { get; } = new List<Product_SpecificFieldValue>()
        {
          new Product_SpecificFieldValue() { Product = ProductSeed.komputer_nowy, SpecificFieldValue = SpecificFieldValueSeed.klasa_energetyczna_niedotyczy },
          new Product_SpecificFieldValue() { Product = ProductSeed.komputer_nowy, SpecificFieldValue = SpecificFieldValueSeed.liczba_rdzeni_8},
          new Product_SpecificFieldValue() { Product = ProductSeed.komputer_nowy, SpecificFieldValue = SpecificFieldValueSeed.pamiec_ram_16gb },
          new Product_SpecificFieldValue() { Product = ProductSeed.komputer_nowy, SpecificFieldValue = SpecificFieldValueSeed.pojemnosc_dysku_2000gb },
          new Product_SpecificFieldValue() { Product = ProductSeed.komputer_nowy, SpecificFieldValue = SpecificFieldValueSeed.rodzaj_dysku_hdd },

          new Product_SpecificFieldValue() { Product = ProductSeed.komputer_uzywany, SpecificFieldValue = SpecificFieldValueSeed.klasa_energetyczna_niedotyczy },
          new Product_SpecificFieldValue() { Product = ProductSeed.komputer_uzywany, SpecificFieldValue = SpecificFieldValueSeed.liczba_rdzeni_4 },
          new Product_SpecificFieldValue() { Product = ProductSeed.komputer_uzywany, SpecificFieldValue = SpecificFieldValueSeed.pamiec_ram_8gb },
          new Product_SpecificFieldValue() { Product = ProductSeed.komputer_uzywany, SpecificFieldValue = SpecificFieldValueSeed.pojemnosc_dysku_256gb },
          new Product_SpecificFieldValue() { Product = ProductSeed.komputer_uzywany, SpecificFieldValue = SpecificFieldValueSeed.rodzaj_dysku_ssd },

          new Product_SpecificFieldValue() { Product = ProductSeed.konsola_ps4, SpecificFieldValue = SpecificFieldValueSeed.klasa_energetyczna_niedotyczy },

          new Product_SpecificFieldValue() { Product = ProductSeed.pralka, SpecificFieldValue = SpecificFieldValueSeed.maksymalne_obroty_1400 },
          new Product_SpecificFieldValue() { Product = ProductSeed.pralka, SpecificFieldValue = SpecificFieldValueSeed.ladownosc_8kg },
          new Product_SpecificFieldValue() { Product = ProductSeed.pralka, SpecificFieldValue = SpecificFieldValueSeed.wyswietlacz_led },

          new Product_SpecificFieldValue() { Product = ProductSeed.telefon_xiaomi, SpecificFieldValue = SpecificFieldValueSeed.kolor_czarny },
          new Product_SpecificFieldValue() { Product = ProductSeed.telefon_xiaomi, SpecificFieldValue = SpecificFieldValueSeed.interfejs_miui_9 },

          new Product_SpecificFieldValue() { Product = ProductSeed.ladowarka, SpecificFieldValue = SpecificFieldValueSeed.kolor_pomaranczowy },

          new Product_SpecificFieldValue() { Product = ProductSeed.powerbank, SpecificFieldValue = SpecificFieldValueSeed.kolor_bialy },

          new Product_SpecificFieldValue() { Product = ProductSeed.etui, SpecificFieldValue = SpecificFieldValueSeed.kolor_inny },

          new Product_SpecificFieldValue() { Product = ProductSeed.telewizor, SpecificFieldValue = SpecificFieldValueSeed.klasa_energetyczna_a }
        };

    }
}
