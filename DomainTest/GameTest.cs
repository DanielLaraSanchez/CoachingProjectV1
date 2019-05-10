using System.Collections.Generic;
using System.Linq;
using Domain;
using NUnit.Framework;
using Shouldly;

namespace DomainTest
{
    [TestFixture]
    public class GameTest
    {
        [Test]
        [Category("Unit")]
        public void CanCreateNewGame()
        {
            var player1 = new Player("Daniel");
            var player2 = new Player("James");
            var game = new Game(player1, player2);
            game.ShouldNotBe(null);

        }
    }
}
