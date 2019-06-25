using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    interface IGameRepository
    {
        Task<IEnumerable<Entities.Game>> GetAllGames();
        Task<Entities.Game> AddGame();

    }
}
