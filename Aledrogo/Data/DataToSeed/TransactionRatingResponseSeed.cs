using Aledrogo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aledrogo.Data.DataToSeed
{
    public static class TransactionRatingResponseSeed
    {
        public static List<TransactionRatingResponse> TransactionRatingResponses = new List<TransactionRatingResponse>()
        {
            new TransactionRatingResponse()
            {
                UserId = TransactionRatingSeed.telewizor_transaction_rating.SellerId,
                TransactionRating = TransactionRatingSeed.telewizor_transaction_rating,
                Response = "Za zaistniałą sytuację przepraszamy. Wszyscy nasi pracownicy mieli urlop przez tydzień. Jeśli nadal jest Pan zainteresowany to możemy wymienić pilot na nowy."
            },

            new TransactionRatingResponse()
            {
                UserId = TransactionRatingSeed.powerbank_transaction_rating.Seller.Id,
                TransactionRating = TransactionRatingSeed.powerbank_transaction_rating,
                Response = "Sprzedaliśmy już ponad 100 powerbanków tego typu i jest Pan pierwszym klientem, u którego wystąpił opisany przez Pana problem. Niestety nie podjął Pan z nami żadnej próby kontatku, a szkoda bo mogliśmy wymienić Panu powerbank."
            },

            new TransactionRatingResponse()
            {
                UserId = TransactionRatingSeed.powerbank_transaction_rating.Order.CustomerId,
                TransactionRating = TransactionRatingSeed.powerbank_transaction_rating,
                Response = "Wymienic? Po co na kolejny co nie działa. Zapłaciłem za działający towar i taki chciałem dostać, nie dostałem więc stąd moja opinia na temat Waszego produktu!."
            }
        };
    }
}
