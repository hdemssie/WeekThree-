

/*
 * -----------------------------------------------------------------------------------------------------------------
  Create a new Visual Studio Console Application named ComplexClass. 
 
 Each customer in the bank can have multiple accounts with the following properties:

Id - A unique identifier for the account.
Type - An account can be a Checking or Savings account.
Amount - An account can have a certain amount of money.
IsOpen - A boolean property which represents whether the account is open or closed.
Create a customer named Alice that has two accounts:

A checking account with $100.00 that is open.
A savings account with $0.00 that is closed.
Extra Credit: Create a method on the Customer class named Transfer() that enables you to 
 transfer money from one account to another.
 *--------------------------------------------------------------------------------------------------------------------
 */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace complexClass_Homework
{
    class Customer
    {
       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Account CheckingAccount { get; set; }
        public Account SavingAccount { get; set; }

        public Customer (int bANumb, String fName, String lName, Account checkingAccount, Account savingAccount)

        {
            this.FirstName = fName;
            this.LastName = lName;
            this.CheckingAccount 

        }

    }

    class Account
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public decimal Amount { get; set; }
        public bool IsOpen { get; set; }
        public Account(string idnum, string checking, string saving, decimal amt, bool IsOpen)
        {

            this.Id = idnum;
            this.Type = checking;
            this.Type = saving;
            this.Amount = amt;
            this.IsOpen = IsOpen;


        }

        public class Program
        {
            public static void Main(string[] args)
            {
                Account checking = new Account("Delavan", "WI", "55555");
                Account saving  = new Account("Palatine", "Il", "55555");

                Customer Alice Eric = new Customer("Josh", "Christiansen", joshBilling, joshShipping);
                Console.WriteLine(josh.BillingAddress.City);
                Console.ReadLine();
            }
        }
    }
}
   