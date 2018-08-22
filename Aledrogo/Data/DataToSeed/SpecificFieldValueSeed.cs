using Aledrogo.Models;
using System.Collections.Generic;

namespace Aledrogo.Data.DataToSeed
{
    public class SpecificFieldValueSeed
    {
        private static SpecificFieldValue Create(SpecificField _specificField, string _value)
        {
            return new SpecificFieldValue() { SpecificField = _specificField, Value = _value };
        }

        public static SpecificFieldValue klasa_energetyczna_a = Create(SpecificFieldSeed.klasa_energetyczna, "A");
        public static SpecificFieldValue klasa_energetyczna_b = Create(SpecificFieldSeed.klasa_energetyczna, "B");
        public static SpecificFieldValue klasa_energetyczna_c = Create(SpecificFieldSeed.klasa_energetyczna, "C");
        public static SpecificFieldValue klasa_energetyczna_niedotyczy = Create(SpecificFieldSeed.klasa_energetyczna, "Nie dotyczy");

        public static SpecificFieldValue liczba_rdzeni_4 = Create(SpecificFieldSeed.liczba_rdzeni, "4");
        public static SpecificFieldValue liczba_rdzeni_8 = Create(SpecificFieldSeed.liczba_rdzeni, "8");
        public static SpecificFieldValue pamiec_ram_8gb = Create(SpecificFieldSeed.pamiec_ram, "8");
        public static SpecificFieldValue pamiec_ram_16gb = Create(SpecificFieldSeed.pamiec_ram, "16");
        public static SpecificFieldValue pojemnosc_dysku_256gb = Create(SpecificFieldSeed.pojemnosc_dysku, "256");
        public static SpecificFieldValue pojemnosc_dysku_2000gb = Create(SpecificFieldSeed.pojemnosc_dysku, "2000");
        public static SpecificFieldValue rodzaj_dysku_ssd = Create(SpecificFieldSeed.rodzaj_dysku, "SSD");
        public static SpecificFieldValue rodzaj_dysku_hdd = Create(SpecificFieldSeed.rodzaj_dysku, "HDD");

        public static SpecificFieldValue maksymalne_obroty_1400 = Create(SpecificFieldSeed.maksymalne_obroty, "1400");
        public static SpecificFieldValue ladownosc_8kg = Create(SpecificFieldSeed.ladownosc, "8");
        public static SpecificFieldValue wyswietlacz_led = Create(SpecificFieldSeed.wyswietlacz, "LED");
        public static SpecificFieldValue wyswietlacz_segmentowy = Create(SpecificFieldSeed.wyswietlacz, "Segmentowy");
        public static SpecificFieldValue wyswietlacz_inny = Create(SpecificFieldSeed.wyswietlacz, "Inny");

        public static SpecificFieldValue kolor_bialy = Create(SpecificFieldSeed.kolor, "Biały");
        public static SpecificFieldValue kolor_szary = Create(SpecificFieldSeed.kolor, "Szary");
        public static SpecificFieldValue kolor_czarny = Create(SpecificFieldSeed.kolor, "Czarny");
        public static SpecificFieldValue kolor_czerwony = Create(SpecificFieldSeed.kolor, "Czerwony");
        public static SpecificFieldValue kolor_niebieski = Create(SpecificFieldSeed.kolor, "Niebieski");
        public static SpecificFieldValue kolor_zolty = Create(SpecificFieldSeed.kolor, "Żółty");
        public static SpecificFieldValue kolor_zielony = Create(SpecificFieldSeed.kolor, "Zielony");
        public static SpecificFieldValue kolor_rozowy = Create(SpecificFieldSeed.kolor, "Różowy");
        public static SpecificFieldValue kolor_pomaranczowy = Create(SpecificFieldSeed.kolor, "Pomarańczowy");
        public static SpecificFieldValue kolor_fioletowy = Create(SpecificFieldSeed.kolor, "Fioletowy");
        public static SpecificFieldValue kolor_bezbarwny = Create(SpecificFieldSeed.kolor, "Bezbarwny");
        public static SpecificFieldValue kolor_inny = Create(SpecificFieldSeed.kolor, "Inny");

        public static SpecificFieldValue interfejs_miui_7 = Create(SpecificFieldSeed.interfejs, "MIUI 7");
        public static SpecificFieldValue interfejs_miui_8 = Create(SpecificFieldSeed.interfejs, "MIUI 8");
        public static SpecificFieldValue interfejs_miui_9 = Create(SpecificFieldSeed.interfejs, "MIUI 9");

        public static List<SpecificFieldValue> SpecificFieldsValues = new List<SpecificFieldValue>()
        {
            klasa_energetyczna_a, klasa_energetyczna_b, klasa_energetyczna_c,
            liczba_rdzeni_4, liczba_rdzeni_8, pamiec_ram_8gb, pamiec_ram_16gb,
            pojemnosc_dysku_256gb, pojemnosc_dysku_2000gb,
            rodzaj_dysku_ssd, rodzaj_dysku_hdd,
            maksymalne_obroty_1400, ladownosc_8kg,
            wyswietlacz_led, wyswietlacz_segmentowy, wyswietlacz_inny,
            kolor_bialy, kolor_szary, kolor_czarny, kolor_czerwony, kolor_niebieski, kolor_zolty, kolor_zielony, kolor_rozowy, kolor_pomaranczowy, kolor_fioletowy, kolor_bezbarwny, kolor_inny,
            interfejs_miui_7, interfejs_miui_8, interfejs_miui_9
        };
    }
}
