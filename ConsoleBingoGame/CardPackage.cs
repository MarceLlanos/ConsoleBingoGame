using System;
using System.Collections.Generic;

namespace ConsoleBingoGame
{
    public class CardPackage : ICardPackage
    {
        public CardPackage()
        {
        }

        List<ICard> cards;
        IGameDataSetting gameDataSetting;

        public CardPackage(IGameDataSetting gameDataSetting)
        {
            this.gameDataSetting = gameDataSetting;
            cards = new List<ICard>();
        }

        public List<ICard> DrawDeckOfCards()
        {
            var cardPrototype = new CardPrototypeFactory(gameDataSetting);
            var quantityOfCards = gameDataSetting.GetGameData().GetQuantityOfCards();

            while (quantityOfCards > 0)
            {
                cards.Add(cardPrototype.CreateCardForPlay());

                quantityOfCards -= 1;
            }

            return cards;
        }

        public void ShowCards()
        {
            var rowNumber = gameDataSetting.GetCardData().GetRowNumber();
            var columnNumber = gameDataSetting.GetCardData().GetColumnNumber();

            foreach (var item in cards)
            {
                for (int i = 0; i < rowNumber; i++)
                {

                    Console.WriteLine(item.PrintRow(i, columnNumber));
                }

                Console.WriteLine(" ");
            }
        }
    }
}
