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

        public async Task<Player> AddPlayer(string name, string emailAddress, string password)
        {
            var player = await _playerRepository.AddPlayer(name, emailAddress, password);
            return ToDomainPlayer(player);
            
        }

        public async Task<Game> Confirm(long playerId, long gameId)
        {
            var player = await _playerRepository.GetPlayer(playerId);
            var game = await  _gameRepository.GetGame(gameId);

            var domainPlayer = ToDomainPlayer(player);
            var domainGame = await ToDomainGame(game);

            domainPlayer.ConfirmGame(domainGame);

            
            return null;
        }

        public async Task<DataLayer.Entities.Game> CreateGame(Domain.Game game)
        {
            Game newDomainGame = new Game(game.Player1, game.Player2);
            newDomainGame.Creator = game.Creator;
            newDomainGame.Winner = game.Winner;
            DataLayer.Entities.Game newEntityGame = ToEntityGame(newDomainGame);
           
          var addedGame =  await _gameRepository.AddGame(newEntityGame);

            return addedGame;
        }

        public async Task<IEnumerable<Player>> GetAllPlayers()
        {
            var players = await _playerRepository.GetAllPlayers();

            return players.Select(ToDomainPlayer);

        }

 

        public async  Task<IEnumerable<Score>> GetRanking()
        {
            var games = await GetAllGames();

            List<Domain.Game> domainGames = new List<Domain.Game>();
            
            foreach (var game in games)
            {
                Domain.Game domainGame = await ToDomainGame(game);
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

        public async Task<DataLayer.Entities.Game> GetGame(long gameId)
        {
            DataLayer.Entities.Game game = await _gameRepository.GetGame(gameId);
            return game;
        }

        public async Task<DataLayer.Entities.Player> GetPlayer(long playerId)
        {
            DataLayer.Entities.Player player = await _playerRepository.GetPlayer(playerId);
            return player;
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
            return new Domain.Player(player.Name, player.EmailAddress, player.Password)
            {
                Id = player.Id
            };


        }

        public async Task<Domain.Game> ToDomainGame(DataLayer.Entities.Game game)
        {
            DataLayer.Entities.Player player1 =  await GetPlayer(game.Player1Id);
            DataLayer.Entities.Player player2 = await GetPlayer(game.Player2Id);
            DataLayer.Entities.Player winner = await GetPlayer(game.WinnerId);
            DataLayer.Entities.Player creator = await GetPlayer(game.CreatorId);

            return new Domain.Game(ToDomainPlayer(player1), ToDomainPlayer(player2))
            {
                Winner = ToDomainPlayer(winner),
                IsConfirmed = game.IsConfirmed,
                TimeStamp = game.CreationTimeStamp,
                Creator = ToDomainPlayer(creator)
            };

        }

        public DataLayer.Entities.Game ToEntityGame(Domain.Game game)
        {

            var newGame = new DataLayer.Entities.Game();
            newGame.Player1Id = game.Player1.Id;
            newGame.Player2Id = game.Player2.Id;
            newGame.CreatorId = game.Creator.Id;
            newGame.IsConfirmed = game.IsConfirmed;
            newGame.WinnerId = game.Winner.Id;
            newGame.CreationTimeStamp = game.TimeStamp;

           

            return newGame;

        }

        public async Task<DataLayer.Entities.Player> GetPlayerLoggedIn(string email, string password)
        {
            var player = await _playerRepository.GetPlayerLoggedIn(email, password);
            return player;
        }

    }




}