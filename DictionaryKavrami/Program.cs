using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace DictionaryKavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1) Dictionary sınıfı içinde sizin belirleyeceğiniz bir key e uygun
             * olarak değer saklar
             * 2) Key türünü belirlemeniz şart(string,int vs....)
             * 
             */
            Dictionary<string, int> AdYas = new Dictionary<string, int>();
            // veri ekliyoruz
            AdYas.Add("Amy", 25);
            AdYas.Add("Mehmet", 17);
            AdYas.Add("Hale", 40);

            foreach (var item in AdYas)
            {
                Console.WriteLine(item);
            }

            // Değer sayma özelliği
            var elemanSayisi = AdYas.Count();
            Console.WriteLine("Eleman sayısı: " + elemanSayisi);

            // silme özelliği
            AdYas.Remove("Hale");
            foreach (var item in AdYas)
            {
                Console.WriteLine(item);
            }
            

            Console.ReadLine();
        }
    }

}