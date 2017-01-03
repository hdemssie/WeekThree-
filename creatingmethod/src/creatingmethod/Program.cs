using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace CreatingMethods
{
    class StoryTeller
    {
        public string Story { get; set; }
        public string BuildStory(params string[] storyItems)
        {
            foreach (var word in storyItems)
            {
                this.Story = this.Story + word + " ";
            }
            return this.Story;
        }
    }
    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal CalculateTax()
        {
            return this.Price * .08m;
        }
        public decimal CalculateTax(decimal taxRate)
        {
            return this.Price * taxRate;
        }
        public decimal CalculateTotal(decimal tax, decimal discount = 0)
        {
            return this.Price + tax - discount;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            StoryTeller myStoryTeller = new StoryTeller();
            Console.WriteLine(myStoryTeller.BuildStory("the", "fast", "cat", "jumped", "over", "the", "lazy", "dog"));
            Console.ReadLine();
            //        var milk = new Product
            //        {
            //            Name = "Milk",
            //            Price = 1.99m
            //        };
            //        decimal milkTax = milk.CalculateTax();
            //        decimal milkTaxWithSuppliedRate = milk.CalculateTax(taxRate: .05m);
            //        decimal milktotal = milk.CalculateTotal(milk.CalculateTax(.04m));
            //        Console.WriteLine("{0} -> Tax: {1} Total: {2}", milk.Name, milkTax, milktotal);
            //        Console.ReadLine();
            //    }
            //}
        }

    }
    