using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            Product urun1=new Product();
            urun1.Aciklama = "Amasya Elması";
            urun1.Adi = "Elma";
            urun1.Fiyati = 14;


            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 49;
            urun2.Aciklama = "Diyarbakır Kapuzu";

            Product[] urunler = new Product[] {urun1,urun2};
            //type-safe
            foreach (Product product in urunler)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine("--------------------");
            }
            Console.WriteLine("-------Metodlar------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);


            sepetManager.Ekle2("Armut","Yesil Armut",13);
        }
    }
}
