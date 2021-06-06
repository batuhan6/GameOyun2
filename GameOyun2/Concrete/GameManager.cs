using GameOyun2.Abstract;
using GameOyun2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameOyun2.Concrete
{
    class GameManager : IGameService
    {
        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " has been deleted from game list!");
        }

        public void Save(Game game)
        {
            Console.WriteLine(game.GameName + " has been added to game list!");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " has been updated!");
        }
    }
}
