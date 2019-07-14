using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace viewcomps.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
        void AddProduct(Product product);
    }
    public class MemoryProductRepository : IProductRepository
    {
        List<Product> products = new List<Product> {
            new Product { Name = "Kayak", Price = 275M },
            new Product { Name = "Life Jacket", Price = 48.95M },
            new Product { Name = "Soccer Ball", Price = 19.50M },
        };

        public IEnumerable<Product> Products => products;

        public void AddProduct(Product product)
        {
            products.Add(product);
        }
    }
}
