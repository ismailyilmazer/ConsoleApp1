using System;

namespace Donguler
{
    class program
    {
        public static void Main(string[] args)
        {
            string kurs1 = "ismail";
            string kurs2 = "yilmazer";
            string kurs3 = "baskan";

            string[] kurslar = new string[] { kurs1,kurs2,kurs3 };

            int length = 10;
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            foreach (string kurs in kurslar)//diizleri tek tek dolaşmaya yarıyor
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
