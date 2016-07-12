namespace Store.Core.Contracts
{
    public interface IProduct
    {
        int Id { get; set; }

        string Name { get; }

        decimal PricePerQuantity { get; }

        double Quantity { get; set; }
    }
}
