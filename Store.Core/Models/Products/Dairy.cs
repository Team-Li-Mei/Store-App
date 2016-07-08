namespace Store.Core.Models.Products
{
    using Abstract;
    using Contracts;
    using System;

    public class Dairy : Consumable, IDairy
    {
        private readonly double fatContent;

        public Dairy(string setName, decimal setPricePerQuantity, DateTime setExpirationDate, double setQuantity, double setFatContent)
            : base(setName, setPricePerQuantity, setExpirationDate, setQuantity)
        {
            this.fatContent = FatContent;
        }

        public double FatContent { get { return this.fatContent; } }
    }
}
