using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsClothesShop.Model
{
    public class ProductType
    {
        public int Id { get; set; }             //
        public string NameType { get; set; }    // 1:М
        ICollection<Product> Products { get; set; }
    }
}
