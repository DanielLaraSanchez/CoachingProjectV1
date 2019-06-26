using DataLayer;
using Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Domain
{
    public class PoolChampionService : IPoolChampionService
    {

        private readonly IPlayerRepository _playerRepository;
        private readonly IGameRepository _gameRepository;

        public PoolChampionService(IPlayerRepository repository, IGameRepository gameRepository)
        {
            _playerRepository = repository;
            _gameRepository = gameRepository;
        }

        public async Task<Player> AddPlayer(string name, string email)
        {
            await _playerRepository.AddPlayer(name, email);
            return null;
        }

        public Task<Game> Confirm(long id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Game> CreateGame(Player player1, Player player2)
        {
            var entitiePlayer1 = ToEntityPlayer(player1);
            var entitiePlayer2 = ToEntityPlayer(player2);
             _gameRepository.AddGame(entitiePlayer1, entitiePlayer2);
            return null;
        }

        public async Task<IEnumerable<Player>> GetAllPlayers()
        {
            var players = await _playerRepository.GetAllPlayers();

            return players.Select(ToDomainPlayer);

        }

 

        public Task<IEnumerable<Score>> GetRanking()
        {

            throw new System.NotImplementedException();
        }
        


        //Tools

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