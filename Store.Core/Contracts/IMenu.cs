namespace Store.Core.Contracts
{
    using Infrastructure.Enumerations;
    using System;

    public interface IMenu
    {
        void Draw();

        StateType ParseKey(ConsoleKey key);
    }
}
