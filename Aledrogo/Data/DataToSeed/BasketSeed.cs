using Aledrogo.Models;
using System.Collections.Generic;

namespace Aledrogo.Data.DataToSeed
{
    public static class BasketSeed
    {
        public static List<Basket> Baskets = new List<Basket>()
        {
            new Basket() { UserId = UserSeed.artur.Id, Product = ProductSeed.arduino, Quantity = 2 },
            new Basket() { UserId = UserSeed.artur.Id, Product = ProductSeed.telefon_xiaomi, Quantity = 1 },
            new Basket() { UserId = UserSeed.artur.Id, Product = ProductSeed.powerbank, Quantity = 4 },
            new Basket() { UserId = UserSeed.artur.Id, Product = ProductSeed.ladowarka, Quantity = 1 },

            new Basket() { UserId = UserSeed.krzysztof.Id, Product = ProductSeed.konsola_ps4, Quantity = 2 },
            new Basket() { UserId = UserSeed.krzysztof.Id, Product = ProductSeed.pralka, Quantity = 1 },
            new Basket() { UserId = UserSeed.krzysztof.Id, Product = ProductSeed.etui, Quantity = 1 },
            new Basket() { UserId = UserSeed.krzysztof.Id, Product = ProductSeed.komputer_nowy, Quantity = 4 },

            new Basket() { UserId = UserSeed.test1.Id, Product = ProductSeed.laptop_uzywany, Quantity = 1 },
            new Basket() { UserId = UserSeed.test1.Id, Product = ProductSeed.etui, Quantity = 3 },

            new Basket() { UserId = UserSeed.test2.Id, Product = ProductSeed.komputer_nowy, Quantity = 1 },
            new Basket() { UserId = UserSeed.test2.Id, Product = ProductSeed.arduino, Quantity = 15 },

            new Basket() { UserId = UserSeed.test3.Id, Product = ProductSeed.pralka, Quantity = 1 },
            new Basket() { UserId = UserSeed.test3.Id, Product = ProductSeed.telewizor, Quantity = 1 },
            new Basket() { UserId = UserSeed.test3.Id, Product = ProductSeed.ladowarka, Quantity = 5 }

        };
    }
}
