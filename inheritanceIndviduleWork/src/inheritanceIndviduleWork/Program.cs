/*
====================================================================
Create a new Visual Studio Console Application named Inheritance.

Create a set of classes that satisfy the following requirements:

FullTimeEmployee - A full time employee should have First Name, Last Name, and Years Employed properties.
ContractEmployee - A contract employee should have First Name, Last Name, and Months Employed properties.
All employees should have a method named ShowFullName() that displays the employee's full name (for example, "Bill Gates").
==================================================
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    abstract class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName()
        {
            return this.FirstName + " " + this.LastName;
        }
    }

    class FullTimeEmployee : Employee
    {
        public int YearsEmployed { get; set; }
        public FullTimeEmployee(string firstName, string lastName, int yearsEmployed)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.YearsEmployed = yearsEmployed;
        }
    }
    class ContractEmployee : Employee
    {
        public int MonthsEmployed { get; set; }
        public ContractEmployee(string firstName, string lastName, int monthsEmployed)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.MonthsEmployed = monthsEmployed;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee employee1 = new FullTimeEmployee("Bill", "Gates", 5);
            ContractEmployee employee2 = new ContractEmployee("Steve", "Jobs", 2);

            Console.WriteLine("{0} has been employed for {1} years. {2} is a fulltime employee.", employee1.FullName(), employee1.YearsEmployed, employee1.FirstName);
            Console.WriteLine("{0} has been employed for {1} months. {2} is contract employee.", employee2.FullName(), employee2.MonthsEmployed, employee2.FirstName);
            Console.ReadLine();
        }
    }
}