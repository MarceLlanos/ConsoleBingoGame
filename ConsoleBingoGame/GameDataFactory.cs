using System;
namespace ConsoleBingoGame
{
    public class GameDataFactory : IGameDataFactory
    {
        public GameDataFactory()
        {
        }

        public IGameData CreateGameData(int optionNumber, int quantityOfBalls)
        {
            switch (optionNumber)
            {
                case 1: return new GameData(75, quantityOfBalls);
                case 2: return new GameData(90, quantityOfBalls);
            }

            return new GameData(75, quantityOfBalls);
        }
    }
}
