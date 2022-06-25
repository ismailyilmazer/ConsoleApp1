using System;

namespace DegerVeReferans
{
    class Deger
    {
        static void Main(string[] args)
        {
            int sayi1 = 50;
            int sayi2 = 60;
            sayi1 = sayi2;
            sayi2 = 40;
            Console.WriteLine(sayi1);

            int[] sayilar=new int[] {2,3};
            int[] sayilar2 = new int[] { 4, 6 };
            sayilar = sayilar2;

            sayilar2[1] = 11;
            Console.WriteLine(sayilar[1]);


        }
    }
}
