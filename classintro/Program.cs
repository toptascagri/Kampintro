using System;

namespace classintro
{
    class Program
    {
        static void Main(string[] args)
        {

            Kurs kurs1=new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin";

            Console.WriteLine(kurs1.KursAdi + ":" + kurs1.Egitmen);
        }
    }

    class Kurs 
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }

    }
}

