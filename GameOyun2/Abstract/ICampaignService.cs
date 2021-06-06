using GameOyun2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameOyun2.Abstract
{
    interface ICampaignService
    {
        void Save(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);
    }
}
