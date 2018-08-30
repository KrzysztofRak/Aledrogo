using Aledrogo.Models;
using System;
using System.Collections.Generic;

namespace Aledrogo.Data.DataToSeed
{
    public class OfferSeed : IDataToSeed
    {
        public IEnumerable<object> Items { get; } = new List<Offer>()
        {
            new Offer() {  BidderId = UserSeed.test1.Id, Product = ProductSeed.telefon_xiaomi, Value = 200, DateOfSubmission = DateTime.UtcNow },
            new Offer() {  BidderId = UserSeed.test2.Id, Product = ProductSeed.telefon_xiaomi, Value = 300, DateOfSubmission = DateTime.UtcNow.AddHours(1) },
            new Offer() {  BidderId = UserSeed.test2.Id, Product = ProductSeed.telefon_xiaomi, Value = 320, DateOfSubmission = DateTime.UtcNow.AddHours(5) },
            new Offer() {  BidderId = UserSeed.test3.Id, Product = ProductSeed.telefon_xiaomi, Value = 430, DateOfSubmission = DateTime.UtcNow.AddHours(13) },
            new Offer() {  BidderId = UserSeed.artur.Id, Product = ProductSeed.telefon_xiaomi, Value = 500, DateOfSubmission = DateTime.UtcNow.AddHours(26) },

            new Offer() {  BidderId = UserSeed.artur.Id, Product = ProductSeed.laptop_uzywany, Value = 300, DateOfSubmission = DateTime.UtcNow },
            new Offer() {  BidderId = UserSeed.test2.Id, Product = ProductSeed.laptop_uzywany, Value = 450, DateOfSubmission = DateTime.UtcNow.AddHours(2) },
            new Offer() {  BidderId = UserSeed.artur.Id, Product = ProductSeed.laptop_uzywany, Value = 500, DateOfSubmission = DateTime.UtcNow.AddHours(4) },
            new Offer() {  BidderId = UserSeed.test3.Id, Product = ProductSeed.laptop_uzywany, Value = 600, DateOfSubmission = DateTime.UtcNow.AddHours(6) },
            new Offer() {  BidderId = UserSeed.test2.Id, Product = ProductSeed.laptop_uzywany, Value = 900, DateOfSubmission = DateTime.UtcNow.AddHours(9) },
            new Offer() {  BidderId = UserSeed.test1.Id, Product = ProductSeed.laptop_uzywany, Value = 1200, DateOfSubmission = DateTime.UtcNow.AddHours(14) },

            new Offer() {  BidderId = UserSeed.krzysztof.Id, Product = ProductSeed.telewizor, Value = 500, DateOfSubmission = DateTime.UtcNow },
            new Offer() {  BidderId = UserSeed.test1.Id, Product = ProductSeed.telewizor, Value = 550, DateOfSubmission = DateTime.UtcNow.AddHours(5) },
            new Offer() {  BidderId = UserSeed.krzysztof.Id, Product = ProductSeed.telewizor, Value = 600, DateOfSubmission = DateTime.UtcNow.AddHours(7) },
            new Offer() {  BidderId = UserSeed.artur.Id, Product = ProductSeed.telewizor, Value = 650, DateOfSubmission = DateTime.UtcNow.AddHours(8) },
            new Offer() {  BidderId = UserSeed.test3.Id, Product = ProductSeed.telewizor, Value = 680, DateOfSubmission = DateTime.UtcNow.AddHours(10) },
            new Offer() {  BidderId = UserSeed.artur.Id, Product = ProductSeed.telewizor, Value = 750, DateOfSubmission = DateTime.UtcNow.AddHours(12) },
            new Offer() {  BidderId = UserSeed.test2.Id, Product = ProductSeed.telewizor, Value = 800, DateOfSubmission = DateTime.UtcNow.AddHours(13) },
            new Offer() {  BidderId = UserSeed.test3.Id, Product = ProductSeed.telewizor, Value = 980, DateOfSubmission = DateTime.UtcNow.AddHours(17) }
        };
    }
}
