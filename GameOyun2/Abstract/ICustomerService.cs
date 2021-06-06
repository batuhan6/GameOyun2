using GameOyun2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameOyun2.Abstract
{
    interface ICustomerService
    {
        void Save(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
    }
}
