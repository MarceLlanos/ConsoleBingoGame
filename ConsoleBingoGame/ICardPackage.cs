using System;
using System.Collections.Generic;

namespace ConsoleBingoGame
{
    public interface ICardPackage
    {
        List<ICard> DrawDeckOfCards();
        void ShowCards();
    }
}
