using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_MVC_Project_v1.Models
{
    public class Urunler
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductCategory { get; set; }  // Belki ihtiyaç olursa Subcategory de eklenebilir.
        public double ProductPrice { get; set; }

        //public string ProductImage { get; set; } // Ürün resmi eklemeyi sonraya bırakabilirim, sonradan migration oluşturarak kolon eklenebilir.

        //public int ProductStock { get; set; }  // yeterli stok yoksa uyarı, stok geldiğinde haber ver seçeneği vb. yapılabilir...

    }
}
