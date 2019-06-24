using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IPoolChampionService
    {
        Task<IEnumerable<Player>> GetAllPlayers();
        Task CreateGame();

        Task<Game> Confirm(long id);
        Task<Player> AddPlayer(string name, string email);

        Task<IEnumerable<Score>> GetRanking();
    }
}