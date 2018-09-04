using Aledrogo.Models;
using System.Collections.Generic;

namespace Aledrogo.Data.DataToSeed
{
    public class DeliveryMethodSeed : IDataToSeed
    {
        public static DeliveryMethod przesylka_kurierska = new DeliveryMethod() { Name = "Przesyłka kurierska" };
        public static DeliveryMethod paczkomaty = new DeliveryMethod() { Name = "Paczkomaty 24/7", Price = 8.70m };
        public static DeliveryMethod list_ekonomiczny = new DeliveryMethod() { Name = "List ekonomiczny", IsSafe = false };
        public static DeliveryMethod list_priorytetowy = new DeliveryMethod() { Name = "List priorytetowy", IsSafe = false };
        public static DeliveryMethod list_polecony_priorytetowy = new DeliveryMethod() { Name = "List polecony priorytetowy" };
        public static DeliveryMethod paczka_pocztowa_ekonomiczna = new DeliveryMethod() { Name = "Paczka pocztowa ekonomiczna" };
        public static DeliveryMethod odbior_osobisty_po_przedplacie = new DeliveryMethod() { Name = "Odbiór osobity po przedpłacie", Price = 0.00m };

        public IEnumerable<object> Items { get; } = new List<DeliveryMethod>()
        {
            przesylka_kurierska, paczkomaty, list_ekonomiczny, list_priorytetowy, list_polecony_priorytetowy,
            paczka_pocztowa_ekonomiczna, odbior_osobisty_po_przedplacie
        };
    }
}
