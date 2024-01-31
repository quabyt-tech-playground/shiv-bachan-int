using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Practice
{
    internal class Customer
    {
        public int Custid { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public double Balance { get; set; }


    }
    class TestCustomer {
        public static void Main()
        {
            List<Customer> Customers = new List<Customer>();

            Customer c1 = new Customer { Custid = 101, Name = "Scott", City = "Hyderabad", Balance = 25000.00 };
            Customer c2 = new Customer { Custid = 102, Name = "David", City = "Bengaluru", Balance = 33000.00 };
            Customer c3 = new Customer { Custid = 103, Name = "Lauren", City = "Chennai", Balance = 4500.40 };

            Customers.Add(c1);
            Customers.Add(c2);
            Customers.Add(c3);

            foreach (Customer customer in Customers)
            {
                //Console.WriteLine(customer.Name + " " + customer.City + " " + customer.Custid + " " + customer.Balance);
                Console.WriteLine($"Name:{customer.Name},City:{customer.City}, Id:{customer.Custid}, Balance: { customer.Balance }");   
            }
        } 
    }
}
