using GameOyun2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameOyun2.Abstract
{
    interface IOrderService
    {
        void Order(Customer customer, Game game, Campaign campaign);
    }
}
