using GameService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameService.Abstract
{
    public interface ICampaignService
    {
        void CampaignAdd(Campaign campaign);
        void CampaignDelete(Campaign campaign);
        void CampaignUpdate(Campaign campaign);
    }
}
