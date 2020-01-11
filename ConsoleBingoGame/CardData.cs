using System;
namespace ConsoleBingoGame
{
    public class CardData : ICardData
    {
        private int columnNumbers;
        private int rowNumbers;

        public CardData(int columnNumber, int rowNumbers)
        {
            this.columnNumbers = columnNumber;
            this.rowNumbers = rowNumbers;
        }

        public int GetColumnNumber()
        {
            return columnNumbers;
        }

        public int GetRowNumber()
        {
            return rowNumbers;
        }

        public void SetColumnNumber(int columnNumbers)
        {
            this.columnNumbers = columnNumbers;
        }

        public void SetRowNumber(int rowNumbers)
        {
            this.rowNumbers = rowNumbers;
        }
    }
}
