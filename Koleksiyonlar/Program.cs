using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<>
            List<string> isimler2 = new List<string>() { "Engin","Murat","Kerem","Halil "};
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);

            List<int> sayilar = new List<int>() { };
            List<bool> bools = new List<bool>() { };

            Console.ReadLine();
        }
    }

}