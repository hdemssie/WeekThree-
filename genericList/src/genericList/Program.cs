using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionGenericList
{
    class Movie
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public Movie(string title, string director)
        {
            this.Title = title;
            this.Director = director;
        }
    }

    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Movies
            // Create a group of movies to add to the Movies list
            Movie movie1 = new Movie("Star Wars: A New Hope", "George Lucas");
            Movie movie2 = new Movie("Jurassic Park", "Steven Spielberg");
            Movie movie3 = new Movie("The Dark Knight", "Christopher Nolan");

            List<Movie> movies = new List<Movie>();
            // .Add - have to add them all individually
            movies.Add(movie1);
            movies.Add(movie2);
            movies.Add(movie3);


            // Products
            // Create List<Product> and populate that list with three Product objects
            List<Product> products = new List<Product>
            {
                new Product {Name = "Milk", Price = 1.99m },
                new Product {Name = "Cheese", Price = 3.99m },
                new Product {Name = "Laptop", Price = 999.99m }
            };

            // Iteration through each collection and Console.WriteLine info about each element
            Console.WriteLine("MOVIES");
            foreach (Movie movie in movies)
            {
                Console.WriteLine(movie.Title);
            }
            Console.WriteLine("PRODUCTS");
            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
            }
            Console.ReadLine();
        }
    }
}