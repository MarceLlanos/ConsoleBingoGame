using System;
namespace ConsoleBingoGame
{
    public class GameData : IGameData
    {
        int quantityOfBalls;
        int quantityOfCards;

        public GameData(int quantityOfBalls, int quantityOfCards)
        {
            this.quantityOfBalls = quantityOfBalls;
            this.quantityOfCards = quantityOfCards;
        }

        public int GetQuantityOfBalls()
        {
            return quantityOfBalls;
        }

        public int GetQuantityOfCards()
        {
            return quantityOfCards;
        }

        public void SetQuantityOfBalls(int quantityOfBalls)
        {
            this.quantityOfBalls = quantityOfBalls;
        }

        public void SetQuantityOfCards(int quantityOfCards)
        {
            this.quantityOfCards = quantityOfCards;
        }

    }
}
