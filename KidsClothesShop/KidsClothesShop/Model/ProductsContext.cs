using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsClothesShop.Model
{
    public class ProductsContext : DbContext
    {
        public ProductsContext() : base("ProductsContext")
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
    }
}
