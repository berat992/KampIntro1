using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;

namespace Interfaces3
{
    class Program
    {
        static void Main(string[] args)
        {
            IPersonManager customerManager = new CustomerManager();
            IPersonManager employeeManager = new EmployeeManager();

            customerManager.Add();
            employeeManager.Update();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(customerManager);
            projectManager.Add(employeeManager);

            IPersonManager ınternManager = new InternManager();
            ınternManager.Add();



        }
        public interface IPersonManager
        {
            void Add();
            void Update();
        }
        public class CustomerManager : IPersonManager // custoemer aynı zamanda personun özelliklerine ve üyelerine sahip
        {
            public void Add()
            {
                Console.WriteLine("Müşteri eklendi");
            }

            public void Update()
            {
                Console.WriteLine("Müşteri güncellendi");
            }
        }
        public class InternManager : IPersonManager
        {
            public void Add()
            {
                Console.WriteLine("Stajyer eklendi");
            }

            public void Update()
            {
                Console.WriteLine("Stajyer güncellendi");
            }
        }
        public class EmployeeManager : IPersonManager // implements olayı
        {
            public void Add()
            {
                Console.WriteLine("İşçi eklendi");
            }

            public void Update()
            {
                Console.WriteLine("İşçi güncellendi");
            }
        }
        public class ProjectManager
        {
            public void Add(IPersonManager personManager) // Gelen belli olmadığı için IPersonManager
            {

            }
        }
    }
}

