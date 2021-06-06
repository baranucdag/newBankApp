using System;
using System.Collections.Generic;

namespace InterfaceBirlestirme
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager taşıtkrediManager = new TasıtKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager esnafKrediManager = new EsnafKrediManager();

            ILoggerManager dataBaseLogger = new DatabaseLoggerService();
            ILoggerManager fileLogger = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.Basvuru(taşıtkrediManager,dataBaseLogger);
            basvuruManager.Basvuru(ıhtiyacKrediManager,fileLogger);
            basvuruManager.Basvuru(esnafKrediManager,dataBaseLogger);
            basvuruManager.Basvuru(esnafKrediManager,new SmsLoggerService());   //farklı bir class newleme şekli


            /* List<IKrediManager> krediller = new List<IKrediManager>() { ıhtiyacKrediManager, taşıtkrediManager, konutKrediManager };
             basvuruManager.basvuruOnBilgilendirme(krediller);       //buradaki başvurularda ise birden fazla başvuru alınıyor.*/


            Console.ReadLine();
        }
    }
}
