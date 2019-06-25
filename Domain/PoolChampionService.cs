using DataLayer;
using Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Domain
{
    public class PoolChampionService : IPoolChampionService
    {

        private readonly IPlayerRepository _player_repository;

        public PoolChampionService(IPlayerRepository repository)
        {
            _player_repository = repository;
        }

        public async Task<Player> AddPlayer(string name, string email)
        {
            await _player_repository.AddPlayer(name, email);
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
            var result = await _player_repository.GetAllPlayers();

            return result.Select(ToDomainPlayer);

        }

 

        public Task<IEnumerable<Score>> GetRanking()
        {

            throw new System.NotImplementedException();
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
    }




}