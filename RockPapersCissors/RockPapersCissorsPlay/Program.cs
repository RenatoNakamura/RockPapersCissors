using RockPapersCissors.Domain;
using System;
using System.Collections.Generic;

namespace RockPapersCissorsPlay
{
    class Program
    {
        static void Main(string[] args)
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
            Console.WriteLine(string.Format("Win player is {0}", winPlayer.Name));
            Console.ReadLine();
        }
    }
}
