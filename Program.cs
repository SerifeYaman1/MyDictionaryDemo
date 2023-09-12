using System;

namespace MyDictionaryDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictinory = new MyDictionary<int, string>();  // MyDictinory nesnemizi tanımlıyoruz.
            myDictinory.Add(123, "FirstValue"); // overloading- aşırı yükleme yaparak iki defa Add yapabildik aynı adla.
            myDictinory.Add(234, "SecondValue");
            foreach (var key in myDictinory.Keys)
            {
                Console.WriteLine(key); // eklediğimiz anahtarları (keys) yazdırdık.
            }
            Console.ReadLine();
            foreach (var value in myDictinory.Values)
            {
                Console.WriteLine(value); // eklediğimiz değerleri (values) yazdırdık.
            }

        }
    }
}