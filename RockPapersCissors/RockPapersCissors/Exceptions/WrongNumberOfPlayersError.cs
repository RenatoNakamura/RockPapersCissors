using System;

namespace RockPapersCissors.Exceptions
{
    public class WrongNumberOfPlayersError : Exception
    {
        public WrongNumberOfPlayersError(string text) : base(text)
        {

        }
    }
}
