using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Constructors
{
    class Movie
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public void WriteInfo()
        {
            Console.WriteLine("Title: {0} Director: {1}", this.Title, this.Director);
            Console.ReadLine();
        }
        public Movie(string title, string director)
        {
            this.Title = title;
            this.Director = director;
        }
    }
    class Product
    {
        public decimal Price { get; set; }
        public string Name { get; set; }
        public Product(string name)
        {
            this.Name = name;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Movie movie1 = new Movie("Star Wars: A New Hope", "Lucas");
            Movie movie2 = new Movie("Dumb and Dumber", "George Lucas");
            Console.ReadLine();

        }
    }
}
