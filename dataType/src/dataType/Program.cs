using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dataType
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ///* decimal price = 9.9985465m;
            // string priceString;

            // priceString = "the price of the item is" + price.ToString("c") + "!";

            // var crazyText = "He said \"Awesome!\" \nBut I tought he was crazy.";
            // Console.WriteLine(crazyText); 
            // Console.WriteLine(priceString);
            // Console.ReadLine();
            // */

            // Console.WriteLine("what is your favorite clolor?");
            // String answer = Console.ReadLine();
            // Console.WriteLine("your favorite color is " + answer + "!");
            // Console.ReadLine();  


            ////String productName = "laptop";
            ////decimal productPrice = 999.99m;
            ////string message = String.Format("the {0} costs {1} dollars.", productName, productPrice);
            ////Console.Write(message);
            ////Console.ReadLine();

            var productName = "Laptop";
            var price = 344.55;
            var message = string.Format(" the {0} costs {1:c} dollars.", productName, price);
            Console.Write(message);
            Console.ReadLine();

        }
    }
}


