namespace Store.Core.Models.Users
{
    using Contracts;
    using System;

    /// <summary>
    /// ConcreteDecorator
    /// </summary>
    public class Manager : Decorator
    {
        public Manager(IUser setUser) : base(setUser) {
            this.Accounter = new Accounter(setUser);
        }

        public Accounter Accounter { get; set; }

        public void Test()
        {
            Console.WriteLine("I am the manager");
        }
    }
}
