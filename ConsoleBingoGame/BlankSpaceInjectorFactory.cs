using System;
namespace ConsoleBingoGame
{
    public class BlankSpaceInjectorFactory : IBlankSpaceInjectorFactory
    {
        public BlankSpaceInjectorFactory()
        {
        }

        public ISpaceInjector CreateBlankSpacesInjector(int columnNumber)
        {
            switch (columnNumber)
            {
                case 5: return new MiddleBlankSpaceInjector();
                case 9: return new RandomSpacesInjector();
                default:
                    return null;
            }
        }
    }
}
