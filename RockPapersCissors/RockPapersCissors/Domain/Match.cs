namespace RockPapersCissors.Domain
{
    public class Match
    {
        public Player Player1 { get; private set; }
        public Player Player2 { get; private set; }

        public Match(Player player1)
        {
            Player1 = player1;
        }

        public Match(Player player1, Player player2)
        {
            Player1 = player1;
            Player2 = player2;
        }

        public void addPlayer2(Player player2)
        {
            Player2 = player2;
        }
    }
}
