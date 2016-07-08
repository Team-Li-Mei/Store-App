namespace Store.Core.Contracts
{
    using System;

    public interface IConsumable
    {
        DateTime ExpirationDate { get; }
    }
}
