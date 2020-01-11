using System;
namespace ConsoleBingoGame
{
    public interface IGameData
    {
        int GetQuantityOfBalls();
        int GetQuantityOfCards();
        void SetQuantityOfBalls(int quantityOfBalls);
        void SetQuantityOfCards(int quantityOfCards);
    }
}
