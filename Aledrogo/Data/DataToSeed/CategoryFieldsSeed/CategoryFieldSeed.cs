using Aledrogo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aledrogo.Data.DataToSeed
{
    public static class CategoryFieldSeed
    {
        private static SpecificField Create(Category _category, string _fieldName, int? _minNumber = null, int? _maxNumber = null)
        {
            return new SpecificField()
            {
                Category = _category,
                Name = _fieldName,
                IsCustomNumericValue = !(_minNumber != null || _maxNumber != null),
                MinNumericValue = _maxNumber,
                MaxNumericValue = _maxNumber
            };
        }

        public static SpecificField klasa_energetyczna = Create(CategorySeed.rtv_i_agd, "Klasa energetyczna");

        public static SpecificField typ = Create(CategorySeed.komputery, "Typ");
        public static SpecificField liczba_rdzeni = Create(CategorySeed.komputery, "Liczba rdzeni", 0, 64);
        public static SpecificField pamiec_ram = Create(CategorySeed.komputery, "Pamięć RAM [MB]", 0, 1000000);
        public static SpecificField pojemnosc_dysku = Create(CategorySeed.komputery, "Pojemność dysku [GB]", 0, 100000);

        public static SpecificField maksymalne_obroty = Create(CategorySeed.pralki, "Maksymalne obroty", 0, 2000);
        public static SpecificField ladownosc = Create(CategorySeed.pralki, "Ładowność [kg]", 0, 50);
        public static SpecificField wyswietlacz = Create(CategorySeed.pralki, "Wyświetlacz");

        public static SpecificField kolor = Create(CategorySeed.telefony_i_akcesoria, "Kolor");

        public static SpecificField interfejs = Create(CategorySeed.xiaomi, "Interfejs");

        public static List<SpecificField> CategoryFields { get; } = new List<SpecificField>()
        {
            klasa_energetyczna,
            typ, liczba_rdzeni, pamiec_ram, pojemnosc_dysku,
            maksymalne_obroty, ladownosc, wyswietlacz,
            kolor,
            interfejs
        };
    }
}
