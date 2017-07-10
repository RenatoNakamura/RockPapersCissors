namespace RockPapersCissors.Domain
{
    public class Player
    {
        public string Name { get; private set; }
        public string Played { get; private set; }

        public Player(string name, string played)
        {
            Name = name;
            Played = played;
        }
    }
}
