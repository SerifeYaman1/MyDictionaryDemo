using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionaryDemo
{
    class MyDictionary<TKey, TValue> //class'taki parametrelerimiz
    {
        TKey[] keys;      // keys ve values adında bir dizi ekliyoruz                        
        TValue[] values;  // classtaki tüm metotların erişebileceği şekilde.
        public MyDictionary() // constructor yapısı ekliyoruz.(Class'ı new'lediğimiz zaman çalışacak bloktur.)
        {
            keys = new TKey[0];     // keysleri ve valueleri 0.indeksten başlatıyoruz.
            values = new TValue[0];
        }
        public void Add(TKey key, TValue value)
        {
            TKey[] tempKey = keys;         // geçici değişkenlere atıyoruz gelen değerden sonra eski değerlerimiz silinmesin diye.
            TValue[] tempValue = values;
            keys = new TKey[tempKey.Length + 1]; // geçici key değer sayısımızın 1 fazlasını keys'e atıyoruz.
            values = new TValue[tempValue.Length + 1];// geçici value değer sayımızı 1 fazlasını values' e atıyoruz.
            for (int i = 0; i < tempKey.Length; i++)
            {
                keys[i] = tempKey[i];  // geçici keyimizi yani önceki keylerimizi yeni dizimize atıyoruz.
            }
            keys[keys.Length - 1] = key; // yeni key'imizi keys dizimizin son key kısmına ekliyoruz.
            for (int j = 0; j < tempValue.Length; j++)
            {
                values[j] = tempValue[j]; // geçici valuesimi yani önceki değerlerimizi yeni dizimize atıyoruz.
            }
            values[values.Length - 1] = value; // yeni value' mizi values dizimizin son değerine atıyoruz.

        }
        public TKey[] Keys { get { return keys; } } // foreach yazarken keys değerlerini yazdırabilmemizi sağlar.
        public TValue[] Values { get { return values; } } // foreach yazarken values değerlerini yazdırabilmemizi sağlar.

    }
}
