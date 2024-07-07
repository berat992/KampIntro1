using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            // O class newlenince çalışan methoda constructor denir
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Engin";
            customer1.LastName = "Demiroğ";
            customer1.City = "Ankara";

            Customer customer2 = new Customer(2,"Derin","Demiroğ","Ankara");

        }
    }
    class Customer
    { 
        public Customer() // methot overloading
        {
            // customer1 çalışma sahası
        }
        public Customer(int id,string firstName,string lastName,string city) // default constructor
        {
            Console.WriteLine("Constructor is work");
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;





            // customer2 çalışma sahası
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}

