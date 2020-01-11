using System;
using System.Collections.Generic;

namespace ConsoleBingoGame
{
    public interface IDataFiller
    {
        string[,] FillData(List<int> randomNumbers, int column);
    }
}
