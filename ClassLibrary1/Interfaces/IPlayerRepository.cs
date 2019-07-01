using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IPlayerRepository
    {
        Task<IEnumerable<Entities.Player>> GetAllPlayers();
        Task<Entities.Player> AddPlayer(string name, string email);
        Task<Entities.Player> GetPlayer(long id);
    }
}