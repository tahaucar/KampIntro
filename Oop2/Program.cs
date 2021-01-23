using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMüsteri musteri1 = new GercekMüsteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Zeynel Taha";
            musteri1.Soyadi = "UÇAR";
            musteri1.TcNo = "1242134235";


            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "123456";
            musteri2.SirketAdi = "Kodlama.İo";
            musteri2.VergiNo = "21341245132";


            Musteri musteri3= new GercekMüsteri();
            Musteri musteri4= new TuzelMusteri();


            CustomerManager customerManager= new CustomerManager();
            customerManager.Add(musteri1);

        }
    }
}
