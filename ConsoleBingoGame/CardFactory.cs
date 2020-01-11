using System;
namespace ConsoleBingoGame
{
    public class CardFactory : ICardFactory
    {
        public CardFactory()
        {
        }

        public ICard CreateCard(IGameDataSetting gameDataSetting)
        {
            var columnNumbers = gameDataSetting.GetCardData().GetColumnNumber();
            var rowNumbers = gameDataSetting.GetCardData().GetRowNumber();
            var cardBoard = new string[columnNumbers, rowNumbers];

            return new Card(cardBoard);
        }
    }
}
