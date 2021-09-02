using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Emirhan";
            customer1.LastName = "Aslan";
            customer1.NationalIdentity = "74185296336";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.FirstName = "Engin";
            customer2.LastName = "Demiroğ";
            customer2.NationalIdentity = "96385274114";

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Murat";
            customer3.LastName = "Kurtboğan";
            customer3.NationalIdentity = "85274196336";

            Customer[] customers = new Customer[] { customer1, customer2, customer3};

            foreach (Customer customer  in customers)
            {
                Console.WriteLine("Customer information : " + customer.FirstName + " " + customer.LastName + " , " + customer.NationalIdentity);
                Console.WriteLine("");
            }

            Console.WriteLine("-------------------------------");

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Delete(customer2);
            customerManager.List(customer3);

        }
    }
}
