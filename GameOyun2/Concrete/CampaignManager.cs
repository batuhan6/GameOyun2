using GameOyun2.Abstract;
using GameOyun2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameOyun2.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " has been deleted from campaign list!");
        }

        public void Save(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " has been saved to campaign list!");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " has been updated!");
        }
    }
}
