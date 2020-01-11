using System;
namespace ConsoleBingoGame
{
    public interface ICardData
    {
        int GetColumnNumber();
        int GetRowNumber();
        void SetColumnNumber(int column);
        void SetRowNumber(int row);
    }
}
