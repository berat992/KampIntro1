using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public class BasvuruManager // Kredi başvurularını alan class
    {
        public void BasvuruYap(IKrediManager krediManager,ILoggerService loggerService) // logger ile kayıt alma
        {
            // Başvuran bilgilerini alırız ve değerlendiririz
            // Olumlu olursa kredi de hesaplarız
            // mesela olumlu geçti dersek hesaplama metodu çalışır
            // Burada sadece konut,taşıt denmez. Tüm kredi türleri
            // olabileceği için ıkredi kullanılır

            krediManager.Hesapla();
            loggerService.Log();
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler) 
        // İster 1 ister 1000 tane kredinin faizli tutarını gösterebilir ekranda. Müşteriyi ön bilgilendirmek için
        {
            // Verdiğin tür liste türünde ister 1 ister 1000 elemanlı
            foreach (var item in krediler)
            {
                item.Hesapla();
            }
        }
    }
}

