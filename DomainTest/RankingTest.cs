using System.Collections.Generic;
using System.Linq;
using Domain;
using NUnit.Framework;
using Shouldly;



namespace DomainTest
{
    [TestFixture]
    public class RankingsTest
    {
        [Test]
        [Category("Integration")]
        public void RankingsAreVisibleToAllPlayer()
        {
            // StartUp Api

            // Visit Api Endpoint for Ranking

            //Assert Ranking object is returned
        }

        [Test]
        [Category("Unit")]
        public void CalculateScores_WinningPlayerScoresOnePoint()
        {
            var player1 = new Player("Daniel");
            var player2 = new Player("James");

            player1.EmailAdress = "daniellaraedinburgh@hotmail.com";
            player2.EmailAdress = "daniellaraedinburgh@hotmail.com";

            var game1 = player2.CreateGame(player1, player2);

            player1.SetGameResults(game1, player1);
            player1.ConfirmGame(game1);

            var games = new List<Game>() {
                    game1,
            };
            var ranking = new Ranking();
            var scores = ranking.CalculateScores(games);
            var winnerPoints = scores.Max(x => x.Points);
            winnerPoints.ShouldBe(1);

        }

        [Test]
        [Category("Unit")]
        public void CalculateScores_RankingsAreOrderedByDescending()
        {
            var player1 = new Player("Daniel");
            var player2 = new Player("James");
            var game1 = new Game(player1, player2);

            game1.Winner = player1;
       
            var games = new List<Game>() {
                    game1,
            };
            var rankingObject = new Ranking();
            var ranking = rankingObject.CalculateScores(games);
            var firstPlayerInRanking = ranking.First().Player;

            firstPlayerInRanking.ShouldBe("Daniel");
        }



        [Test]
        [Category("Unit")]
        public void CalculateScores_RankingsCanBeGeneratedFromGames()
        {
            var games = new List<Game>();
            var ranking = new Ranking();

            var scores = ranking.CalculateScores(games);

            scores.ShouldNotBeNull();
        }

        [Test]
        [Category("Unit")]
        public void CalculateScores_RankingsContainsAllPlayers()
        {
            var player1 = new Player("Daniel");
            var player2 = new Player("James");
            var player3 = new Player("Jaya");
            var player4 = new Player("Alvin");

            var game1 = new Game(player1, player2);
            var game2 = new Game(player3, player4);

            game1.Winner = player1;
            game2.Winner = player3;

            var games = new List<Game>() {
                    game1,
                    game2

            };

            var allPlayersNames = games.Select(game => game.Player1.Name).Union(games.Select(game => game.Player2.Name)).OrderBy(playerName => playerName);
            var ranking = new Ranking();

            var players = ranking.CalculateScores(games).Select(x => x.Player).OrderBy(x => x).ToList();

            players.ShouldBeUnique();
            players.SequenceEqual(allPlayersNames).ShouldBeTrue();
        }


        [Test]
        [Category("Unit")]
        public void CreatorOfTheGameCantConfirmGame()
        {
            var player1 = new Player("Daniel");
            var player2 = new Player("James");

            player1.EmailAdress = "daniellaraedinburgh@hotmail.com";
            player2.EmailAdress = "daniellaraedinburgh@hotmail.com";

            var game1 = player2.CreateGame(player1, player2);

            player1.SetGameResults(game1, player1);
            player2.ConfirmGame(game1);
       
            var games = new List<Game>() {
                    game1,
            };
          
            game1.IsConfirmed.ShouldBe(false);

        }

        [Test]
        [Category("Unit")]
        public void GetAllPlayerNames_GetsAllNames()
        {
            var player1 = new Player("Daniel");
            var player2 = new Player("James");

            var game1 = new Game(player1, player2);

            game1.Winner = player1;

            var games = new List<Game>() {
                    game1,
            };
            var ranking = new Ranking();
            var allPlayerNames = ranking.GetAllPlayerNames(games);
            allPlayerNames.Count().ShouldBe(2);
            allPlayerNames.ShouldContain("Daniel");
        }

        [Test]
        [Category("Unit")]
        public void InsertsAllNamesInScoresArray()
        {
            var player1 = new Player("Daniel");
            var player2 = new Player("James");

            var game1 = new Game(player1, player2);

            game1.Winner = player1;

            var games = new List<Game>() {
                    game1,
            };
            var ranking = new Ranking();

            ranking.InsertAllPlayerNamesInScoresArray(games);
            ranking.scores.Count().ShouldBe(2);
          
        }


        [Test]
        [Category("Unit")]
        public void ActionOnWinnerAfterGame()
        {
            var player1 = new Player("Daniel");
            var player2 = new Player("James");

            player1.EmailAdress = "daniellaraedinburgh@hotmail.com";
            player2.EmailAdress = "daniellaraedinburgh@hotmail.com";


            var game1 = player2.CreateGame(player1, player2);

            player1.SetGameResults(game1, player1);
            player1.ConfirmGame(game1);
            var score1 = new Score(player1.Name);
            var ranking = new Ranking();
            
            ranking.ActionOnWinnerAfterGame(game1, score1);

            score1.Player.ShouldBe("Daniel");
            score1.Points.ShouldBe(1);
        }


        [Test]
        [Category("Unit")]
        public void CanCreateNewRanking()
        {
            Ranking newRanking = new Ranking();
            newRanking.ShouldNotBe(null);
        }



    }
}
