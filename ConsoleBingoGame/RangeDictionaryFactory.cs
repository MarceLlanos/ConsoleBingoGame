using System;
namespace ConsoleBingoGame
{
    public class RangeDictionaryFactory : IRangeDictionaryFactory
    {
        public RangeDictionaryFactory()
        {
        }

        public IRangeDictionary CreateRangeDictionary(int columnNumber)
        {
            var bingoRangeDictionary = new BingoRangeDictionaryFiller().FillRangeDictionary();
            var housieRangeDictionary = new HousieRangeDictionaryFiller().FillRangeDictionary();

            switch (columnNumber)
            {
                case 5: return new RangeDictionary(bingoRangeDictionary);
                case 9: return new RangeDictionary(housieRangeDictionary);
                default:
                    return new RangeDictionary(bingoRangeDictionary);
            }

        }
    }
}
