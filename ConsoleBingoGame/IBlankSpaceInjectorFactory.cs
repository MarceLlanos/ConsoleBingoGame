using System;
namespace ConsoleBingoGame
{
    public interface IBlankSpaceInjectorFactory
    {
        ISpaceInjector CreateBlankSpacesInjector(int quantityOfBlankSpaces);
    }
}
