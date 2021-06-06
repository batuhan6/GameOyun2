using GameOyun2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameOyun2.Abstract
{
    interface IGameService
    {
        void Save(Game game);
        void Update(Game game);
        void Delete(Game game);
    }
}
