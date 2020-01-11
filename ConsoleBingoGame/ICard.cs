using System;
namespace ConsoleBingoGame
{
    public interface ICard
    {
        string[,] GetCardBoard();
        void SetCardBoard(string[,] card);
        string PrintRow(int rowIndex, int columnNumber);
    }
}
