using System;
using System.Collections.Generic;

namespace ConsoleBingoGame
{
    public class RandomSpacesInjector : ISpaceInjector
    {
        IRandomNumbersGenerator generator;

        public RandomSpacesInjector()
        {
            generator = new RandomNumbersGenerator();
        }

        public ICard InjectSpace(ICard card, IGameDataSetting gameDataSetting)
        {
            var rowNumber = gameDataSetting.GetCardData().GetRowNumber();
            var columnNumber = gameDataSetting.GetCardData().GetColumnNumber();
            var spacesInjector = new CardSpacesFiller(card);

            for (int i = 0; i < rowNumber; i++)
            {
                var columnPositions = generator.GenerateDistinctRandomNumbers(new Range(1, columnNumber), 4);
                spacesInjector.FillData(columnPositions, i);
            }

            return card;
        }

    }
}
