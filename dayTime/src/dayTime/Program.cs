//create a new Console App that displays the current time.




using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var rightNow = DateTime.Now;
          //  var oneHourFormNow = rightNow.AddHour(1);

            Console.WriteLine("the current time is : {0}", rightNow);
            Console.ReadLine();
        }
    }
}
