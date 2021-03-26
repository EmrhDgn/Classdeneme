using System;

namespace ClassTry
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string adi = "Engin";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursEgitmeni = "Engin";
            kurs1.KursAdi = "C#";
            kurs1.IzlenmeOrani = 60;

            Kurs kurs2 = new Kurs();
            kurs2.KursEgitmeni = "Emrah";
            kurs2.KursAdi = "Python";
            kurs2.IzlenmeOrani = 70;

            Kurs kurs3 = new Kurs();
            kurs2.KursEgitmeni = "Hasan";
            kurs3.KursAdi = "Java";
            kurs3.IzlenmeOrani = 90;


            Console.WriteLine(kurs1.KursAdi + " " + kurs1.KursEgitmeni + " " + kurs1.IzlenmeOrani + " emrah");

            Console.WriteLine(kurs3.KursAdi + " " + kurs3.IzlenmeOrani + " emrah");
            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
            }
        }
    }
    // class = struct bir nevi
    class Kurs
    {
        public string KursAdi { get; set; }

        public string KursEgitmeni { get; set; }

        public int IzlenmeOrani { get; set; }
    }
}
