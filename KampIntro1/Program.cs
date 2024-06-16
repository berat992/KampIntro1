using System;
using System.Collections.Concurrent;

namespace KampIntro1
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            Console.WriteLine(kategoriEtiketi);

            int ogrenciSayisi = 32000;
            Console.WriteLine(ogrenciSayisi);

            double faizOrani = 1.45;
            Console.WriteLine("Faiz oranı : " + faizOrani);

            bool sistemGiris = false;
            if (sistemGiris == true)
            {
                Console.WriteLine("Giriş Yapıldı");
            }
            else
            {
                Console.WriteLine("Giriş yapılmadı");
            }

            double dolarDun = 7.35;
            double dolarBugun = 7.45;
            if (dolarBugun > dolarDun)
            {
                Console.WriteLine("Dolar arttı");
            } else if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Dolar azaldı");
            }
            else
            {
                Console.WriteLine("Dolar arttı");
            }






            Console.ReadLine();
        }
    }
}