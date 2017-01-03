using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace controlFlow
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int myCounter = 0;
           bool myBool = false;
            if (myCounter <= 10 && myBool)


                {
                Console.WriteLine(myCounter);
                myCounter++;
         
            }else
            {
                Console.WriteLine("Whoops! The counter is more than 10!");

            }
            Console.ReadLine();
        }
    }
}
