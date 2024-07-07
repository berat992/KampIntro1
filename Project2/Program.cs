using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.City = "Ankara";
            customer1.Id = 1;
            customer1.FirstName = "Engin";
            customer1.LastName = "Demiroğ";

            Customer customer2 = new Customer()
            {
                Id = 2,City="İstanbul",FirstName="Derin",LastName="Demiroğ"
            };

            Console.WriteLine(customer1.City);
            Console.WriteLine(customer2.FirstName);

        }
    }
}

