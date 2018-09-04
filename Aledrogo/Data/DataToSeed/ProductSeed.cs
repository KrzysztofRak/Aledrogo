using Aledrogo.Models;
using Aledrogo.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Aledrogo.Data.DataToSeed
{
    public class ProductSeed : IDataToSeed
    {
        private const string DESCRIPTION = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum.";

        public static Product komputer_nowy = new Product()
        {
            SellerId = UserSeed.artur.Id,
            Category = CategorySeed.komputery,
            Name = "Nowy komputer stacjonarny do gier",
            Description = DESCRIPTION,
            MinimalPrice = 0,
            Price = 1200,
            TypeOfOffer = TypeOfOffer.BUY_IT_NOW,
            DaysForReturn = 7,
            ProductState = ProductStateSeed.nowy,
            ItemsInStock = 20,
            ShippingTimeInWorkingDays = 1,
            EndDate = DateTime.UtcNow.AddDays(14)
        };

        public static Product laptop_uzywany = new Product()
        {
            SellerId = UserSeed.krzysztof.Id,
            Category = CategorySeed.komputery,
            Name = "Używany laptop DELL. Licytacja!",
            Description = DESCRIPTION,
            MinimalPrice = 300,
            Price = 0,
            TypeOfOffer = TypeOfOffer.AUCTION,
            DaysForReturn = 0,
            ProductState = ProductStateSeed.uzywany,
            ItemsInStock = 1,
            ShippingTimeInWorkingDays = 3,
            EndDate = DateTime.UtcNow.AddDays(7)
        };

        public static Product telefon_xiaomi = new Product()
        {
            SellerId = UserSeed.test1.Id,
            Category = CategorySeed.xiaomi,
            Name = "Xiaomi Redmi Note 4X",
            Description = DESCRIPTION,
            MinimalPrice = 350,
            Price = 500,
            TypeOfOffer = TypeOfOffer.AUCTION | TypeOfOffer.BUY_IT_NOW,
            DaysForReturn = 0,
            ProductState = ProductStateSeed.uzywany,
            ItemsInStock = 1,
            ShippingTimeInWorkingDays = 3,
            EndDate = DateTime.UtcNow.AddDays(7),
        };

        public static Product arduino = new Product()
        {
            SellerId = UserSeed.krzysztof.Id,
            Category = CategorySeed.elektronika,
            Name = "Arduino UNO - USZKODZONE - ATmega do wymiany",
            Description = DESCRIPTION,
            MinimalPrice = 0,
            Price = 50,
            TypeOfOffer = TypeOfOffer.BUY_IT_NOW,
            DaysForReturn = 0,
            ProductState = ProductStateSeed.uszkodzony,
            ItemsInStock = 30,
            ShippingTimeInWorkingDays = 3,
            EndDate = DateTime.UtcNow.AddDays(10)
        };

        public static Product pralka = new Product()
        {
            SellerId = UserSeed.test1.Id,
            Category = CategorySeed.pralki,
            Name = "Pralka BOSCH",
            Description = DESCRIPTION,
            MinimalPrice = 0,
            Price = 1800,
            TypeOfOffer = TypeOfOffer.BUY_IT_NOW,
            DaysForReturn = 14,
            ProductState = ProductStateSeed.odnowiony_przez_producenta,
            ItemsInStock = 10,
            ShippingTimeInWorkingDays = 3,
            EndDate = DateTime.UtcNow.AddDays(8)
        };


        public static Product powerbank = new Product()
        {
            SellerId = UserSeed.test2.Id,
            Category = CategorySeed.powerbanki,
            Name = "Powerbanki z biedronki",
            Description = DESCRIPTION,
            MinimalPrice = 0,
            Price = 38,
            TypeOfOffer = TypeOfOffer.BUY_IT_NOW,
            DaysForReturn = 14,
            ProductState = ProductStateSeed.nowy,
            ItemsInStock = 100,
            ShippingTimeInWorkingDays = 1,
            EndDate = DateTime.UtcNow.AddDays(20),
            IsHighlighted = true
        };

        public static Product etui = new Product()
        {
            SellerId = UserSeed.test3.Id,
            Category = CategorySeed.telefony_i_akcesoria,
            Name = "Etui do iPHONE X",
            Description = DESCRIPTION,
            MinimalPrice = 0,
            Price = 120,
            TypeOfOffer = TypeOfOffer.BUY_IT_NOW,
            DaysForReturn = 14,
            ProductState = ProductStateSeed.nowy,
            ItemsInStock = 30,
            ShippingTimeInWorkingDays = 1,
            EndDate = DateTime.UtcNow.AddDays(14)
        };

        public static Product ladowarka = new Product()
        {
            SellerId = UserSeed.krzysztof.Id,
            Category = CategorySeed.telefony_i_akcesoria,
            Name = "Ładowarka microUSB 5V",
            Description = DESCRIPTION,
            MinimalPrice = 0,
            Price = 15,
            TypeOfOffer = TypeOfOffer.BUY_IT_NOW,
            DaysForReturn = 14,
            ProductState = ProductStateSeed.uzywany,
            ItemsInStock = 50,
            ShippingTimeInWorkingDays = 3,
            EndDate = DateTime.UtcNow.AddDays(14)
        };

        public static Product telewizor = new Product()
        {
            SellerId = UserSeed.artur.Id,
            Category = CategorySeed.rtv_i_agd,
            Name = "Telewizor SAMSUNG 42\"",
            Description = DESCRIPTION,
            MinimalPrice = 500,
            Price = 1100,
            TypeOfOffer = TypeOfOffer.AUCTION | TypeOfOffer.BUY_IT_NOW,
            DaysForReturn = 14,
            ProductState = ProductStateSeed.powystawowy,
            ItemsInStock = 1,
            ShippingTimeInWorkingDays = 2,
            EndDate = DateTime.UtcNow.AddDays(14),
            IsHighlighted = true
        };


        public static Product konsola_ps4 = new Product()
        {
            SellerId = UserSeed.artur.Id,
            Category = CategorySeed.rtv_i_agd,
            Name = "Konsola PlayStation 4 + GRY",
            Description = DESCRIPTION,
            MinimalPrice = 0,
            Price = 950,
            TypeOfOffer = TypeOfOffer.BUY_IT_NOW,
            DaysForReturn = 0,
            ProductState = ProductStateSeed.uzywany,
            ItemsInStock = 4,
            ShippingTimeInWorkingDays = 3,
            EndDate = DateTime.UtcNow.AddDays(7),
            IsHighlighted = true
        };

        public IEnumerable<object> Items { get; } = new List<Product>()
        {
            komputer_nowy, laptop_uzywany, telefon_xiaomi, arduino, pralka,
            powerbank, etui, ladowarka, telewizor, konsola_ps4
        };

        public static object GetRandomObject(List<object> objects)
        {
            Random rand = new Random();
            int randomIndex = rand.Next(0, objects.Count - 1);

            return objects[randomIndex];
        }

        public static IEnumerable<object> GetRandomProducts(int numberOfProducts)
        {
            Random rand = new Random();

            ICollection<Product> products = new List<Product>();

            Product product;

            for (int i = 0; i < numberOfProducts; i++)
            {
                product = new Product()
                {
                    SellerId = UserSeed.artur.Id,
                    Category = (Category)GetRandomObject(new CategorySeed().Items.ToList()),
                    Name = GenerateName(100),
                    Description = DESCRIPTION,
                    MinimalPrice = GetRandomPrice(),
                    Price = GetRandomPrice(),
                    TypeOfOffer = TypeOfOffer.AUCTION | TypeOfOffer.BUY_IT_NOW,
                    ProductState = (ProductState)GetRandomObject(new ProductStateSeed().Items.ToList()),
                    ItemsInStock = (ushort)rand.Next(1, 1000),
                    ShippingTimeInWorkingDays = (byte)rand.Next(1, 5),
                    EndDate = DateTime.UtcNow.AddDays(rand.Next(1, 14)),
                    IsHighlighted = rand.Next(1, 100) % 2 == 0,
                    //ProductDeliveryMethods = (ICollection<Product_DeliveryMethod>)new Product_DeliveryMethodSeed().Items.ToList()
                };

                products.Add(product);
            }

            return products;
        }

        public static decimal GetRandomPrice()
        {
            Random rand = new Random();
            bool isZero = rand.Next(1, 100) % 2 == 0;

            if (isZero)
                return 0;
            else
                return rand.Next(100, 20000);
        }

        public static string GenerateName(int length)
        {
            Random random = new Random();
            string[] consonants = { "a", "e", "i", "o", "u", "b","c","d","f","g","h","j","k","l","m","n","p","q","r","s","sh","z","zh",
            "t","v","w","x","y", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };

            string output = "";

            for (int i = 0; i < length; i++)
            {
                output += consonants[random.Next(0, consonants.Length - 1)];
            }

            return output;
        }
    }
}
