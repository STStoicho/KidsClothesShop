using KidsClothesShop.Controller;
using KidsClothesShop.Model;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KidsClothesShop.View
{
    public class Display
    {
        private ProductLogic productLogic = new ProductLogic();
        private int closeOperation = 6;
        public Display()
        {
            Input();
        }

        private void ShowMenu()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 18) + "Menu" + new string(' ', 18));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("1. List all entries");
            Console.WriteLine("2. Add new entry");
            Console.WriteLine("3. Update entry");
            Console.WriteLine("4. Fetch entry by ID");
            Console.WriteLine("5. Delete entry by ID");
            Console.WriteLine("6. Exit");
        }

        private void Input()
        {
            var operation = -1;
            do
            {
                ShowMenu();
                operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        ListAll();
                        break;

                    case 2:
                        Add();
                        break;

                    case 3:
                        Update();
                        break;

                    case 4:
                        Fetch();
                        break;

                    case 5:
                        Delete();
                        break;
                    default:
                        break;
                }
            } while (operation != closeOperation);
        }

        private void PrintProduct(Product product)
        {
            Console.WriteLine($"{product.Id}. {product.Name}, Price: {product.Price}, Size: {product.Size}, Gender: {product.Gender}, Type: {product.ProductTypes.NameType}, Description: {product.Description}");
        }

        private void Delete()
        {
            Console.WriteLine("Enter ID to delete: ");
            int id = int.Parse(Console.ReadLine());
            ProductLogic productController = new ProductLogic();
            Product product = productController.Get(id);
            if (product != null)
            {
                productController.Delete(id);
            }

            Console.WriteLine($"Successfully deleted!");
        }

        private void Fetch()
        {
            Console.WriteLine("Enter ID to fetch: ");
            int id = int.Parse(Console.ReadLine());
            ProductLogic productControrller = new ProductLogic();
            Product product = productControrller.Get(id);
            if (product != null)
            {
                PrintProduct(product);
            }
        }

        private void Update()
        {
            Console.Write("Enter the Product's id: ");
            int productId = int.Parse(Console.ReadLine());
            Product newProduct = productLogic.Get(productId);
            if (newProduct == null)
            {
                Console.WriteLine("No searching product");
                return;
            }
            PrintProduct(newProduct);
            Console.WriteLine("Enter the new values: ");
            Console.Write("Name: ");
            newProduct.Name = Console.ReadLine();
            Console.Write("Price: ");
            newProduct.Price = int.Parse(Console.ReadLine());
            Console.Write("Size: ");
            newProduct.Size = int.Parse(Console.ReadLine());
            Console.Write("Gender: ");
            newProduct.Gender = Console.ReadLine();

            ProductTypeLogic productTypesLogic = new ProductTypeLogic();
            List<ProductType> allProductTypes = productTypesLogic.GetAllProductTypes();
            Console.WriteLine("Types: ");
            Console.WriteLine(new string('-', 8));
            foreach (var item in allProductTypes)
            {
                Console.WriteLine(item.Id + ". " + item.NameType);
            }
            Console.WriteLine("Choose type by ID: ");
            newProduct.ProductTypeId = int.Parse(Console.ReadLine());

            Console.Write("Description: ");
            newProduct.Description = Console.ReadLine();

            Console.WriteLine($"Successfully updated!");

            ProductLogic productContorller = new ProductLogic();
            productContorller.Update(productId, newProduct);
        }

        private void Add()
        {
            Product newProduct = new Product();
            Console.Write("Name: ");
            newProduct.Name = Console.ReadLine();
            Console.Write("Price: ");
            newProduct.Price = int.Parse(Console.ReadLine());
            Console.Write("Size: ");
            newProduct.Size = int.Parse(Console.ReadLine());
            Console.Write("Gender: ");
            newProduct.Gender = Console.ReadLine();

            ProductTypeLogic productTypesLogic = new ProductTypeLogic();
            List<ProductType> allProductTypes = productTypesLogic.GetAllProductTypes();
            Console.WriteLine("Types: ");
            Console.WriteLine(new string('-', 8));
            foreach (var item in allProductTypes)
            {
                Console.WriteLine(item.Id + ". " + item.NameType);
            }
            Console.WriteLine("Choose type by ID: ");
            newProduct.ProductTypeId = int.Parse(Console.ReadLine());

            Console.Write("Description: ");
            newProduct.Description = Console.ReadLine();

            Console.WriteLine($"Successfully added!");

            ProductLogic productContorller = new ProductLogic();
            productContorller.Create(newProduct);
        }

        private void ListAll()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 16) + "Products" + new string(' ', 16));
            Console.WriteLine(new string('-', 40));
            ProductLogic productController = new ProductLogic();
            var products = productController.GetAll();
            foreach (var item in products)
            {
                Console.WriteLine($"{item.Id}. {item.Name}, Price: {item.Price}, Size: {item.Size}, Gender: {item.Gender}, Type: {item.ProductTypes.NameType}, Description: {item.Description}");
            }
        }
    }
}
