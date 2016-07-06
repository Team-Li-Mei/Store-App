namespace Store.Core.Models
{
    using Contracts;
    using System;

    /// <summary>
    /// ConcreteDecorator
    /// </summary>
    public class Accounter : Decorator
    {
        public Accounter(IUser setUser) : base(setUser)
        {
            this.Customer = new Customer(setUser);
        }

        public Customer Customer { get; set; }

        public void GetExpenses()
        {
            Console.WriteLine("1291451207519025");
        }
    }
}
