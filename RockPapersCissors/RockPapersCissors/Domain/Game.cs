using RockPapersCissors.Exceptions;
using System.Collections.Generic;

namespace RockPapersCissors.Domain
{
    public class Game
    {
        public static Player RpsGameWinner(Match match)
        {
            if (match.Player1 == null || match.Player2 == null)
                throw new WrongNumberOfPlayersError("Wrong Number Of Players");

            var listPlayed = new ListPlayed();
            if(!listPlayed.ValueIsValid(match.Player1.Played) || !listPlayed.ValueIsValid(match.Player2.Played))
                throw new NoSuchStrategyError("Invalid played");

            if (match.Player1.Played.ToUpper().Equals(match.Player2.Played.ToUpper()))
                return match.Player1;

            var played = listPlayed.FindPlayed(match.Player1.Played);
            
            return played.Lose.ToUpper() == match.Player2.Played.ToUpper() ? match.Player2 : match.Player1;
        }

        public static Player RpsTournamentWinner(List<Match> matches, Player playerWinTornament = null)
        {
            if (playerWinTornament == null)
            {
                if (matches.Count % 2 == 0)
                {
                    Match match = null;
                    List<Match> listWinners = new List<Match>();
                    matches.ForEach(m =>
                    {
                        var playerWin = RpsGameWinner(m);

                        if (match == null)
                            match = new Match(playerWin);
                        else
                        {
                            match.addPlayer2(playerWin);
                            listWinners.Add(match);
                            match = null;
                        }
                    });

                    playerWinTornament = RpsTournamentWinner(listWinners, playerWinTornament);
                }
                else
                    playerWinTornament = RpsGameWinner(matches[0]);
            }

            return playerWinTornament;
        }
    }
}
