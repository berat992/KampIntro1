using Matematik;
using System;
using System.Collections.Concurrent;

namespace KampIntro1
{
    class Program
    {
        static void Main(string[] args)
        {

            DortIslem dortıslem = new DortIslem();
            dortıslem.Topla(10, 10.5);

            Console.ReadLine();
        }
    }
}

