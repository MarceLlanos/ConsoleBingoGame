using System;
using System.Collections.Generic;

namespace ConsoleBingoGame
{
    public class CardSpacesFiller : IDataFiller
    {
        ICard card;

        public CardSpacesFiller(ICard card)
        {
            this.card = card;
        }

        public string[,] FillData(List<int> randomNumbers, int rowIndex)
        {
            var columnsNumber = randomNumbers.Count;
            var cardBoard = card.GetCardBoard();

            for (int i = 0; i < columnsNumber; i++)
            {
                cardBoard[randomNumbers[i], rowIndex] = " * ";
            }

            return cardBoard;
        }
    }
}
