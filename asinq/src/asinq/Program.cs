using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace asinq
{

    public class Program
    {
        public async static Task DoSomthing()
        {
            HttpClient client = new HttpClient();
            String page = await client.GetStringAsync("http://facebook.com");
            Console.WriteLine(page);
        }
        public static void Main(string[] args)
        {
            //Block syncronously until this task is completed
            DoSomthing().Wait();
            Console.ReadLine();
        }
    }
}
