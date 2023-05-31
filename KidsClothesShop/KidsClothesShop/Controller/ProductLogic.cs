using KidsClothesShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsClothesShop.Controller
{
    public class ProductLogic
    {
        private ProductsContext _productContext = new ProductsContext();

        public Product Get(int id)
        {
            Product findedProduct = _productContext.Products.Find(id);
            if (findedProduct != null)
            {
                _productContext.Entry(findedProduct).Reference(x => x.ProductTypes).Load();
            }
            return findedProduct;
        }

        public List<Product> GetAll()
        {
            return _productContext.Products.Include("ProductTypes").ToList();
        }

        public void Create(Product product)
        {
            _productContext.Products.Add(product);
            _productContext.SaveChanges();
        }

        public void Update(int id, Product product)
        {
            Product findedProduct = _productContext.Products.Find(id);
            if (findedProduct == null)
            {
                return;
            }
            findedProduct.Name = product.Name;
            findedProduct.Price = product.Price;
            findedProduct.Size = product.Size;
            findedProduct.Gender = product.Gender;
            findedProduct.ProductTypeId = product.ProductTypeId;
            _productContext.SaveChanges();
        }

        public void Delete(int id)
        {
            Product findedProduct = _productContext.Products.Find(id);
            _productContext.Products.Remove(findedProduct);
            _productContext.SaveChanges();
        }
    }
}
