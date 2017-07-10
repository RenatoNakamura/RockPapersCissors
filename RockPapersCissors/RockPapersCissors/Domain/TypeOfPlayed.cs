namespace RockPapersCissors.Domain
{
    public class TypeOfPlayed
    {
        public string Played { get; private set; }
        public string Lose { get; private set; }

        public TypeOfPlayed(string played, string lose)
        {
            Played = played;
            Lose = lose;
        }
    }
}
