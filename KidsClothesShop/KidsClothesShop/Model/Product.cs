using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsClothesShop.Model
{
    public class Product
    {
        public int Id { get; set; }           //  
        public string Name { get; set; }      //
        public double Price { get; set; }     // M:1
        public int Size { get; set; }         //
        public string Gender { get; set; }    //
        public int ProductTypeId { get; set; }   //FK
        public ProductType ProductTypes { get; set; }   // Таблица, с която се осъществява връзка.
        public string Description { get; set; }   // M:1
    }
}
