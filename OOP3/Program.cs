using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager= new IhtiyacKrediManager();
            //ıIhtiyacKrediManager.Hesapla();

            IKrediManager tasitKrediManager=new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            IKrediManager konutKrediManager= new KonutKrediManager();
            //konutKrediManager.Hesapla();

            ILoggerService databaseLoggerService= new DatabaseLoggerService();
            ILoggerService fileLoggerService= new FileLoggerService();

            BasvuruManager basvuruManager=new BasvuruManager();
            basvuruManager.BasvuruYap(tasitKrediManager, fileLoggerService);

            List<IKrediManager> krediler = new List<IKrediManager>(){ihtiyacKrediManager, tasitKrediManager};
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
