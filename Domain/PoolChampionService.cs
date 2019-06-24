using DataLayer;
using Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Domain
{
    public class PoolChampionService : IPoolChampionService
    {

        private readonly IDataRepository _repository;

        public PoolChampionService(IDataRepository repository)
        {
            _repository = repository;
        }

        public async Task<Player> AddPlayer(string name, string email)
        {
            await _repository.AddPlayer(name, email);
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

        public async Task<IEnumerable<Player>> GetAllPlayers()
        {
            var result = await _repository.GetAllPlayers();

            return result.Select(ToDomainPlayer);

        }

        public static DataLayer.Entities.Player ToEntityPlayer(Domain.Player player)
        {
            return new DataLayer.Entities.Player()
            {
                Name = player.Name,
                EmailAddress = player.EmailAddress
            };
        }

        public static Domain.Player ToDomainPlayer(DataLayer.Entities.Player player)
        {
            return new Domain.Player(player.Name, player.EmailAddress)
            {
                Id = player.PlayerId
            };


        }

        public Task<IEnumerable<Score>> GetRanking()
        {
            throw new System.NotImplementedException();
        }
    }
}