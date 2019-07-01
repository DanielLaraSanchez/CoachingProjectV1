using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IPoolChampionService
    {
        //Players
        Task<IEnumerable<Player>> GetAllPlayers();
        Task<Player> AddPlayer(string name, string email);
        //Games
        Task<IEnumerable<DataLayer.Entities.Game>> GetAllGames();
        Task<Game> CreateGame(DataLayer.Entities.Player player1, DataLayer.Entities.Player player2);
        Task<Game> Confirm(long id);
        //Ranking
        Task<IEnumerable<Score>> GetRanking(List<DataLayer.Entities.Game> games);
    }
}