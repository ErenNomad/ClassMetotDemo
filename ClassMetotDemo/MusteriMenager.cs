using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        

        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.AdiSoyadi + " " + " adındaki müşteri sisteme eklendi.");
        }

        public void MusteriListele(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Musteri Adi Soyadi: " + musteri.AdiSoyadi);
                Console.WriteLine("Musteri Bakiyesi=" + musteri.bakiye);              
                Console.WriteLine("Musteri Yasi: " + musteri.yas);
                Console.WriteLine("Musteri Kimlik Id= " + musteri.Id);
            }
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.AdiSoyadi + " " +  " adlı müşteri bilgileri sistemden silindi.");
        }
    }
}

