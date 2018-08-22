using Aledrogo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aledrogo.Data.DataToSeed
{
    public static class OfferSeed
    {
        public static List<Offer> Offers = new List<Offer>()
        {
            new Offer() {  BidderId = UserSeed.test1.Id, Product = ProductSeed.telefon_xiaomi, Value = 200 },
            new Offer() {  BidderId = UserSeed.test2.Id, Product = ProductSeed.telefon_xiaomi, Value = 300 },
            new Offer() {  BidderId = UserSeed.test2.Id, Product = ProductSeed.telefon_xiaomi, Value = 420 },
            new Offer() {  BidderId = UserSeed.test3.Id, Product = ProductSeed.telefon_xiaomi, Value = 550 },
            new Offer() {  BidderId = UserSeed.artur.Id, Product = ProductSeed.telefon_xiaomi, Value = 800 },

            new Offer() {  BidderId = UserSeed.artur.Id, Product = ProductSeed.laptop_uzywany, Value = 100 },
            new Offer() {  BidderId = UserSeed.test2.Id, Product = ProductSeed.laptop_uzywany, Value = 300 },
            new Offer() {  BidderId = UserSeed.artur.Id, Product = ProductSeed.laptop_uzywany, Value = 500 },
            new Offer() {  BidderId = UserSeed.test3.Id, Product = ProductSeed.laptop_uzywany, Value = 600 },
            new Offer() {  BidderId = UserSeed.test2.Id, Product = ProductSeed.laptop_uzywany, Value = 900 },
            new Offer() {  BidderId = UserSeed.test1.Id, Product = ProductSeed.laptop_uzywany, Value = 1200 },

            new Offer() {  BidderId = UserSeed.krzysztof.Id, Product = ProductSeed.telewizor, Value = 500 },
            new Offer() {  BidderId = UserSeed.test1.Id, Product = ProductSeed.telewizor, Value = 550 },
            new Offer() {  BidderId = UserSeed.krzysztof.Id, Product = ProductSeed.telewizor, Value = 600 },
            new Offer() {  BidderId = UserSeed.artur.Id, Product = ProductSeed.telewizor, Value = 650 },
            new Offer() {  BidderId = UserSeed.test3.Id, Product = ProductSeed.telewizor, Value = 680 },
            new Offer() {  BidderId = UserSeed.artur.Id, Product = ProductSeed.telewizor, Value = 750 },
            new Offer() {  BidderId = UserSeed.test2.Id, Product = ProductSeed.telewizor, Value = 800 },
            new Offer() {  BidderId = UserSeed.test3.Id, Product = ProductSeed.telewizor, Value = 980 }
        };
    }
}
