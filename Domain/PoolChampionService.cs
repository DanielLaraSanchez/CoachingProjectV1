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
            var player = await _playerRepository.AddPlayer(name, email);
            return ToDomainPlayer(player);
            
        }

        public async Task<Game> Confirm(long playerId, long gameId)
        {
            var player = await _playerRepository.GetPlayer(playerId);
            var game = await  _gameRepository.GetGame(gameId);

            var domainPlayer = ToDomainPlayer(player);
            var domainGame = ToDomainGame(game);

            domainPlayer.ConfirmGame(domainGame);

            
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

 

        public  IEnumerable<Score> GetRanking(List<DataLayer.Entities.Game> games)
        {
            List<Domain.Game> domainGames = new List<Domain.Game>();
            
            foreach (var game in games)
            {
                Domain.Game domainGame = ToDomainGame(game);
                domainGames.Add(domainGame);
            }
            Ranking ranking = new Ranking();
            var scores = ranking.CalculateScores(domainGames);

            return scores;
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
            return new Domain.Game(ToDomainPlayer(game.Player1), ToDomainPlayer(game.Player2))
            {
                Winner = ToDomainPlayer(game.Winner),
                IsConfirmed = game.IsConfirmed,
                TimeStamp = game.CreationTimeStamp,
                Creator = ToDomainPlayer(game.Creator)
            };

        }

    }




}