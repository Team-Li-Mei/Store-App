namespace Store.Core.Models.Products.Abstract
{
    using Store.Core.Contracts;
    using System;

    public abstract class Consumable : Product, IConsumable
    {
        /// <summary>
        /// Items expiration date, if the item is perishable.
        /// </summary>
        private DateTime expirationDate;

        public Consumable(string setName, decimal setPricePerQuantity, DateTime setExpirationDate, double setQuantity)
            : base(setName, setPricePerQuantity, setQuantity)
        {
            this.expirationDate = setExpirationDate;
        }

        /// <summary>
        /// Gets the expiration date of the Product.
        /// </summary>
        public DateTime ExpirationDate
        {
            get { return this.expirationDate; }
        }
    }
}
