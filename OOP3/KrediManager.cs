using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{ // interface = kalıp kuralları belirler
    public interface IKrediManager // Alttaki metotlar her kredi türünde olmak zorunda
    { // implemente etmek
        public void Hesapla(); // bir sürü kredi türü var

        public void BiseyYap();
    }
    // Her kredi türü bir kredidir ancak farklı dosya masrafları ve
    // faiz oranları vardır. Bu yüzden interface kullanırız
    // Başa gelen I kelimesi bize interface olduğunu gösterir
}
