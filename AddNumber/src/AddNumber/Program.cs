using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace AddNumbers
{
    class Math
    {
        public int Add { get; set; }
        public int AddNumber(params int[] AddNums)
        {
            foreach (var num in AddNums)
            {
                this.Add = this.Add + num;
            }
            return this.Add;
        }


    }



    public class Program
    {
        public static void Main(string[] args)
        {
            Math myMathClass = new Math();
            Console.WriteLine(myMathClass.AddNumber(3, 3, 3));
            Console.ReadLine();
        }
    }
}