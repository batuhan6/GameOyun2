using GameOyun2.Abstract;
using GameOyun2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameOyun2.Concrete
{
    class OrderManager : IOrderService
    {
        public void Order(Customer customer, Game game, Campaign campaign)
        {
            int campaignPrice = game.GamePrice - (game.GamePrice * campaign.DiscountRate / 100);
            Console.WriteLine
                ("The game which is " + game.GameName + " has been bought by " + customer.FirstName + " with " + campaign.CampaignName + " to " + campaignPrice);
        }
    }
}
