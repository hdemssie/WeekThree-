using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzz_C_Sharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0 && i % 7 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }

                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 7 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
                    Console.ReadLine();
        }

    }
}