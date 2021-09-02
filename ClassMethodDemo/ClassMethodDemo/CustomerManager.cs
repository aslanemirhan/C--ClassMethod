using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer Added Successfully : " + customer.FirstName + " " + customer.LastName + " , " + customer.NationalIdentity);
        }

        public void List(Customer customer)
        {
            Console.WriteLine("Customer Listed Successfully : " + customer.FirstName + " " + customer.LastName + " , " + customer.NationalIdentity);
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer Deleted Successfully : " + customer.FirstName + " " + customer.LastName + " , " + customer.NationalIdentity);
        }
    }
}
