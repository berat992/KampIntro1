using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace GenericsIntro
{
    class MyList<T> // Buradaki T herhangi bir tür ile çalışabileceğini gösterir. Int,string,herhangi bir class vs vs
    { // Böylelikle farklı türkler ekleyebilirsin. Çünkü örneğin list fonksiyonunda tek tür değil o an ihtiyacımız neyse onu koyarız. <> çalışacağımız tipi ifade eder 
        T[] items;
        public MyList() // constructor = class newlendiğinde otomatik çalışır
        {
            items = new T[0];
        }
        public void Add(T item) // herhangi bir tür
        {
            T[] tempArray = items; // az sonra new lenip önceki değerler gitmesin diye referans tutucu kullanırız
            items = new T[items.Length + 1]; // dizinin eleman sayısını bir arttır
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
        }
    }
}
