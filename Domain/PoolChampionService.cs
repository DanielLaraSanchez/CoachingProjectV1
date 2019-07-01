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

        public Task<Game> Confirm(long playerId, long gameId)
        {
            var player = _playerRepository.GetPlayer(playerId);
            var game = _gameRepository.GetGame(gameId);
            player.

            return null;
        }

        public Task<Game> CreateGame(DataLayer.Entities.Player player1, DataLayer.Entities.Player player2)
        {
             _gameRepository.AddGame(player1, player2);

            return null;
        }

        public async Task<IEnumerable<Player>> GetAllPlayers()
        {
            var players = await _playerRepository.GetAllPlayers();

            return players.Select(ToDomainPlayer);

        }

 

        public Task<IEnumerable<Score>> GetRanking(List<DataLayer.Entities.Game> games)
        {

            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<DataLayer.Entities.Game>> GetAllGames()
        {
            var games = await _gameRepository.GetAllGames();
            return games;
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

        public static Domain.Game ToDomainGame(DataLayer.Entities.Game game)
        {
            return new Domain.Game(ToDomainPlayer(game.Player1), ToDomainPlayer(game.Player2));
           
        }

    }




}