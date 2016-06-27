namespace Items.Interfaces
{
    using System;

    public interface IItem
    {
        string Name
        {
            get;
        }
        int Count
        {
            get; set;
        }
        decimal Price
        {
            get;
        }
        DateTime ExpirationDate
        {
            get;
        }
        bool IsPerishable
        {
            get;
        }
    }
}