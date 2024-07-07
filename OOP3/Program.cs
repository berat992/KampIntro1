using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafKrediManager = new EsnafKredisiManager();
            IKrediManager mortgageKrediManager = new MortgageKredisiManager();

            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(tasitKrediManager);
            //basvuruManager.BasvuruYap(konutKrediManager);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager };
            basvuruManager.KrediOnBilgilendirmesiYap(krediler);

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new DatabaseLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();
            ILoggerService mailLoggerService = new MailLoggerService();

            basvuruManager.BasvuruYap(konutKrediManager, databaseLoggerService);
            basvuruManager.BasvuruYap(tasitKrediManager, fileLoggerService);
            basvuruManager.BasvuruYap(esnafKrediManager, databaseLoggerService);
            basvuruManager.BasvuruYap(tasitKrediManager, smsLoggerService);
            basvuruManager.BasvuruYap(mortgageKrediManager, mailLoggerService);


            Console.ReadLine();
            // Demek ki interface ler de implemente ettiği classın referans
            // numarasını tutabiliyormuş
        }
    }
}

