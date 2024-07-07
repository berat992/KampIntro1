using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Engin Demiroğ
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "1234546789";

            // Kodlama İO şirketi
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
            // musteri classı hem gerçek hemde tüzel müşterinin


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1); // tikel
            musteriManager.Ekle(musteri2); // tüzel
            // Gördüğünüz gibi methodu hem şirket hemde 
            // tekil için kullanabiliyoruz. Çünkü müşteri baseclass
            // ve burada inheritance kavramı var
            




            // Gerçek - Tüzel 
            // Burada hata var.İkiside müşteri ama farklı müşteri tipleri
            // Burada inheritance sayesinde base class oluşturmak mantıklı
            // SOLID in L harfi

        }
    }
}

