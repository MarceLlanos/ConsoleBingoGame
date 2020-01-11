using System;
using System.Collections.Generic;

namespace ConsoleBingoGame
{
    public interface IVerifierRepetedCards
    {
        bool HasRepeatedCards(List<ICard> cards);
    }
}
