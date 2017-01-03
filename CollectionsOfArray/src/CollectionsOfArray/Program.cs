using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollectionsOfArray
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] Movies = new string[]
         {
            "Star Ware: A New Hope",
            "The Dark Kinght",
            "Jurassic Park"
             };
            string[] products = new string[3];
            products[0] = "Apple";
            products[1] = "Television";
            products[2] = "Coffiee";

            List<string> myMovieList = new List<string>();
            myMovieList.Add("Star Wars");
            myMovieList.Add("Jurassic Par");
            myMovieList.Add("Batam");

            foreach (string movie in myMovieList)
            {
                Console.WriteLine(movie);
            }
            Console.ReadLine();
        }
    }
}
