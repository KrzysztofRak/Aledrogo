using Aledrogo.Models;
using System.Collections.Generic;

namespace Aledrogo.Data.DataToSeed
{
    public class DeliveryMethodTypeSeed : IDataToSeed
    {
        public static DeliveryMethodType kurier = new DeliveryMethodType() { Name = "Przesyłka kurierska" };
        public static DeliveryMethodType paczka = new DeliveryMethodType() { Name = "Paczkomaty 24/7" };
        public static DeliveryMethodType paczkomat = new DeliveryMethodType() { Name = "List ekonomiczny" };
        public static DeliveryMethodType odbior_osobisty = new DeliveryMethodType() { Name = "List priorytetowy" };
        public static DeliveryMethodType list = new DeliveryMethodType() { Name = "List polecony priorytetowy" };
        public static DeliveryMethodType przesylka_elektroniczna = new DeliveryMethodType() { Name = "Paczka pocztowa ekonomiczna" };

        public IEnumerable<object> Items { get; } = new List<DeliveryMethodType>()
        {
            kurier, paczka, paczkomat, odbior_osobisty, list,
            przesylka_elektroniczna
        };
    }
}
