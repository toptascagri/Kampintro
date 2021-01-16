using System;

namespace Kampintro
{
	class Program
	{
		static void Main(string[] args)
		{
			string kategorietiketi = "Kategori";
			int faizOrani = 3;
			bool sistemGirisi=true;

			if (sistemGirisi==true)
			{
				Console.WriteLine("Ayarlar Butonu");
		
			}

			string[] kurslar = new string[] { "Yazılım", "Programlama", "Dersi" };
			
			for (int i = 0; i < kurslar.Length; i++)
            {
				Console.WriteLine(kurslar[i]);
            }

			Console.WriteLine("Sayfa sonu");

            foreach (string kurs in kurslar)
            {
				Console.WriteLine(kurs);

            }
		
		}
	}
}
