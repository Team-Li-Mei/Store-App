namespace Store.Core.Models
{
    using Contracts;
    using System;

    /// <summary>
    /// ConcreteComponent
    /// </summary>
    public class Customer : Decorator
    {
        public Customer(IUser setUser) : base(setUser) { }

        public void AddMoney(decimal money)
        {
            Console.WriteLine(money);
        }
    }
}
