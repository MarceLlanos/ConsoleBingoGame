using System;
using System.Collections.Generic;

namespace ConsoleBingoGame
{
    public class RangeDictionary : IRangeDictionary
    {
        IDictionary<int, IRange> dictionary;

        public RangeDictionary(IDictionary<int, IRange> dictionary)
        {
            this.dictionary = dictionary;
        }

        public IDictionary<int, IRange> GetRangeDictionary()
        {
            return dictionary;
        }
    }
}
