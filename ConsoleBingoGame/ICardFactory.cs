using System;
namespace ConsoleBingoGame
{
    public interface ICardFactory
    {
        ICard CreateCard(IGameDataSetting gameDataSetting);
    }
}
