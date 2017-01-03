using System;
using System.Linq;

class FizzBuzz
{

    public void DoFizzBuzz()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 7 == 0)
            { 
                Console.Write("FizzBuzz");
            }

           else if (i % 3 == 0)
            { 
                Console.Write("Fizz");
        }
           else if (i % 7 == 0)
            {
                Console.Write("Buzz");
            }
            else(!(i % 3 == 0 || i % 7 == 0))
            { 
                Console.Write(i);
            }

            Console.ReadLine();
        }
       

    }
}