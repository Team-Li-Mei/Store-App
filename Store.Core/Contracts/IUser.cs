using Store.Core.Models;

namespace Store.Core.Contracts
{
    /// <summary>
    /// Component
    /// </summary>
    public interface IUser
    {
        string Id { get; }

        string Email { get; }

        string Password { get; }

        string Username { get; }

        Wallet Wallet { get; }

        void AddItem(IProduct product);

        void RemoveItem(IProduct product);
    }
}
