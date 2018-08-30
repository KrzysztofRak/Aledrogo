using Aledrogo.Models;
using System.Collections.Generic;

namespace Aledrogo.Data.DataToSeed
{
    public class CategorySeed : IDataToSeed
    {
        public static Category elektronika = new Category() { Name = "Elektornika" };
        public static Category rtv_i_agd = new Category() { Name = "RTV i AGD", ParentCategory = elektronika };
        public static Category pralki = new Category() { Name = "Pralki", ParentCategory = rtv_i_agd };
        public static Category komputery = new Category() { Name = "Komputery", ParentCategory = rtv_i_agd };
        public static Category telefony_i_akcesoria = new Category() { Name = "Telefony i akcesoria", ParentCategory = elektronika };
        public static Category xiaomi = new Category() { Name = "Xiaomi", ParentCategory = telefony_i_akcesoria };
        public static Category powerbanki = new Category() { Name = "Powerbanki", ParentCategory = telefony_i_akcesoria };

        public IEnumerable<object> Items { get; } = new List<Category>()
        {
            elektronika,
                rtv_i_agd,
                    pralki, komputery,
                telefony_i_akcesoria,
                    xiaomi, powerbanki
        };
    }
}

