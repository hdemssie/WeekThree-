using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace complexClass
{
    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address BillingAddress { get; set; }
        public Address ShippingAddress { get; set; }
        public Customer(String fristName, string lastName, Address billingAddress, Address shippingAddress)
        {
            this.FirstName = fristName;
            this.LastName = lastName;
            this.BillingAddress = billingAddress;
            this.ShippingAddress = shippingAddress;
        }
    }

    class Address
    {
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public Address(string city, string state, string zip)
        {

            this.City = city;
            this.State = state;
            this.Zip = zip;


        }

    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Address joshBilling = new Address("Delavan", "WI", "55555");
            Address joshShipping = new Address("Palatine", "Il", "55555");

            Customer josh = new Customer("Josh", "Christiansen", joshBilling, joshShipping);
            Console.WriteLine(josh.BillingAddress.City);
            Console.ReadLine();
        }
    }
}


