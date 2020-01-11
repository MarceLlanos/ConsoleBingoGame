using System;
namespace ConsoleBingoGame
{
    public interface IRangeDictionaryFactory
    {
        IRangeDictionary CreateRangeDictionary(int columnNumber);
    }
}
