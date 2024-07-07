using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager personManager = new PersonManager();
            Customer customer1 = new Customer();
            customer1.FirstName = "Berat";
            customer1.LastName = "Doğan";
            customer1.Id = 1;
            customer1.Address = "Ankara";

            Student student1 = new Student();
            student1.Id = 2;
            student1.FirstName = "Esra";
            student1.LastName = "Polat";
            student1.Departmant = "Industrial engineering" ;

            personManager.Add(student1);
            personManager.Add(customer1);

            IPerson person1 = new Customer();
            IPerson person2 = new Student();

            CustomerManager customerManager = new CustomerManager();
            OracleCustomerDal oracleCustomerDal = new OracleCustomerDal();
            SqlServerCustomerDal sqlServerCustomerDal = new SqlServerCustomerDal();
            customerManager.Add(oracleCustomerDal);
            customerManager.Add(sqlServerCustomerDal);
            



            Console.ReadLine();
        }
        public interface IPerson // soyut nesne
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
        public class Customer : IPerson // somut nesne
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; } // customer a özel özellik
        }
        public class Student : IPerson // somut nesne
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Departmant { get; set; } // öğrenciye ait özel özellik
        }
        public class PersonManager
        {
            public void Add(IPerson person)
            {
                Console.WriteLine(person.FirstName + " eklendi");
            }
        }
    }
}

