//-----------------------------------------------------------------------
// <copyright file="Item.cs" company="Team Li Mei">
//     Telerik Academy C# OOP Teamwork project.
// </copyright>
//-----------------------------------------------------------------------

namespace Store.Core.Models.Common
{
    using System;
    using System.Text;

    /// <summary>
    /// Item base structure.
    /// </summary>
    public struct Item
    {
        /// <summary>
        /// Items name.
        /// </summary>
        private readonly string name;

        /// <summary>
        /// Items price.
        /// </summary>
        private readonly decimal price;

        /// <summary>
        /// Items expiration date, if the item is perishable.
        /// </summary>
        private readonly DateTime? expirationDate;

        /// <summary>
        /// Store a value indicating whether the item is perishable or not.
        /// </summary>
        private bool isPerishable;

        /// <summary>
        /// Initializes a new instance of the <see cref="Item"/> struct.
        /// </summary>
        /// <param name="setName">Item name.</param>
        /// <param name="setPrice">Item price.</param>
        /// <param name="setExpirationDate">Expiration date of the item, null if item is non-perishable.</param>
        /// <param name="setCount">Item count.</param>
        public Item(string setName, decimal setPrice, DateTime setExpirationDate, int setCount)
        {
            this.name = setName;
            this.price = setPrice;

            if (setExpirationDate != null)
            {
                this.expirationDate = setExpirationDate;
                this.isPerishable = true;
            }
            else
            {
                this.isPerishable = false;
                this.expirationDate = null;
            }

            this.Count = setCount;
        }

        /// <summary>
        /// Gets the current item count.
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Gets the name of the item.
        /// </summary>
        public string Name
        {
            get
            {
                return this.name;
            }
        }

        /// <summary>
        /// Gets the price of the item/
        /// </summary>
        public string Price
        {
            get
            {
                return this.Price;
            }
        }

        /// <summary>
        /// Gets the expiration date of the item as a string,
        /// if the item is perishable. If the item isn't perishable returns 
        /// No expiration date! Item is not perishable.
        /// </summary>
        public string ExpirationDate
        {
            get
            {
                return this.expirationDate != null ? this.expirationDate.ToString() : "[ No expiration date! Item is not perishable. ]";
            }
        }

        /// <summary>
        /// Gets a value indicating whether the item is perishable or not.
        /// </summary>
        public bool IsPerishable
        {
            get
            {
                return this.isPerishable;
            }
        }

        /// <summary>
        /// Replaces the behavior of the original ToString() method.
        /// </summary>
        /// <returns>A string representation of the item object.</returns>
        public override string ToString()
        {
            var strBuilder = new StringBuilder();
            strBuilder.AppendLine(new string('-', 20) + $"Item" + new string('-', 20));
            strBuilder.AppendLine($"Name: {this.Name}");
            strBuilder.AppendLine($"Price: ${this.Price:F2}");
            if (this.isPerishable)
            {
                strBuilder.AppendLine($"Expiration date: {this.Name}");
            }

            strBuilder.AppendLine($"Perishable: {this.isPerishable}");

            return strBuilder.ToString();
        }
    }
}
