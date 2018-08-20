using Aledrogo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aledrogo.Data.DataToSeed
{
    public static class CategorySeed
    {
        public static Category elektronika = new Category() { Name = "Elektornika" };
        public static Category rtv_i_agd = new Category() { Name = "RTV i AGD", ParentCategory = elektronika };
        public static Category pralki = new Category() { Name = "Pralki", ParentCategory = rtv_i_agd };
        public static Category komputery = new Category() { Name = "Komputery", ParentCategory = rtv_i_agd };
        public static Category telefony_i_akcesoria = new Category() { Name = "Telefony i akcesoria", ParentCategory = elektronika };
        public static Category xiaomi = new Category() { Name = "Xiaomi", ParentCategory = telefony_i_akcesoria };
        public static Category powerbanki = new Category() { Name = "Powerbanki", ParentCategory = telefony_i_akcesoria };

        //public static Category moda = new Category() { Name = "Moda" };
        //public static Category odziez_obuwie_dodatki = new Category() { Name = "Odzież, obuwie, dodatki", ParentCategory = moda };
        //public static Category sukienki = new Category() { Name = "Sukienki", ParentCategory = odziez_obuwie_dodatki };
        //public static Category walizki = new Category() { Name = "Walizki", ParentCategory = odziez_obuwie_dodatki };
        //public static Category bizuteria_i_zegarki = new Category() { Name = "Biżuteria i zegarki", ParentCategory = moda };
        //public static Category naszyjniki = new Category() { Name = "Naszyjniki", ParentCategory = bizuteria_i_zegarki };
        //public static Category zegarki_meskie = new Category() { Name = "Zegarki męskie", ParentCategory = bizuteria_i_zegarki };

        public static List<Category> Categories { get; private set; } = new List<Category>()
        {
            elektronika,
                rtv_i_agd,
                    pralki, komputery,
                telefony_i_akcesoria,
                    xiaomi, powerbanki
            //moda, odziez_obuwie_dodatki, sukienki, walizki, bizuteria_i_zegarki, naszyjniki, zegarki_meskie
        };
    }
}

