using System;
using System.Collections.Generic;

namespace ConsoleBingoGame
{
    public class ColumnRangeGetter : IColumnRangeGetter
    {
        IRangeDictionary cardDictionary;

        public ColumnRangeGetter(IRangeDictionary cardDictionary)
        {
            this.cardDictionary = cardDictionary;
        }

        public IRange GetRangeForColumn(int columnIndex)
        {
            IRange range;

            foreach (KeyValuePair<int, IRange> item in cardDictionary.GetRangeDictionary())
            {
                if (columnIndex == item.Key)
                {
                    return range = item.Value;
                }
            }

            return range = null;
        }
    }
}
