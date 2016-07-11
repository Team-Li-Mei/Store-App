using Store.Core.Models;

namespace Store.Core.Contracts
{
    public interface IUser
    {
        int Id { get; }

        string Email { get; }

        string Password { get; }

        string Firstname { get; }

        string Lastname { get; }

        string Username { get; }

        Wallet Wallet { get; }

        void AddItem(IProduct product);

        void RemoveItem(IProduct product);
    }
}
