using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hamletWord
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText("C:\\programming\\FullStackDotNet\\weekThree\\hamletWord\\src\\hamletWord\\hamlet.txt");


            text = text.Replace("the", "");

            var frequencies = new Dictionary<string, int>();
            string highestWord = null;
            int highestFreq = 0;

            var message = string.Join(" ", text);
            var splichar = new char[] { ' ', '.' };
            var single = message.Split(splichar, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in single)
            {
                int freq;
                frequencies.TryGetValue(item, out freq);
                freq += 1;

                if (freq > highestFreq)
                {
                    highestFreq = freq;
                    highestWord = item.Trim();
                }
                frequencies[item] = freq;
            }


            Console.WriteLine("highestWord {0} ({1} times)", highestWord, highestFreq );
            Console.ReadLine();
            

        }
    }
}

