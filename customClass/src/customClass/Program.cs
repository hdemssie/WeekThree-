using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace CustomClasses
{
    class Product
    {
        public string Name { get; set; }
        private decimal _price;
        public string Price
        {
            get { return _price.ToString("c"); }
            set
            {
                if (decimal.Parse(value) < 0)
                {
                    throw new ArgumentException("value", "Price cannot be less than 0!");
                }
                else
                {
                    _price = decimal.Parse(value);
                }
                _price = decimal.Parse(value);
            }
        }
        public decimal CalculateTax()
        {
            return this._price * .08m;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            var milk = new Product
            {
                Name = "Milk",
                Price = "2.34"
            };
            var eggs = new Product
            {
                Name = "Eggs",
                Price = "1.25"
            };
            var cheese = new Product();
            cheese.Name = "Cheese";
            cheese.Price = "4.99";
            Console.WriteLine("{0}: Price - {1} Tax - {2}", milk.Name, milk.Price, milk.CalculateTax());
            Console.WriteLine("{0}: Price - {1} Tax - {2}", eggs.Name, eggs.Price, eggs.CalculateTax());
            Console.ReadLine();
        }
    }
}
