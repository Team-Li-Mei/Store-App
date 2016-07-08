//-----------------------------------------------------------------------
// <copyright file="Startup.cs" company="Team Li Mei">
//     Telerik Academy C# OOP Teamwork project.
// </copyright>
//-----------------------------------------------------------------------

namespace Store.Client
{
    using Core.Contracts;
    using Core.Infrastructure.Constants;
    using Core.Infrastructure.Enumerations;
    using Core.Infrastructure.Utils;
    using Core.Models;
    using Core.Models.Menus;
    using Core.Models.Products;
    using Core.Models.Users;
    using System;
    using System.Collections.Generic;
    using System.Text;

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
            Console.OutputEncoding = Encoding.UTF8;
            Console.SetWindowSize(Constants.consoleWindowWidth, Constants.consoleWindowHeight);

            var collection = new List<IProduct>();
            collection.Add(new Dairy("Milk", 22.5m, DateTime.Now, 245, 32.1));
            collection.Add(new Dairy("Yougurt", 35.5m, DateTime.Now, 50, 5));
           
            string username = null;
            string password = null;
            string email = null;   

            StateType state = StateType.MainMenu;
            while (true)
            {
                switch (state)
                {
                    case StateType.MainMenu:
                        MainMenu.Instance.Draw();
                        state = MainMenu.Instance.ParseKey(Console.ReadKey().Key);
                        break;
                    case StateType.LoginMenu:
                        LoginMenu.Instance.Draw();
                        state = LoginMenu.Instance.ParseKey(Console.ReadKey().Key);
                        break;
                    case StateType.RegisterMenu:
                        RegisterMenu.Instance.Draw();
                        state = RegisterMenu.Instance.ParseKey(Console.ReadKey().Key);
                        break;
                    case StateType.StoreMenu:
                        StoreMenu.Instance(collection).Draw();
                        state = StoreMenu.Instance(collection).ParseKey(Console.ReadKey().Key);
                        break;
                    case StateType.CartMenu:
                        CartMenu.Instance.Draw();
                        state = CartMenu.Instance.ParseKey(Console.ReadKey().Key);
                        break;
                    case StateType.PaymentMenu:
                        PaymentMenu.Instance.Draw();
                        state = PaymentMenu.Instance.ParseKey(Console.ReadKey().Key);
                        break;
                    case StateType.EnterUsername:
                        username = Console.ReadLine();
                        //validation
                        state = StateType.RegisterMenu;
                        break;
                    case StateType.EnterPassword:
                        password = Console.ReadLine();
                        //validation
                        state = StateType.RegisterMenu;// need states
                        break;
                    case StateType.EnterEmail:
                        email = Console.ReadLine();
                        //validation
                        state = StateType.RegisterMenu;
                        break;
                    case StateType.Register:
                        //Validate
                        Validator.CheckIfStringIsNullOrEmpty(username);
                        Validator.CheckIfStringIsNullOrEmpty(password);
                        Validator.CheckIfStringIsNullOrEmpty(email);

                        //Write to file
                        var userContext = new FileStorage("Users");
                        userContext.Write(new Admin(username, password, email).ToString());

                        //Switch state
                        state = StateType.StoreMenu;
                        break;
                    default:
                        break;
                }
                Console.Clear();
            }
        }
    }
}
