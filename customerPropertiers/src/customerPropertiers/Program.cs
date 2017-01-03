using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace CustomerProperties
{
    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int BirthDate { get; set; }
        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (_age <= 0)
                {
                    _age = 0;
                }
                _age = value;
            }
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            var sally = new Customer
            {
                FirstName = "Sally",
                LastName = "Williams",
                Age = -23,
                BirthDate = 2028
            };
            var mike = new Customer
            {
                FirstName = "Mike",
                LastName = "Harrison",
                Age = -10,
                BirthDate = 2019

            };
            Debug.Assert(sally.Age == 23, "Sally is 23");
            Debug.Assert(mike.Age == 10, "Mike is 10");
            Debug.Assert(sally.Age == 0, "Sally cannot be under the age of 0");
            Console.ReadLine();

        }
    }
}