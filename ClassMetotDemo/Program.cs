using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Luke";
            musteri1.Soyad = "Skywalker";
            musteri1.Adress = "Tatooine";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Leia";
            musteri2.Soyad = "Organa Skywalker";
            musteri2.Adress = "Alderaan";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "Darth";
            musteri3.Soyad = "Vader";
            musteri3.Adress= "Tatooine";

            Musteri[] musteriler = new Musteri[] {musteri1,musteri2,musteri3 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusListele(musteriler);
            musteriManager.MusEkle(musteri3);
            musteriManager.MusSil(musteri2);

            Console.WriteLine("Hello World!");
        }
    }
}
