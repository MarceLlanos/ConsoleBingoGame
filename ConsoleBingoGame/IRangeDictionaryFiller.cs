using System;
using System.Collections.Generic;

namespace ConsoleBingoGame
{
    public interface IRangeDictionaryFiller
    {
        IDictionary<int, IRange> FillRangeDictionary();
    }
}
