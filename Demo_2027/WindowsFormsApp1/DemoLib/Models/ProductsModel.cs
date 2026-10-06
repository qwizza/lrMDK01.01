using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace DemoLib.Models
{
    public class ProductsModel : IProductsModel
    {
        private List<Product> data_ = new List<Product>();

        public ProductsModel()
        {
            data_.Add(new Product { Name = "abc", Category = "Мучные", Count = 10, Price = 100.0, Supplier = "Хлебзавод", Parts = "Хлеб, батон, багет, круасаны, пирожки",
                ImagePath = "C:\\Users\\user\\Pictures\\Roblox\\kartinka1.png"
            });
            data_.Add(new Product { Name = "xyz", Category = "Колбасы", Count = 10000, Price = 500.0, Supplier = "Беларусь", Parts = "Колбаса варёная, колбаса сырокопчёная",
            ImagePath = "C:\\Users\\user\\Pictures\\Roblox\\telka.png"
            });
        }

        public List<Product> Load()
        {
            return data_;
        }

        public int GetCountProducts()
        {
            return data_.Count;
        }
    }
}
