﻿using System;
using System.Collections.Concurrent;

namespace KampIntro1
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 10000;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Python";
            kurs2.Egitmen = "Berat Doğan";
            kurs2.IzlenmeOrani = 100000;

            Console.WriteLine(kurs1.KursAdi);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.Egitmen);
            }
            Console.ReadLine();
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}