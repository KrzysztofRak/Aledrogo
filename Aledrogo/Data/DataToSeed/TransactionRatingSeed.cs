using Aledrogo.Models;
using System.Collections.Generic;

namespace Aledrogo.Data.DataToSeed
{
    public class TransactionRatingSeed : IDataToSeed
    {
        public static TransactionRating telefon_xiaomi_transaction_rating = new TransactionRating()
        {
            SellerId = UserSeed.test1.Id,
            Product = ProductSeed.telefon_xiaomi,
            Order = OrderSeed.telefon_xiaomi_artur_order,
            IsPositive = true,
            CompatibilityWithDescriptionRating = 5,
            ShippingTimeRating = 5,
            ShippingCostRating = 5,
            CustomerServiceRating = 5,
            Comment = "Wszystko zgodnie z opisem. Polecam!"
        };

        public static TransactionRating telewizor_transaction_rating = new TransactionRating()
        {
            SellerId = UserSeed.artur.Id,
            Product = ProductSeed.telewizor,
            Order = OrderSeed.telewizor_test3_order,
            IsPositive = true,
            CompatibilityWithDescriptionRating = 4,
            ShippingTimeRating = 5,
            ShippingCostRating = 4,
            CustomerServiceRating = 3,
            Comment = "Pilot od telewizora posiada ślady użytkownia, sprzedający odpisał na moją wiaodmość dopiero po tygodniu. Pozatym wszystko ok."
        };

        public static TransactionRating powerbank_transaction_rating = new TransactionRating()
        {
            SellerId = UserSeed.test2.Id,
            Product = ProductSeed.powerbank,
            Order = OrderSeed.powerbank_krzysztof_order,
            IsPositive = false,
            CompatibilityWithDescriptionRating = 1,
            ShippingTimeRating = 5,
            ShippingCostRating = 3,
            CustomerServiceRating = 5,
            Comment = "NIE POLECAM! Powerbank rozładowuje się po chwili po całym dniu ładowania... do tego bardzo się nagrzewa przy ładowaniu. Odradzam zakup."
        };

        public IEnumerable<object> Items { get; } = new List<TransactionRating>()
        {
            telefon_xiaomi_transaction_rating,
            telefon_xiaomi_transaction_rating,
            powerbank_transaction_rating
        };
    }
}
