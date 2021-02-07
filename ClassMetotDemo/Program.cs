using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.AdiSoyadi = "Eren Yörük";
            musteri1.Id = 72347356;
            musteri1.bakiye = 802790;
            musteri1.yas = 25;

            Musteri musteri2 = new Musteri();
            musteri2.AdiSoyadi = "Burak Erşan";
            musteri2.Id = 23451361;
            musteri2.bakiye = 612671;
            musteri2.yas = 16;

            Musteri musteri3 = new Musteri();
            musteri3.AdiSoyadi = "Furkan Dağüstü";
            musteri3.Id = 54163844;
            musteri3.bakiye = 5620;
            musteri3.yas = 30;

            Musteri musteri4 = new Musteri();
            musteri4.AdiSoyadi = "Kayra Özdemir";
            musteri4.Id = 23163844;
            musteri4.bakiye = 568820;
            musteri4.yas = 15;


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3,musteri4 };

            foreach (var musteri in musteriler)
            {
                Console.Write(musteri.AdiSoyadi + "----");
                Console.Write("Id = " +musteri.Id+"---- ");
                Console.WriteLine("Bakiye= " +musteri.bakiye + "TL");
                Console.WriteLine(musteri.yas + "yaşında");
               
            }


        }
    }
}
