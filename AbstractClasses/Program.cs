using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            AMevzuat aMevzuat = new AMevzuat();
            aMevzuat.Kaydet();
            aMevzuat.Degerlendir();
        }
    }
    // abstract class 
    abstract class MevzuatBase
    {
        public abstract void Degerlendir();
        public void Kaydet()
        {
            Console.WriteLine("Kaydedildi");
        }
    }
    class AMevzuat : MevzuatBase
    {
        public override void Degerlendir() // A
        {
            Console.WriteLine("A mevzuatına göre değerlendirildi");
        }
    }
    class BMevzuat : MevzuatBase
    {
        public override void Degerlendir()
        {
            Console.WriteLine("B mevzuatına göre değerlendirildi");
        }
    }


    public class CustomerManager
    {
        public void Add() 
        {
            Console.WriteLine("Added");
        }
        public void Delete()
        {
            Console.WriteLine("Deleted");
        }
        
    }
    public class Customer 
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

