using System;
namespace ConsoleBingoGame
{
    public interface ISpaceInjector
    {
        ICard InjectSpace(ICard card, IGameDataSetting gameDataSetting);
    }
}
