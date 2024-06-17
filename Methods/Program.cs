using System;
using System.Collections.Concurrent;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add2(90, 30);
            Add2();

            //int number1 = 20;
            //int number2 = 100;
            //var result = Add3(ref number1,number2); 
            //Console.WriteLine(result);
            //Console.WriteLine(number1);

            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply(2, 3, 4));

            Console.WriteLine(Add4(1,2,33,43,43));

            Console.ReadLine();
        }
        static void Add()
        {
            Console.WriteLine("Added!!!!!!");
        }
        static void Add2(int number3 = 10, int number4 = 30) // Eğer number3/number4 verilmeze default değer olarak 30 alınır
        {
            int result = number3 + number4;
            Console.WriteLine(result);
        }
        static int Add3(ref int number1, int number2)
        {
            number1 = 30; // Üstteki number1 gerçek number1 i etkilemez
            // Bu yüzden 30 olsa bile sonradan number1 çağrıldığında hala 20 dir
            // Eğer number1 in etkilenmesini istiyorsak ref keyword u kullanırız
            return number1 + number2;
        }
        // out ve ref farkı : Out da number1 in illa değerinin olmasına gerek yok
        // Yani ref kullanırken illa ki o değişkenin zaten değerinin olması gerek

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2, int number3) // metot overloading
        {
            return number1 * number2;
        }
        static int Add4(int number1, int number2)
        {
            return number1 + number2;
        }
        static int Add4(params int[] numbers)
        {
            return numbers.Sum(); // TOPlama = sum
        }
        // Burada örneğin bir hesap makinesinde bir sürü fazladan metot overlading yapmamız gerke
        // Sınırsız sayı yazma olan hesap makinesinde tek tek number yazmak yorucu olur
        // Bunun için params keywordu kullanılır 

    }
}

