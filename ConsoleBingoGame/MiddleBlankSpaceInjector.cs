using System;
namespace ConsoleBingoGame
{
    public class MiddleBlankSpaceInjector : ISpaceInjector
    {
        public MiddleBlankSpaceInjector()
        {
        }

        public ICard InjectSpace(ICard card, IGameDataSetting gameDataSetting)
        {
            var columnNumber = gameDataSetting.GetCardData().GetColumnNumber();
            var rowNumber = gameDataSetting.GetCardData().GetRowNumber();

            decimal columnDivision = columnNumber / 2;
            decimal rowDivision = rowNumber / 2;

            var middleColumn = Math.Floor(columnDivision);
            var middleRow = Math.Floor(rowDivision);
            var cardBoard = card.GetCardBoard();

            cardBoard[decimal.ToInt32(middleColumn), decimal.ToInt32(middleRow)] = " * ";

            return card;
        }
    }
}
