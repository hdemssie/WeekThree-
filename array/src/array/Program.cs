using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace array
{
    public class Program
    {
        public static void Main(string[] args)
        {
            String[] colors = new string[]
            {
                "red", "green", "blue"
            };
            Console.WriteLine("The three colors in the array are {0}, {1}, and {2}", colors[0], colors[1], colors[2]);

            Console.ReadLine();

            Array.Sort(colors);


        }
    }
}
