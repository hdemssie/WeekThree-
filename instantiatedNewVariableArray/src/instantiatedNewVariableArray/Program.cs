using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace instantiatedNewVariableArray
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee[] employess = new Employee[]
          {
                new Employee { FirstName = "Josh", LastName = "Christiansen" },
                new Employee { FirstName="Donna", LastName="Ryan" },
                new Employee { FirstName = "Johanna", LastName = "Ehmke"}
          };
        }
    }
}
