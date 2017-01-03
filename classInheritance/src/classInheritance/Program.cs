using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheratance
{
    abstract class Car
    {
        public string VIN { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public decimal CalculateTax()
        {
            return this.Price * .08m;
        }
    }
    class NewCar : Car
    {
    }
    class UsedCar : Car
    {
        public int Miles { get; set; }
    }
    class CertifiedUsedCar : Car
    {
        public int Miles { get; set; }
        public int WarrantyMonths { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            NewCar car1 = new NewCar();
            CertifiedUsedCar car2 = new CertifiedUsedCar();
            UsedCar car3 = new UsedCar();

            Car[] inventory = new Car[]
            {
                car1, car2, car3
            };
        }
    }
}