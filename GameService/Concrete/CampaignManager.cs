using GameService.Abstract;
using GameService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameService.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void CampaignAdd(Campaign campaign)
        {
            Console.WriteLine("Added : " + campaign.CampaignName);
        }

        public void CampaignDelete(Campaign campaign)
        {
            Console.WriteLine("Deleted : " + campaign.CampaignName);
        }

        public void CampaignUpdate(Campaign campaign)
        {
            Console.WriteLine("Updated : " + campaign.CampaignName);
        }
    }
}
