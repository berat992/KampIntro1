using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class CustomerManager
    {
        // CRUD
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.CustomerName + " adlı müşteri eklendi");
        }
        public void Read (Customer customer)
        {
            Console.WriteLine(customer.CustomerName + " adlı müşteri okundu");
        }
        public void Update(Customer customer)
        {
            Console.WriteLine(customer.CustomerName + " adlı müşteri güncellendi");
        }
        public  void Delete(Customer customer)
        {
            Console.WriteLine(customer.CustomerName + " adlı müşteri silindi");
        }
    }
}
