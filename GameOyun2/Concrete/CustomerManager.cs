using GameOyun2.Abstract;
using GameOyun2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameOyun2.Concrete
{
    class CustomerManager : ICustomerService
    {
        ICustomerCheckService _customerCheckService;

        public CustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.FirstName + ", your account has been deleted!");
        }

        public void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                Console.WriteLine(customer.FirstName + ", your account has been saved!");
            }
            else
            {
                Console.WriteLine(customer.FirstName + ", your account hasn't been saved because you are not a valid person!");
                // throw new Exception("Not a valid person!");
            }

        }

        public void Update(Customer customer)
        {
            Console.WriteLine(customer.FirstName + ", your account has been updated!");
        }
    }
}

