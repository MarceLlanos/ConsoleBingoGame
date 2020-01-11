using System;
namespace ConsoleBingoGame
{
    public class CardDataFactory : ICardDataFactory
    {
        public CardDataFactory()
        {
        }

        public ICardData CreateCardData(int optionNumber)
        {
            switch (optionNumber)
            {
                case 1: return new CardData(5, 5);
                case 2: return new CardData(9, 3);
            }

            return new CardData(5, 5);
        }
    }
}
