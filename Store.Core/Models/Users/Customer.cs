namespace Store.Core.Models.Users
{
    using Abstract;
    using Contracts;

    public class Customer : User
    {
        public Customer(string setUsername, string setPassword, string setEmail)
            : base(setUsername, setPassword, setEmail)
        {
        }
        public override void AddItem(IProduct product)
        {
            base.AddItem(product);
            this.Wallet.RemoveMoney(product.PricePerQuantity);
        }
    }
}
