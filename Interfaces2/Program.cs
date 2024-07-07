using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;

namespace Interfaces2
{
    class Program
    {
        static void Main(string[] args)
        {
            IPersonManager personManager = new CustomerManager();
            IPersonManager employeeManager = new EmployeeManager();

            personManager.Add();
            employeeManager.Update();
            
        }
    }
    public interface IPersonManager
    {
        void Add(); // imza
        void Update();
        // Aslında interface bir şablondur
        // Buradaki Add bir şablondur
        // İçine istediğini yazarsın (customer,employee vs vs )
        
    }
    public class CustomerManager : IPersonManager // kendi özelliklerine ek olarak personManager ın özelliklerini de alır
    {
        public void Add()
        {
            // müşteri ekleme kodları
            Console.WriteLine("Müşteri eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri güncellendi");
        }
    }
    public class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            // personel ekleme kodları
            Console.WriteLine("Personel eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Personel güncellendi");
        }
    }

}

