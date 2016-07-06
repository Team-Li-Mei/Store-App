//-----------------------------------------------------------------------
// <copyright file="Startup.cs" company="Team Li Mei">
//     Telerik Academy C# OOP Teamwork project.
// </copyright>
//-----------------------------------------------------------------------

namespace Store.Client
{
    using Core.Contracts;
    using Core.Models;
    using System;

    /// <summary>
    /// The class StartUp holds the main starting point of our client.
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Main starting point of out program.
        /// </summary>
        public static void Main()
        {
            IUser ivan = new Accounter(new User("Ivan", "123456", "pesho@abv.bg"));

            Console.WriteLine(ivan is User);

            Console.WriteLine(ivan is Customer);

            Console.WriteLine(ivan is Accounter);

            (ivan as Accounter).Customer.AddMoney(20);



            //(ivan as Customer).AddMoney(20);


            //IUser dragan = new Customer(ivan);

            //(dragan as Customer).AddMoney(20);

            //(dragan as Accounter).GetExpenses();

            //IUser pesho = new Manager(dragan);


            //(pesho as Manager).Test();

            //(pesho as Customer).AddMoney(10);


            //Console.WriteLine(pesho is Accounter);
            //Console.WriteLine(pesho);
        }
    }
}
