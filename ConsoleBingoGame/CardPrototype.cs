using System;
namespace ConsoleBingoGame
{
    public class CardPrototype : ICardPrototype
    {
        RandomNumbersGenerator randomNumbersGenerator;
        IColumnRangeGetter columnRangeGetter;
        IGameDataSetting gameDataSetting;

        public CardPrototype(IColumnRangeGetter columnRangeGetter, IGameDataSetting gameDataSetting)
        {
            this.gameDataSetting = gameDataSetting;
            this.columnRangeGetter = columnRangeGetter;
            randomNumbersGenerator = new RandomNumbersGenerator();
        }

        public ICard CreateCardPrototype(ICard card)
        {
            var rowNumber = gameDataSetting.GetCardData().GetRowNumber();
            var columnNumber = gameDataSetting.GetCardData().GetColumnNumber();
            var fillerCard = new DataFiller(card);

            for (int i = 0; i < columnNumber; i++)
            {
                var numbers = randomNumbersGenerator.GenerateDistinctRandomNumbers(columnRangeGetter.GetRangeForColumn(i), rowNumber);
                fillerCard.FillData(numbers, i);
            }

            return card;
        }
    }
}
