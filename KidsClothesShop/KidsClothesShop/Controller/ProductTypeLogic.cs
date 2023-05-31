using KidsClothesShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsClothesShop.Controller
{
    public class ProductTypeLogic
    {
        private ProductsContext _productContext = new ProductsContext();

        public List<ProductType> GetAllProductTypes()
        {
            return _productContext.ProductTypes.ToList();
        }

        public string GetProductTypeById(int id)
        {
            return _productContext.ProductTypes.Find(id).NameType;
        }
    }
}
