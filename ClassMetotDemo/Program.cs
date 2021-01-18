using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 123456789;
            musteri1.Adi = "Ali";
            musteri1.Soyadi = "Yılmaz";
            musteri1.yasi = 45;


            Musteri musteri2 = new Musteri();
            musteri2.Id = 543456780;
            musteri2.Adi = "Ayşe";
            musteri2.Soyadi = "Kaya";
            musteri2.yasi = 38;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 854656701;
            musteri3.Adi = "Mehmet";
            musteri3.Soyadi = "Koç";
            musteri3.yasi = 25;


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2,musteri3};

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            Console.WriteLine("----------------------------");

            musteriManager.Cikar(musteri1);
            musteriManager.Cikar(musteri2);
            musteriManager.Cikar(musteri3);
            Console.WriteLine("----------------------------");

            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);
            musteriManager.Listele(musteri3);
            Console.WriteLine("----------------------------");



            //Console.WriteLine("Hello World!");
        }
    }
}
