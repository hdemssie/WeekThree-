using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nullableTYpes
{
    public class Program
    {
        class Employee
        {
            public string Name { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime? EndDate { get; set; } // set to nullable data type 
        }
        public static void Main(string[] args)
        {
            Employee employee1 = new Employee
            {
                Name = "Bill Gate",
                StartDate = DateTime.Parse(" April 4, 1975"),
                EndDate = null
            };
        }
    }
}
