using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusEkle(Musteri musteri)
        {
            Console.WriteLine("Yeni müşteri eklendi " + musteri.Ad + " " + musteri.Soyad);
            Console.WriteLine("----------------------------------------");

        }
        public void MusSil(Musteri musteri)
        {  
            Console.WriteLine("Müşteri Idsi " + musteri.Id + " olan "+ musteri.Ad +" "+musteri.Soyad+" silindi.");
            Console.WriteLine("----------------------------------------");
        }

        public void MusListele(Musteri[] musteriler)
        {
            Console.WriteLine("----------------Müşteri Listesi--------------");
            foreach (Musteri musteri in musteriler)
            {
                
                Console.WriteLine("Adı:" + musteri.Ad);
                Console.WriteLine("Soyad:" + musteri.Soyad);
                Console.WriteLine("Adress:" + musteri.Adress);
                Console.WriteLine("----------------------------------------");
            }
        }
    }
}
