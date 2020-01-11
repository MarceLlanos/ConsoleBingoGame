using System;
using System.Collections.Generic;

namespace ConsoleBingoGame
{
    public interface IRangeDictionary
    {
        IDictionary<int, IRange> GetRangeDictionary();
    }
}
