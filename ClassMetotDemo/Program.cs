using System;
using System.Collections.Concurrent;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.CustomerName = "İlayda";
            customer1.City = "Ankara";

            Customer customer2 = new Customer();
            customer1.Id = 2;
            customer1.CustomerName = "Esen";
            customer1.City = "Trabzon";

            Customer customer3 = new Customer();
            customer1.Id = 3;
            customer1.CustomerName = "Ahmet";
            customer1.City = "İzmir";

            CustomerManager customerManager1 = new CustomerManager();
            customerManager1.Add(customer1);
            customerManager1.Delete(customer2);
            customerManager1.Update(customer3);
            customerManager1.Read(customer2);



            Console.ReadLine();
            
            
            
            


            
        }
    }
}

