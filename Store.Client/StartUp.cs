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
    using Core.Models;
    using Core.Models.Menus;
    using Core.Models.Products;
    using Core.Models.Users;
    using Store.Core.Infrastructure.Utils;

    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;

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
            Console.SetWindowSize(GeneralConstants.ConsoleWindowWidth, GeneralConstants.ConsoleWindowHeight);

#if DEBUG
            var collection = new List<IProduct>();
            collection.Add(new Dairy("Milk", 22.5m, DateTime.Now, 90, 32.1));
            collection.Add(new Dairy("Yougurt", 35.5m, DateTime.Now, 50, 5));
#endif
            string username = null;
            string password = null;
            string email = null;

            StateType state = StateType.MainMenu;

            IStoreFactory storeFactory = StoreFactory.Instance;
            IUser currentUser = null;
            IDataStorage userContext = null;

            ConsoleKey key = ConsoleKey.NoName;

            while (true)
            {
                try
                {
                    
                    switch (state)
                    {
                   
                       
                        case StateType.MainMenu:
                            MainMenu.Instance.Draw();
                            state = MainMenu.Instance.ParseKey(Console.ReadKey().Key);
                            break;
                        case StateType.LoginMenu:
                            //Validator.CheckIfPriceIsValid(-20);
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
                            CartMenu.Instance(currentUser.Cart).Draw();
                            state = CartMenu.Instance(currentUser.Cart).ParseKey(Console.ReadKey().Key);
                            break;
                        case StateType.PaymentMenu:
                            PaymentMenu.Instance.Draw();
                            state = PaymentMenu.Instance.ParseKey(Console.ReadKey().Key);
                            break;
                        case StateType.EnterUsername:
                            username = Console.ReadLine();
                            state = StateType.RegisterMenu;
                            break;
                        case StateType.EnterPassword:
                            password = Console.ReadLine();
                            state = StateType.RegisterMenu;
                            break;
                        case StateType.EnterEmail:
                            email = Console.ReadLine();
                            state = StateType.RegisterMenu;
                            break;
                        case StateType.Register:
                            userContext = storeFactory.CreateDataStorage("Users");
                            currentUser = storeFactory.CreateUser(typeof(Admin),
                                username, password, email);
                            userContext.Write(currentUser.ToString());
                            state = StateType.StoreMenu;
                            break;
                        case StateType.Login:
                            userContext = storeFactory.CreateDataStorage("Users");
                            var text = (userContext as FileStorage).ReadToEnd().Split('\n');
                            foreach (var str in text)
                            {
                                var temp = str.Split('|');
                                if (temp[1] == username && temp[2] == password)
                                {
                                    currentUser = storeFactory.CreateUser(typeof(Admin), username, password, email);
                                    break;
                                }
                            }

                            if (currentUser == null)
                                state = StateType.MainMenu;
                            else
                                state = StateType.StoreMenu;

                            break;
                        case StateType.NotSet:
                            state = ChangeMenuTemp(Console.ReadKey().Key, state);
                            break;
                        case StateType.AddToCart:
                            IProduct wantedProduct = TakeProductID(collection);
                            wantedProduct.Quantity--;
                            currentUser.Cart.AddToCart(wantedProduct);

                            if (wantedProduct.Quantity == 0)
                                collection.Remove(wantedProduct);

                            state = ChangeMenuTemp(Console.ReadKey().Key, state);
                            break;
                        default:
                            break;
                    }
                    Console.Clear();
                }
                catch (Exception ex)
                {
                    state = StateType.NotSet;
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private static StateType ChangeMenuTemp(ConsoleKey key, StateType state)
        {
            if (key == ConsoleKey.Enter)
                return StateType.MainMenu;
            else
                return state;
        }

        public static IProduct TakeProductID(IList<IProduct> products)
        {
            Console.WriteLine("Enter ID of the product you would like to add to your cart: ");
            //validate (should be a number in range from 0 to all available products' count);
            int productID = int.Parse(Console.ReadLine());
            return products.FirstOrDefault(x => x.Id == productID);
        }
    }
}
