using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace genericDictionaryCollection
{
    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    class ProductCatalog
    {
        private Dictionary<int, Product> _prodcuts;
        public Product Lookup(int id)
        {
            Product result = null;
            if(_prodcuts.ContainsKey(id))
            {
                result = _prodcuts[id];
            }
            return result;
        }
        public ProductCatalog()
        {
            this._prodcuts = new Dictionary<int, Product>();
            _prodcuts.Add(1, new Product { Name = "milk", Price = 1.99m });
            _prodcuts.Add(2, new Product { Name = "Cheese", Price = 3.99m });
            _prodcuts.Add(3, new Product { Name = "Laptop", Price = 4000.99m });
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            ProductCatalog myCatalog = new ProductCatalog();
            Product myprod = myCatalog.Lookup(1);
            Console.WriteLine("Name: {0} price: {1}", myprod.Name, myprod.Price);
            Console.ReadLine();

        }
    }
}
