using System;
namespace ConsoleBingoGame
{
    public interface IGameDataSetting
    {
        ICardData GetCardData();
        IGameData GetGameData();
        int OptionToWin();
        void SetOptionToWin(int optionToWin);
    }
}
