using System;
namespace ConsoleBingoGame
{
    public interface ICardPrototypeFactory
    {
        ICard CreateCardForPlay();
    }
}
