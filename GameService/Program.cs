using GameService.Abstract;
using GameService.Concrete;
using GameService.Entities;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;

namespace GameService
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager();
            Gamer gamer1 = new Gamer();
            gamer1.Id = 1;
            gamer1.FirstName = "Berat";
            gamer1.LastName = "Doğan";
            gamer1.NationalityId = "11111111111";

            Gamer gamer2 = new Gamer();
            gamer1.Id = 2;
            gamer1.FirstName = "Esra";
            gamer1.LastName = "Polat";      
            gamer1.NationalityId = "22222222222";

            gamerManager.Add(gamer1);
            gamerManager.Delete(gamer2);
            gamerManager.Update(gamer2);

            Campaign campaign = new Campaign();
            campaign.CampaignId = 1;
            campaign.CampaignName = "Yaz İndirimi";
            campaign.CampaignCost = 10;

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.CampaignAdd(campaign);

            GamerCheckManager gamerCheckManager = new GamerCheckManager();
            gamerCheckManager.Control(gamer1);
            gamerCheckManager.Control(gamer2);

            Console.ReadLine();


        }
    }

}

