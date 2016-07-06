using Store.Core.Models.Common;

namespace Store.Core.Contracts
{
    /// <summary>
    /// Component
    /// </summary>
    public interface IUser
    {
        //string Id { get; }

        //string Email { get; }

        //string Password { get; }

        //string Username { get; }

        void AddItem(Item item);

        void RemoveItem(Item item);
    }
}
