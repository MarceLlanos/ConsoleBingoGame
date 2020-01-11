using System;
namespace ConsoleBingoGame
{
    public interface IGameDataFactory
    {
        IGameData CreateGameData(int optionNumber, int quantityOfBalls);
    }
}
