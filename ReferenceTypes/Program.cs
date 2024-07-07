using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // int,decimal,float,bool,enum value(değer) types
            // arrays,class,interface   reference types
            // c# garbage collector

            Person person1 = new Person();
            Person person2 = new Person();

            person1.FirstName = "Engin";
            person2 = person1; // reference types. Adres eşitlemesi
            person1.FirstName = "Derin";
            Console.WriteLine(person2.FirstName); // Derin


           



            Customer customer = new Customer();
            customer.FirstName = "Salih";

            Employee employee = new Employee();
            employee.FirstName = "Veli";


            Person person3 = customer;
            Console.WriteLine(person3.FirstName);

            Console.WriteLine("------------------------");

            PersonManager personManager = new PersonManager();
            personManager.Add(customer);
            personManager.Add(employee); //Customer ve employee aynı zamanda
            // person olduğu için metotta çalışıyor


            Console.ReadLine();
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer :Person // aynı zamanda bir insan. Kalıtım/inheritance
    {
        public string CreditCardNumber { get; set; }
    }
    class Employee :Person // aynı zamanda insan. İnheritance/kalıtım
    {
        public int EmployeeNumber { get; set; }
    }
    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(" Added : "+person.FirstName);
        }
    }
}
