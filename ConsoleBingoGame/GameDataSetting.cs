using System;
namespace ConsoleBingoGame
{
    public class GameDataSetting : IGameDataSetting
    {
        ICardData cardData;
        IGameData gameData;
        int optionToWin;

        public GameDataSetting(ICardData cardData, IGameData gameData, int optionToWin)
        {
            this.cardData = cardData;
            this.gameData = gameData;
            this.optionToWin = optionToWin;
        }

        public ICardData GetCardData()
        {
            return cardData;
        }

        public IGameData GetGameData()
        {
            return gameData;
        }

        public int OptionToWin()
        {
            return optionToWin;
        }

        public void SetOptionToWin(int optionToWin)
        {
            this.optionToWin = optionToWin;
        }
    }
}
