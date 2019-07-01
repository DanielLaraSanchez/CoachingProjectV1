using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Entities;

namespace DataLayer
{
   public interface IGameRepository
    {
        Task<IEnumerable<Entities.Game>> GetAllGames();
        Task<Entities.Game> GetGame(long id);
        Task<Entities.Game> AddGame(Player player1, Player player2);

    }
}
