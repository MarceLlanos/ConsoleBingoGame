using System;
using System.Collections.Generic;

namespace ConsoleBingoGame
{
    public interface IRandomNumbersGenerator
    {
        List<int> GenerateDistinctRandomNumbers(IRange range, int quantity);
    }
}
