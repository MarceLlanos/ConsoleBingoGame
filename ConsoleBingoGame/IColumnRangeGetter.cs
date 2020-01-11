using System;
namespace ConsoleBingoGame
{
    public interface IColumnRangeGetter
    {
        IRange GetRangeForColumn(int column);
    }
}
