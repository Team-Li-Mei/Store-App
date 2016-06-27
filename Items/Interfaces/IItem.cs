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

        // I've made the expiration date of this type, so we can check if the item has expired, 
        // by comparing it to DateTime.Now. 
        // If you don't think we need this check, we can change it to a string maybe? 
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
