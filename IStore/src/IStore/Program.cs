using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IStore
{
    interface IProduct
    {
        string Name { get; set; }
        decimal Price { get; set; }
    }
    class Animal : IProduct
    {
        public string Breeds { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }

    }

    class Product : IProduct
    {
        public string Brand { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsExpensive { get; set; }
    }
    class Dog : Animal
    {
        public bool IsTall { get; set; }

    }
    class Cat : Animal
    {
        public bool IsShortTail { get; set; }

    }

    class Food : Product
    {
        public bool IsRipe { get; set; }

    }
    class Toys : Product
    {
        public bool IsBattryUse { get; set; }

    }
    class Electronics : Product
    {
        public bool Ispowersaving { get; set; }

    }

    public class Program
    {
        public static void Main(string[] args)
        {

            IProduct[] Items = new IProduct[]

                 {
            new IStore.Dog { Breeds= "Akita", Name= "Doggi",  Price= 48.00m, Color= "Black", IsTall= true },

            new IStore.Dog { Breeds = "Beagle", Name = "Begi", Price = 30.00m, Color = "Brown", IsTall = false },

            new IStore.Dog { Breeds = "Azawakh", Name = "Aza", Price = 45.00m, Color = "White", IsTall = true },

            new IStore.Cat { Breeds = "Abyssinia", Name = "Werro", Price = 15.00m, Color = "Brown", IsShortTail = true },

            new IStore.Cat { Breeds = "Beagle", Name = "Begi", Price = 25.00m, Color = "Off white", IsShortTail = true },

            new IStore.Cat { Breeds = "American Curt", Name = "Curty", Price = 35.00m, Color = "Black &White", IsShortTail = false },
         
            new IStore.Food{ Brand= "Baldwin", Name= "Apple",  Price= 1.00m, IsExpensive = false, IsRipe= true },

            new IStore.Food{ Brand = "Pluot", Name = "Apricat", Price = 0.30m, IsExpensive  = true, IsRipe = false},

            new IStore.Food{ Brand = "Avocado", Name = "Hass", Price = 0.60m, IsExpensive  = true, IsRipe = false },
      
            new IStore.Toys{ Brand= "Lego", Name= "Educo",  Price= 150.00m, IsExpensive = false, IsBattryUse= true },

            new IStore.Toys{ Brand = "Fat Brain Toys", Name = "Tedco", Price = 200.00m, IsExpensive  = true, IsBattryUse = false},

            new IStore.Toys{ Brand = "Melissa & Doug", Name = "Kid O", Price = 300.00m, IsExpensive  = true, IsBattryUse = true },
      
            new IStore.Electronics{ Brand= "Sony", Name= "TV",  Price= 450.00m, IsExpensive = true, Ispowersaving= true },

            new IStore.Electronics{ Brand = "Philips", Name = "Radio", Price = 30.00m, IsExpensive  = false, Ispowersaving = false},

            new IStore.Electronics{ Brand = "Dell", Name = "Labtop", Price = 700.00m, IsExpensive  = true, Ispowersaving = true }
       };
            foreach (IProduct Item in Items)
                
                {
                Console.WriteLine("Name : " + Item.Name);
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("Price : " + Item.Price);
                Console.WriteLine("**************************** ");
            }
            Console.ReadLine();
        }
    }

}



