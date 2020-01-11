using System;
namespace ConsoleBingoGame
{
    public interface IRange
    {
        int GetStart();
        int GetEnd();
        void SetStart(int start);
        void SetEnd(int end);
    }
}
