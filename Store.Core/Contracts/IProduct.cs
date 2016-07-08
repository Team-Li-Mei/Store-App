namespace Store.Core.Contracts
{
    public interface IProduct
    {
        int Id { get; }

        string Name { get; }

        decimal PricePerQuantity { get; }

        double Quantity { get; }
    }
}
