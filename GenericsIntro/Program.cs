using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // generic class larda çalışacağın türü söylemen gerek 
            MyList<string> isimler = new MyList<string>();
            MyList<int> sayilar = new MyList<int>();
            MyList<bool> boolens = new MyList<bool>() { };
            isimler.Add("Berat");
            sayilar.Add(20);

            Console.ReadLine();
        }
    }

}