using Aledrogo.Models;
using System.Collections.Generic;

namespace Aledrogo.Data.DataToSeed
{
    public class ProductStateSeed : IDataToSeed
    {
        public static ProductState nowy = new ProductState() { Name = "Nowy" };
        public static ProductState uzywany = new ProductState() { Name = "Używany" };
        public static ProductState po_zwrocie = new ProductState() { Name = "Po zwrocie" };
        public static ProductState powystawowy = new ProductState() { Name = "Powystawowy" };
        public static ProductState uszkodzony = new ProductState() { Name = "Uszkodzony" };
        public static ProductState odnowiony_przez_sprzedawce = new ProductState() { Name = "Odnowiony przez sprzedawce" };
        public static ProductState odnowiony_przez_producenta = new ProductState() { Name = "Odnowiony przez producenta" };

        public IEnumerable<object> Items { get; } = new List<ProductState>()
        {
            nowy, uzywany, po_zwrocie, powystawowy, uszkodzony, odnowiony_przez_producenta, odnowiony_przez_sprzedawce
        };
}
}
