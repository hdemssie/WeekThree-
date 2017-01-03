using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace StaticUtlityClass
{
    class Utility
    {
        public static string CleanUserInput(string input)
        {
            return input.Trim().ToLower();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite food?");
            string input = Console.ReadLine();
            Console.WriteLine("Your favorite food is {0}!", Utility.CleanUserInput(input));
            Console.ReadLine();
        }
    }
}
