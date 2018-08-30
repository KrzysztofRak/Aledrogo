using Aledrogo.Models;
using System;
using System.Collections.Generic;

namespace Aledrogo.Data.DataToSeed
{
    public class ImageSeed : IDataToSeed
    {
        private static string imagesDirectoryPath = AppDomain.CurrentDomain.BaseDirectory.Remove(AppDomain.CurrentDomain.BaseDirectory.LastIndexOf("\\Aledrogo")) + @"\Aledrogo\Data\DataToSeed\Images\";

        private static string _img_01_Path = imagesDirectoryPath + "img01.jpg";
        private static string _img_02_Path = imagesDirectoryPath + "img02.jpg";
        private static string _img_03_Path = imagesDirectoryPath + "img03.jpg";
        private static string _img_04_Path = imagesDirectoryPath + "img04.jpg";
        private static string _img_05_Path = imagesDirectoryPath + "img05.jpg";

        public IEnumerable<object> Items { get; } = new List<Image>()
        {
            new Image() { ImagePath = _img_01_Path, Product = ProductSeed.arduino },
            new Image() { ImagePath = _img_02_Path, Product = ProductSeed.arduino },
            new Image() { ImagePath = _img_03_Path, Product = ProductSeed.arduino },
            new Image() { ImagePath = _img_04_Path, Product = ProductSeed.arduino },
            new Image() { ImagePath = _img_05_Path, Product = ProductSeed.arduino },

            new Image() { ImagePath = _img_02_Path, Product = ProductSeed.etui },
            new Image() { ImagePath = _img_01_Path, Product = ProductSeed.etui },
            new Image() { ImagePath = _img_03_Path, Product = ProductSeed.etui },
            new Image() { ImagePath = _img_04_Path, Product = ProductSeed.etui },
            new Image() { ImagePath = _img_05_Path, Product = ProductSeed.etui },

            new Image() { ImagePath = _img_03_Path, Product = ProductSeed.komputer_nowy },
            new Image() { ImagePath = _img_01_Path, Product = ProductSeed.komputer_nowy },
            new Image() { ImagePath = _img_02_Path, Product = ProductSeed.komputer_nowy },
            new Image() { ImagePath = _img_04_Path, Product = ProductSeed.komputer_nowy },
            new Image() { ImagePath = _img_05_Path, Product = ProductSeed.komputer_nowy },

            new Image() { ImagePath = _img_04_Path, Product = ProductSeed.laptop_uzywany },
            new Image() { ImagePath = _img_01_Path, Product = ProductSeed.laptop_uzywany },
            new Image() { ImagePath = _img_02_Path, Product = ProductSeed.laptop_uzywany },
            new Image() { ImagePath = _img_03_Path, Product = ProductSeed.laptop_uzywany },
            new Image() { ImagePath = _img_05_Path, Product = ProductSeed.laptop_uzywany },

            new Image() { ImagePath = _img_05_Path, Product = ProductSeed.konsola_ps4 },
            new Image() { ImagePath = _img_01_Path, Product = ProductSeed.konsola_ps4 },
            new Image() { ImagePath = _img_02_Path, Product = ProductSeed.konsola_ps4 },
            new Image() { ImagePath = _img_03_Path, Product = ProductSeed.konsola_ps4 },
            new Image() { ImagePath = _img_04_Path, Product = ProductSeed.konsola_ps4 },

            new Image() { ImagePath = _img_05_Path, Product = ProductSeed.ladowarka },
            new Image() { ImagePath = _img_04_Path, Product = ProductSeed.ladowarka },
            new Image() { ImagePath = _img_03_Path, Product = ProductSeed.ladowarka },

            new Image() { ImagePath = _img_01_Path, Product = ProductSeed.powerbank },
            new Image() { ImagePath = _img_02_Path, Product = ProductSeed.powerbank },
            new Image() { ImagePath = _img_03_Path, Product = ProductSeed.powerbank },

            new Image() { ImagePath = _img_02_Path, Product = ProductSeed.pralka },
            new Image() { ImagePath = _img_01_Path, Product = ProductSeed.pralka },

            new Image() { ImagePath = _img_04_Path, Product = ProductSeed.telefon_xiaomi },
            new Image() { ImagePath = _img_03_Path, Product = ProductSeed.telefon_xiaomi },

            new Image() { ImagePath = _img_05_Path, Product = ProductSeed.telewizor }
        };
    }
}
