using System;
namespace ConsoleBingoGame
{
    public interface ICardDataFactory
    {
        ICardData CreateCardData(int optionNumber);
    }
}
