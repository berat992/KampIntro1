using System;
using System.Collections.Concurrent;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 100;
            product1.UnitsInStock = 10;

            Product product2 = new Product();
            product1.Id = 2;
            product1.CategoryId = 3;
            product1.ProductName = "Lamba";
            product1.UnitPrice = 35;
            product1.UnitsInStock = 50;

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Add(product2);

            Console.ReadLine();
        }
    }
}

