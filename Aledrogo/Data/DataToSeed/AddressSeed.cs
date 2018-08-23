using Aledrogo.Models;
using System.Collections.Generic;

namespace Aledrogo.Data.DataToSeed
{
    public static class AddressSeed
    {
        public static Address krzysztof_address1 = new Address() { UserId = UserSeed.krzysztof.Id, FullName = "Krzysztof Rak", StreetAddress = "Dereźnia 1", PostCode = "23-400", City = "Biłgoraj", Country = "Polska", PhoneNumber = "+48 724-391-490" };
        public static Address krzysztof_address2 = new Address() { UserId = UserSeed.krzysztof.Id, FullName = "Krzysztof Rak", StreetAddress = "ul. Radzyńska 20", PostCode = "20-480", City = "Lublin", Country = "Polska", PhoneNumber = "+48 724-391-490" };
        public static Address krzysztof_address3 = new Address() { UserId = UserSeed.krzysztof.Id, FullName = "Krzysztof Rak", StreetAddress = "ul. Ruda Solska 30", PostCode = "23-400", City = "Biłgoraj", Country = "Polska", PhoneNumber = "+48 724-391-490" };

        public static Address artur_address1 = new Address() { UserId = UserSeed.artur.Id, FullName = "Artur Bartoszek", StreetAddress = "ul. Gęsia 5", PostCode = "20-400", City = "Lublin", Country = "Polska", PhoneNumber = "+48 567-321-541" };
        public static Address artur_address2 = new Address() { UserId = UserSeed.artur.Id, FullName = "Artur Bartoszek", StreetAddress = "ul. Gliniana 3", PostCode = "20-400", City = "Lublin", Country = "Polska", PhoneNumber = "+48 567-321-541" };

        public static Address test1_address1 = new Address() { UserId = UserSeed.test1.Id, FullName = "Test Jeden", StreetAddress = "Wiązowa 15", PostCode = "87-100", City = "Toruń", Country = "Polska", PhoneNumber = "+48 755-232-893" };

        public static Address test2_address1 = new Address() { UserId = UserSeed.test2.Id, FullName = "Test Dwa", StreetAddress = "Powstańcza 126", PostCode = "22-150", City = "Warszawa", Country = "Polska", PhoneNumber = "+48 791-485-323" };

        public static Address test3_address1 = new Address() { UserId = UserSeed.test3.Id, FullName = "Test Trzy", StreetAddress = "Henryka 8", PostCode = "29-300", City = "Białystok", Country = "Polska", PhoneNumber = "+48 681-339-783" };

        public static List<Address> Addresses = new List<Address>()
        {
            krzysztof_address1, krzysztof_address2, krzysztof_address3,
            artur_address1, artur_address2,
            test1_address1,
            test2_address1,
            test3_address1
        };
    }
}
