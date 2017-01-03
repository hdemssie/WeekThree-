/*Create a new Visual Studio Console Application named ProductLookupWithList.

Create a Product class with the following three properties:

Id - The unique Id for the product.
Name - The name of the product.
Price - The price of the product.
Create a ProductCatalog class. In the constructor for the ProductCatalog,
create a Generic List of three products.

Add a method named Lookup() to the ProductCatalog class. 
The Lookup() method should enable you to lookup products by their unique Id. For example:

 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ProductLookUpWithList
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    class ProductCatalog
    {
        private List<Product> _products;
        public Product Lookup(int id)
        {
            Product result = null;
            foreach (Product product in this._products)
            {
                if (product.Id == id)
                {
                    result = product;
                }

            }
            return result;
        }
        public ProductCatalog()
        {
            _products = new List<Product>
            {
            new Product { Id = 1, Name = "Guitar", Price = 100.34m },
            new Product { Id = 2, Name = "Laptop", Price = 2355.46m },
            new Product { Id = 3, Name = "Pillow", Price = 34.57m }
            };
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ProductCatalog myCat = new ProductCatalog();
            Product myLookedUpProd = myCat.Lookup(2);
            Console.WriteLine(myLookedUpProd.Name);
            Console.ReadLine();
        }
    }
}