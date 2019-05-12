using System.Collections.Generic;
using System.Linq;
using Domain;
using NUnit.Framework;
using Shouldly;


namespace DomainTest
{
    [TestFixture]
    public class PlayerTest
    {

       
            [Test]
            [Category("Unit")]
            public void PlayerCanConfirmGame()
            {

            var player1 = new Player("Nira");
            var player2 = new Player("Daniel");

            var game1 = player2.CreateGame(player1, player2);
            game1.Winner = player2;

            player1.ConfirmGame(game1);

            game1.IsConfirmed.ShouldBe(true);

            }

        [Test]
        [Category("Unit")]
        public void CreatorOfGameCantConfirmGame()
        {

            var player1 = new Player("Nira");
            var player2 = new Player("Daniel");

            var game1 = player1.CreateGame(player1, player2);
            game1.Winner = player2;

            player1.ConfirmGame(game1);

            game1.IsConfirmed.ShouldBe(false);

        }

        [Test]
        [Category("Unit")]
        public void OnlyPlayerOfTheGameCanConfirmGame()
        {

            var player1 = new Player("Nira");
            var player2 = new Player("Daniel");
            var player3 = new Player("James");

            var game1 = new Game(player1, player2);
            game1.Winner = player2;
            player3.ConfirmGame(game1);

            game1.IsConfirmed.ShouldBe(false);

        }

        [Test]
        [Category("Unit")]
        public void OnlyPlayerOfTheGameCanSetGameResults()
        {

            var player1 = new Player("Nira");
            var player2 = new Player("Daniel");
            var player3 = new Player("James");

            var game1 = new Game(player1, player2);
            player3.SetGameResults(game1, player1);
            game1.Winner.ShouldBe(null);

        }

        [Test]
        [Category("Unit")]
        public void CanCreateNewPlayer()
        {
            var player1 = new Player("Nira");
         
            player1.ShouldNotBe(null);
        }




    }
}

