using System;
namespace ConsoleBingoGame
{
    public interface ICardPrototype
    {
        ICard CreateCardPrototype(ICard card);
    }
}
