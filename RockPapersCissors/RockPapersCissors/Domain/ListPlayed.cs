using System.Collections.Generic;
using System.Linq;

namespace RockPapersCissors.Domain
{
    public class ListPlayed
    {
        private readonly List<TypeOfPlayed> _playeds;

        public ListPlayed()
        {
            _playeds = new List<TypeOfPlayed>();

            _playeds.Add(new TypeOfPlayed("P", "S"));
            _playeds.Add(new TypeOfPlayed("S", "R"));
            _playeds.Add(new TypeOfPlayed("R", "P"));
        }

        public bool ValueIsValid(string played)
        {
            return _playeds.Exists(p => p.Played.ToUpper() == played.ToUpper());
        }
        
        public TypeOfPlayed FindPlayed(string played)
        {
            return _playeds.Where(p => p.Played.ToUpper() == played.ToUpper()).FirstOrDefault();
        }
    }
}
