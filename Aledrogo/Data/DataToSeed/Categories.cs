using Aledrogo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aledrogo.Data
{
    public static partial class DataToSeed
    {
        private static Category elektronika = new Category() { Name = "Elektornika" };
        private static Category rtv_i_agd = new Category() { Name = "RTV i AGD", ParentCategory = elektronika };
        private static Category pralki = new Category() { Name = "Pralki", ParentCategory = rtv_i_agd };
        private static Category telewizory = new Category() { Name = "Telewizory", ParentCategory = rtv_i_agd };
        private static Category telefony_i_akcesoria = new Category() { Name = "Telefony i akcesoria", ParentCategory = elektronika };
        private static Category xiaomi = new Category() { Name = "Xiaomi", ParentCategory = telefony_i_akcesoria };
        private static Category powerbanki = new Category() { Name = "Powerbanki", ParentCategory = telefony_i_akcesoria };

        private static Category moda = new Category() { Name = "Moda" };
        private static Category odziez_obuwie_dodatki = new Category() { Name = "Odzież, obuwie, dodatki", ParentCategory = moda };
        private static Category sukienki = new Category() { Name = "Sukienki", ParentCategory = odziez_obuwie_dodatki };
        private static Category walizki = new Category() { Name = "Walizki", ParentCategory = odziez_obuwie_dodatki };
        private static Category bizuteria_i_zegarki = new Category() { Name = "Biżuteria i zegarki", ParentCategory = moda };
        private static Category naszyjniki = new Category() { Name = "Naszyjniki", ParentCategory = bizuteria_i_zegarki };
        private static Category zegarki_meskie = new Category() { Name = "Zegarki męskie", ParentCategory = bizuteria_i_zegarki };

        public static List<Category> Categories { get; private set; } = new List<Category>() { elektronika, rtv_i_agd, pralki, telewizory, telefony_i_akcesoria, xiaomi, powerbanki,
                                                                                               moda, odziez_obuwie_dodatki, sukienki, walizki, bizuteria_i_zegarki, naszyjniki, zegarki_meskie};
    }
}

