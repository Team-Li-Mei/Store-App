//-----------------------------------------------------------------------
// <copyright file="Item.cs" company="Team Li Mei">
//     Telerik Academy C# OOP Teamwork project.
// </copyright>
//-----------------------------------------------------------------------

namespace Store.Core.Models.Products.Abstract
{
    using Contracts;
    using System.Text;
    using System;

    /// <summary>
    /// Item base structure.
    /// </summary>
    public abstract class Product : IProduct
    {
        /// <summary>
        /// Items name.
        /// </summary>
        private readonly string name;

        /// <summary>
        /// Items id.
        /// </summary>
        private int id;

        /// <summary>
        /// Items price.
        /// </summary>
        private readonly decimal pricePerQuantity;

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
        public double Quantity { get; set; }

        /// <summary>
        /// Gets the name of the item.
        /// </summary>
        public string Name { get { return this.name; } }

        /// <summary>
        /// Gets the price of the item/
        /// </summary>
        public decimal PricePerQuantity { get { return this.pricePerQuantity; } }

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
