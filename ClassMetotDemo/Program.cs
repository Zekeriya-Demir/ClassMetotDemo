using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Ali";
            musteri1.Soyad = "Demir";
            musteri1.TcNo = "1234567892";

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Ahmet";
            musteri2.Soyad = "Şahin";
            musteri2.TcNo = "34512345874";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriSil(musteri1);

            Musteri[] musteri = new Musteri[]
            {
                musteri1,musteri2
            };

            musteriManager.MusteriListele(musteri);
        }
    }
}
