using Aledrogo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aledrogo.Data.DataToSeed
{
    public static class DeliveryMethodTypeSeed
    {
        public static DeliveryMethodType kurier = new DeliveryMethodType() { Name = "Przesyłka kurierska" };
        public static DeliveryMethodType paczka = new DeliveryMethodType() { Name = "Paczkomaty 24/7" };
        public static DeliveryMethodType paczkomat = new DeliveryMethodType() { Name = "List ekonomiczny" };
        public static DeliveryMethodType odbior_osobisty = new DeliveryMethodType() { Name = "List priorytetowy" };
        public static DeliveryMethodType list = new DeliveryMethodType() { Name = "List polecony priorytetowy" };
        public static DeliveryMethodType przesylka_elektroniczna = new DeliveryMethodType() { Name = "Paczka pocztowa ekonomiczna" };

        public static List<DeliveryMethodType> DeliveryMethodTypes = new List<DeliveryMethodType>()
        {
            kurier, paczka, paczkomat, odbior_osobisty, list,
            przesylka_elektroniczna
        };
    }
}
