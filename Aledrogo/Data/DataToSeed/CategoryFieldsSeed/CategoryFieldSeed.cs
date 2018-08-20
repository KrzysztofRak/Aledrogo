using Aledrogo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aledrogo.Data.DataToSeed
{
    public static class CategoryFieldSeed
    {
        private static CategoryField Create(Category _category, string _fieldName, int? _minNumber = null, int? _maxNumber = null)
        {
            return new CategoryField()
            {
                Category = _category,
                Name = _fieldName,
                CustomNumericValueAllowed = !(_minNumber != null || _maxNumber != null),
                MinNumber = _maxNumber,
                MaxNumber = _maxNumber
            };
        }

        public static CategoryField klasa_energetyczna = Create(CategorySeed.rtv_i_agd, "Klasa energetyczna");

        public static CategoryField typ = Create(CategorySeed.komputery, "Typ");
        public static CategoryField liczba_rdzeni = Create(CategorySeed.komputery, "Liczba rdzeni", 0, 64);
        public static CategoryField pamiec_ram = Create(CategorySeed.komputery, "Pamięć RAM [MB]", 0, 1000000);
        public static CategoryField pojemnosc_dysku = Create(CategorySeed.komputery, "Pojemność dysku [GB]", 0, 100000);

        public static CategoryField maksymalne_obroty = Create(CategorySeed.pralki, "Maksymalne obroty", 0, 2000);
        public static CategoryField ladownosc = Create(CategorySeed.pralki, "Ładowność [kg]", 0, 50);
        public static CategoryField wyswietlacz = Create(CategorySeed.pralki, "Wyświetlacz");

        public static CategoryField kolor = Create(CategorySeed.telefony_i_akcesoria, "Kolor");

        public static CategoryField interfejs = Create(CategorySeed.xiaomi, "Interfejs");

        public static List<CategoryField> CategoryFields { get; } = new List<CategoryField>()
        {
            klasa_energetyczna,
            typ, liczba_rdzeni, pamiec_ram, pojemnosc_dysku,
            maksymalne_obroty, ladownosc, wyswietlacz,
            kolor,
            interfejs
        };
    }
}
