using Metotlar;
using System;
using System.Collections.Concurrent;

namespace KampIntro1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.UrunAdi = "Çilek";
            product1.Fiyati = 15;
            product1.Aciklama = "Çilek gibi çilek";


            Product product2 = new Product();
            product2.Id = 2;
            product2.UrunAdi = "Elma";
            product2.Aciklama = "Amasyadan elmalar";
            product2.Fiyati = 12;

            Product[] products = new Product[] {product1,product2};
            foreach (Product product in products)
            {
                Console.WriteLine(product.UrunAdi);
                Console.WriteLine(product.Id);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine("-------------------");
            }

            Console.WriteLine("**********METOTLAR************");
            SepetManager sepetManager = new SepetManager() { };
            sepetManager.Ekle(product2);
           

            // Encapculation : Parametreleri yazarken tek tek tür yazmak yerine
            // class kullanmaya denir. Böylelikle yeni bir özellik eklenince
            // sistem patlamaz.



            Console.ReadLine();
        }
    }
}

// Metotlar do not repeat yourself i sağlar 
