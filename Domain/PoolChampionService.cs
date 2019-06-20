using DataLayer;
using Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class PoolChampionService : IPoolChampionService
    {
        public PoolChampionService(IDataRepository repository)
        {
            this.repository = repository;
        }
        private readonly IDataRepository repository;//what is this going to be and how in the concrete implementation? this should be its own project in realllity right?

        public async Task<Player> AddPlayer(string name, string email)
        {

            await repository.AddPlayer(name, email);
            return null;
        }

        public Task<Game> Confirm(long id)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateGame()
        {
            throw new System.NotImplementedException();
        }

        public async Task<Player> GetAllPlayers()
        {
           return await repository.GetAllPlayers().Select(x => new Player(x.Name));
            
        }

        public Task<IEnumerable<Score>> GetRanking()
        {
            throw new System.NotImplementedException();
        }
    }
}