//-----------------------------------------------------------------------
// <copyright file="Item.cs" company="Team Li Mei">
//     Telerik Academy C# OOP Teamwork project.
// </copyright>
//-----------------------------------------------------------------------

namespace Store.Core.Models.Products.Abstract
{
    using Contracts;
    using System.Text;
    using Infrastructure.Utils;
    using Infrastructure.Constants;

    /// <summary>
    /// Item base structure.
    /// </summary>
    public abstract class Product : IProduct
    {
        /// <summary>
        /// Items name.
        /// </summary>
        private string name;

        /// <summary>
        /// Items id.
        /// </summary>
        private int id;

        private double quantity;

        /// <summary>
        /// Items price.
        /// </summary>
        private decimal pricePerQuantity;

        /// <summary>
        /// Initializes a new instance of the <see cref="Item"/> struct.
        /// </summary>
        /// <param name="setName">Item name.</param>
        /// <param name="setPrice">Item price.</param>
        /// <param name="setExpirationDate">Expiration date of the item, null if item is non-perishable.</param>
        /// <param name="setCount">Item count.</param>
        public Product(string setName, decimal setPicePerQuantity, double setQuantity)
        {
            id++;
            //validate
            this.name = setName;
            this.pricePerQuantity = setPicePerQuantity;
            this.Quantity = setQuantity;
        }

        /// <summary>
        /// Gets the current item id.
        /// </summary>
        int IProduct.Id
        {
            get
            {
                return this.id;
            }

            set
            {
                this.id = value;
            }
        }

        /// <summary>
        /// Gets the current item quantity.
        /// </summary>
        public double Quantity
        {
            get { return this.quantity; }
            set
            {
                Validator.CheckIfDoubleRange(value, GeneralConstants.MinQuantity, GeneralConstants.MaxQuantity, string.Format(
                    GeneralConstants.NumberMustBeBetweenMinAndMax, "Quantity", GeneralConstants.MinQuantity, GeneralConstants.MaxQuantity));

                this.quantity = value;
            }
        }

        /// <summary>
        /// Gets the name of the item.
        /// </summary>
        public string Name
        {
            get { return this.name; }
            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, string.Format(GeneralConstants.ProductCannotBeNull));

                Validator.CheckIfStringLengthIsValid(value, GeneralConstants.MaxNameLength, GeneralConstants.MinNameLength, string.Format(
                    GeneralConstants.StringMustBeBetweenMinAndMax, "Name", GeneralConstants.MinNameLength, GeneralConstants.MaxNameLength));

                this.name = value;
            }
        }

        /// <summary>
        /// Gets the price of the item/
        /// </summary>
        public decimal PricePerQuantity
        {
            get { return this.pricePerQuantity; }
            private set
            {
                Validator.CheckIfDecimalRange(value, GeneralConstants.MinPricePerQuantity, GeneralConstants.MaxPricePerQuantity, string.Format(
                    GeneralConstants.NumberMustBeBetweenMinAndMax, "Price per quantity", GeneralConstants.MinPricePerQuantity, GeneralConstants.MaxPricePerQuantity));

                this.pricePerQuantity = value;
            }
        }

        /// <summary>
        /// Replaces the behavior of the original ToString() method.
        /// </summary>
        /// <returns>A string representation of the item object.</returns>
        public override string ToString()
        {
            var strBuilder = new StringBuilder();
            strBuilder.Append($"{this.id}|{this.Name}|{this.Quantity}|{this.PricePerQuantity}");
            return strBuilder.ToString();
        }
    }
}