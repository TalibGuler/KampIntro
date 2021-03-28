using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();           
            IKrediManager tasitKrediManager = new TasitKrediManage();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager,databaseLoggerService);
            //basvuruManager.BasvuruYap(konutKrediManager);
            //basvuruManager.BasvuruYap(tasitKrediManager);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager,konutKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

            
        }
    }
}
