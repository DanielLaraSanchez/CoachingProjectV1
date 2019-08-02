using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IPoolChampionService
    {
        //Players
        Task<IEnumerable<Player>> GetAllPlayers();
        Task<Player> AddPlayer(string name, string emailAddress, string password);
        //Games
        Task<IEnumerable<DataLayer.Entities.Game>> GetAllGames();
        Task<DataLayer.Entities.Game> CreateGame(Domain.Game game);
        Task<Game> Confirm(long playerId, long gameId);
        //Ranking
        Task<IEnumerable<Score>> GetRanking();
        Task<DataLayer.Entities.Player> GetPlayerLoggedIn(string emailAddress, string password);
    }
}