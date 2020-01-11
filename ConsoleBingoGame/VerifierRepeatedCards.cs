using System;
using System.Collections.Generic;

namespace ConsoleBingoGame
{
    public class VerifierRepeatedCards : IVerifierRepetedCards
    {
        public VerifierRepeatedCards()
        {
        }

        public bool HasRepeatedCards(List<ICard> cards)
        {
            bool result = false;
            int index = 1;

            foreach (var item in cards)
            {
                result = item.Equals(cards[index]);
                index += 1;
            }

            return result;
        }

    }
}
