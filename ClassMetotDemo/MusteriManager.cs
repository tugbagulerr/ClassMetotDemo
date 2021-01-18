using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Sisteme Eklendi!" + Environment.NewLine+ "Müşteri Adı: " +  musteri.Adi + " " + musteri.Soyadi + Environment.NewLine +"Müşteri Id: " + musteri.Id + Environment.NewLine + "Müşteri Yaşı: " +  musteri.yasi);
        }
        public void Cikar(Musteri musteri)
        {
            Console.WriteLine("Müşteri Sistemden Çıkarıldı: " + Environment.NewLine + "Müşteri Adı: "+ musteri.Adi + " " + musteri.Soyadi + Environment.NewLine + "Müşteri Id: " + musteri.Id + Environment.NewLine + "Müşteri Yaşı: " + musteri.yasi);
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Müşteri Bilgileri Listelendi: " + Environment.NewLine + "Müşteri Adı: "+ musteri.Adi + " " + musteri.Soyadi + Environment.NewLine + "Müşteri Id: " + musteri.Id + Environment.NewLine + "Müşteri Yaşı: " + musteri.yasi);
        }

    }
}
