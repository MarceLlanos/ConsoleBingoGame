using System;
namespace ConsoleBingoGame
{
    public class Range : IRange
    {
        int start;
        int end;

        public Range(int start, int end)
        {
            this.start = start;
            this.end = end;
        }

        public int GetStart()
        {
            return start;
        }

        public int GetEnd()
        {
            return end;
        }

        public void SetStart(int start)
        {
            this.start = start;
        }

        public void SetEnd(int end)
        {
            this.end = end;
        }
    }
}
