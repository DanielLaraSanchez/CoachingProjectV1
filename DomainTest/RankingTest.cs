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


            var games = new List<Game>() { 
                    game1,
                    game2

            }; // we need some actual games here.

            var allPlayersNames = games.Select(game => game.Player1.Name).Union(games.Select(game => game.Player2.Name)).OrderBy(playerName => playerName);
            var ranking = new Ranking();

            var players = ranking.CalculateScores(games).Select(x => x.Player).OrderBy(x => x).ToList();

            players.ShouldBeUnique();
            players.SequenceEqual(allPlayersNames).ShouldBeTrue();
        }


    }
}
