namespace Store.Core.Contracts
{
    using System.Collections.Generic;

    public interface ICart
    {
        IList<IProduct> Products { get; }

        void AddToCart(IProduct product);

        bool RemoveFromCart(IProduct product);

        void ClearCart(IProduct product);
    }
}
