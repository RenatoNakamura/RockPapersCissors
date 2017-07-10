using System;

namespace RockPapersCissors.Exceptions
{
    public class NoSuchStrategyError : Exception
    {
        public NoSuchStrategyError(string text) : base(text)
        {

        }
    }
}
