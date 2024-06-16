using System;
using System.Collections.Concurrent;

namespace KampIntro1
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i=1; i < 10; i++) // 1 dan başla. Şartım. i++ ise sayaçtır
            {
                Console.WriteLine(i);
                // Başlangıcı seç, kuralı yaz,sayacı ayarla
            }
            for (int i = 0; i < 13; i+=2) // i yi 2 2 arttır
            {
                Console.WriteLine(i);
            }

            // array = diziler
            string[] kurslar = new string[] {"C# Kursu","Java Kursu","Python kursu"};
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("Sayfa sonu");

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.ReadLine();
        }
    }

}