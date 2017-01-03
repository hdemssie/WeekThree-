using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myFirstApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your name");


            string myName = null;
        
            myName=Console.ReadLine();

            string greeting = String.Format("Good to meet you, {0}", myName);

            Console.WriteLine(greeting);
            Console.ReadLine();

        }
    }
}
