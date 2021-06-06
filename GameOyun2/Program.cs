using GameOyun2.Adapters;
using GameOyun2.Concrete;
using GameOyun2.Entities;
using System;

namespace GameOyun2
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                Id = 1,
                FirstName = "Buket",
                LastName = "Baykal",
                NationalityId = "544234245",
                DateOfBirth = new DateTime(1933, 3, 8)
            };
            CustomerManager customerManager = new CustomerManager(new MernisServiceAdapter());
            customerManager.Save(customer1);

            Console.WriteLine("-------------");
            Game game1 = new Game()
            {
                Id = 1,
                GameName = "Counter-Strike Global Offensive",
                GamePrice = 79
            };
            GameManager gameManager = new GameManager();
            gameManager.Save(game1);

        }
    }
}
