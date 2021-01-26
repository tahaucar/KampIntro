using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void ekle(Musteri musteri)
        {
            Console.WriteLine(" Müşteri bilgileri eklendi ! " + musteri.Ad);
        }

        public void güncelle(Musteri musteri)
        {
            Console.WriteLine(" Müşteri bilgileri güncellendi ! " + musteri.Ad);
        }

        public void sil(Musteri musteri)
        {
            Console.WriteLine(" Müşteri bilgileri silindi ! " + musteri.Ad);
        }
    }
}
