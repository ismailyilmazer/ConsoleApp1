using System;

namespace sinif
{

    class newClass
    {
        static void Main(string[] args)
        {
            kurs kurs1 = new kurs();
            kurs1.kursAdi = "c#";
            kurs1.IzlenmeOrani = 87;
            kurs1.Egitmen = "ismail yilmazer";

            kurs kurs2 = new kurs();
            kurs2.kursAdi = "c#";
            kurs2.IzlenmeOrani = 87;
            kurs2.Egitmen = "ismail yilmazer";

            kurs kurs3 = new kurs();
            kurs3.kursAdi = "c#";
            kurs3.IzlenmeOrani = 87;
            kurs3.Egitmen = "ismail yilmazer";


            kurs[] kurslar = new kurs[] {kurs1,kurs2,kurs3};

            foreach (kurs s in kurslar)
            {
                Console.WriteLine(s.kursAdi);   
            }

            Console.WriteLine("ismail"); 
        }
        

    }

    class kurs
    {
        public string kursAdi { get; set; }
        public string Egitmen { get; set; }

        public int IzlenmeOrani { get; set; }

    }


}
