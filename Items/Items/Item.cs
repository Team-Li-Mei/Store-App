namespace Items
{
    using System;
    using Interfaces;
    using Validation;

    public struct Item : IItem
    {
        private readonly string name;
        private int count;
        private readonly decimal price;
        private readonly DateTime expirationDate;
        private readonly bool isPerishable;

        public Item(string name, int count, decimal price, DateTime expirationDate, bool isPerishable) : this()
        {
            this.name = name;
            this.Count = count;
            this.price = price;
            this.expirationDate = expirationDate;
            this.isPerishable = isPerishable;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }
        public int Count
        {
            get
            {
                return this.count;
            }
            set
            {
                if (value < 0)
                {
                    throw new InvalidRangeException(0, "The entered count isn't valid!");
                }
                this.count = value;
            }
        }
        public decimal Price
        {
            get
            {
                return this.price;
            }
        }
        public DateTime ExpirationDate
        {
            get
            {
                return this.expirationDate;
            }
        }
        public bool IsPerishable
        {
            get
            {
                return this.isPerishable;
            }
        }
    }
}
