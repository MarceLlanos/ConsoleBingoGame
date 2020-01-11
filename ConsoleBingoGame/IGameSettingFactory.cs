using System;
namespace ConsoleBingoGame
{
    public interface IGameSettingFactory
    {
        IGameDataSetting CreateGameSetting(int option, int quantityOfCards, int optionToWin);
    }
}
