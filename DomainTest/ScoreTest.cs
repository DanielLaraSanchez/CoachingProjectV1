using System.Collections.Generic;
using System.Linq;
using Domain;
using NUnit.Framework;
using Shouldly;

namespace DomainTest
{
    [TestFixture]
    public class ScoreTest
    {

        [Test]
        [Category("Unit")]
        public void CanCreateNewScore()
        {
            var player1 = new Player("Daniel");
            var player2 = new Player("James");

            var game = new Game(player1, player2);
            var newScore = new Score("Daniel");
            newScore.ShouldNotBe(null);
        }
    }
}
