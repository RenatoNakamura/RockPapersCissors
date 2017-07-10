using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPapersCissors.Domain;
using System.Collections.Generic;

namespace RockPapersCissorsTest
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        public void ShouldReturnRichardForPlayerWin()
        {
            var richard = new Player("Richard", "R");
            var allen = new Player("Allen", "S");
            var matchRichardAndAllen = new Match(richard, allen);

            var playerWin = Game.RpsGameWinner(matchRichardAndAllen);

            Assert.AreEqual(richard.Name, playerWin.Name);
        }

        [TestMethod]
        public void ShouldReturnExceptionBecauseDoesNotHavePlayer2()
        {
            var richard = new Player("Richard", "R");
            var matchRichardAndAllen = new Match(richard, null);

            try
            {
                var playerWin = Game.RpsGameWinner(matchRichardAndAllen);
            }
            catch { Assert.IsTrue(true); }
            
        }

        [TestMethod]
        public void ShouldReturnRichardForPlayerWinBecauseItPlayerIsPlayer1()
        {
            var richard = new Player("Richard", "R");
            var lucas = new Player("Lucas", "R");
            var matchRichardAndAllen = new Match(richard, lucas);

            var playerWin = Game.RpsGameWinner(matchRichardAndAllen);

            Assert.AreEqual(richard.Name, playerWin.Name);
        }

        [TestMethod]
        public void ShouldReturnRichardForPlayerWinTornament()
        {
            var armando = new Player("Armando", "P");
            var dave = new Player("Dave", "S");
            var matchArmandoAndDave = new Match(armando, dave);

            var richard = new Player("Richard", "R");
            var michael = new Player("Michael", "S");
            var matchRichardAndMichael = new Match(richard, michael);

            var allen = new Player("Allen", "S");
            var omer = new Player("Omer", "P");
            var matchAllenAndOmar = new Match(allen, omer);

            var david = new Player("David E.", "S");
            var richardX = new Player("Richard X.", "P");
            var matchDavidAndRichardX = new Match(david, richardX);

            var listForTournament = new List<Match>();
            listForTournament.Add(matchArmandoAndDave);
            listForTournament.Add(matchRichardAndMichael);
            listForTournament.Add(matchAllenAndOmar);
            listForTournament.Add(matchDavidAndRichardX);

            var winPlayer = Game.RpsTournamentWinner(listForTournament);

            Assert.AreEqual(richard.Name, winPlayer.Name);
        }
    }
}
