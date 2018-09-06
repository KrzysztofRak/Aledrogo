using Aledrogo.Models;
using System.Collections.Generic;

namespace Aledrogo.Data.DataToSeed
{
    public class SpecificFieldSeed : IDataToSeed
    {
        private static SpecificField Create(Category _category, string _name, bool _isRequired, int? _minNumericValue = null, int? _maxNumericValue = null)
        {
            return new SpecificField()
            {
                Category = _category,
                Name = _name,
                IsRequired = _isRequired,
                IsRangeValue = (_minNumericValue != null || _maxNumericValue != null),
                MinNumericValue = _minNumericValue,
                MaxNumericValue = _maxNumericValue
            };
        }

        public static SpecificField klasa_energetyczna = Create(CategorySeed.rtv_i_agd, "Klasa energetyczna", true);

        public static SpecificField liczba_rdzeni = Create(CategorySeed.komputery, "Liczba rdzeni", true, 0, 64);
        public static SpecificField pamiec_ram = Create(CategorySeed.komputery, "Pamięć RAM [GB]", true, 0, 1000);
        public static SpecificField pojemnosc_dysku = Create(CategorySeed.komputery, "Pojemność dysku [GB]", true, 0, 100000);
        public static SpecificField rodzaj_dysku = Create(CategorySeed.komputery, "Rodzaj dysku", false);

        public static SpecificField maksymalne_obroty = Create(CategorySeed.pralki, "Maksymalne obroty", true, 0, 2000);
        public static SpecificField ladownosc = Create(CategorySeed.pralki, "Ładowność [kg]", true, 0, 50);
        public static SpecificField wyswietlacz = Create(CategorySeed.pralki, "Wyświetlacz", true);

        public static SpecificField kolor = Create(CategorySeed.telefony_i_akcesoria, "Kolor", true);

        public static SpecificField interfejs = Create(CategorySeed.xiaomi, "Interfejs", true);
        public static SpecificField ilosc_kolorow = Create(CategorySeed.xiaomi, "Ilość kolorów", true);

        public IEnumerable<object> Items { get; } = new List<SpecificField>()
        {
            klasa_energetyczna,
            rodzaj_dysku, liczba_rdzeni, pamiec_ram, pojemnosc_dysku,
            maksymalne_obroty, ladownosc, wyswietlacz,
            kolor,
            interfejs
        };
    }
}
