using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri()
            {
                Id = 1, Ad = "Zeynel Taha", Soyad = "UÇAR", TCNo = "21412533434", TelNo = "05434353456"
            };

            Musteri musteri2= new Musteri()
            {
                Id = 2, Ad = "M.Kerem", Soyad = "UÇAR", TCNo = "213254325235", TelNo = "05463453434"
            };
            Musteri musteri3=new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "Ahmet";
            musteri3.Soyad = "UÇAR";
            musteri3.TCNo = "11232134235346";
            musteri3.TelNo = "05434343434";

            Musteri[] musteriler= new Musteri[]{musteri1,musteri2,musteri3};
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Id + " " + musteri.Ad + " " + musteri.Soyad + " " + musteri.TCNo + " " + musteri.TelNo);
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.ekle(musteri1);
            musteriManager.sil(musteri2);
            musteriManager.güncelle(musteri3);
        }
    }
}
