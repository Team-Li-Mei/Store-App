namespace Store.Core.Models.Menus
{
    using System;
    using Contracts;
    using Infrastructure.Enumerations;
    using System.Text;
    using System.Collections.Generic;
    using Products.Abstract;
    using System.Linq;
    using Users;
    using Carts;
    public class StoreMenu : IMenu
    {
        private static StoreMenu instance;

        private static List<IProduct> products;

        private StoreMenu(List<IProduct> setProducts)
        {
            products = setProducts;
        }

        public static StoreMenu Instance(List<IProduct> setProducts)
        {
            if (instance == null)
                instance = new StoreMenu(setProducts);
            return instance;
        }

        public void Draw()
        {
            var strBuilder = new StringBuilder();

            strBuilder.AppendLine("                                                                                       ");
            strBuilder.AppendLine("                -----------------------------------------------------                  ");
            strBuilder.AppendLine("               |                                                     |                 ");
            strBuilder.AppendLine("               |    ******   *******    * * *      ****      *****   |                 ");
            strBuilder.AppendLine("               |   *            *      *     *     *   *     *       |                 ");
            strBuilder.AppendLine("               |    ******      *      *     *     *****     ****    |                 ");
            strBuilder.AppendLine("               |          *     *      *     *     *    *    *       |                 ");
            strBuilder.AppendLine("               |    ******      *       * * *      *     *   *****   |                 ");
            strBuilder.AppendLine("               |                                                     |                 ");
            strBuilder.AppendLine("                -----------------------------------------------------                  ");
            strBuilder.AppendLine("                               S T O R E - M E N U:                                    ");
            strBuilder.AppendLine("                                                                                       ");
            strBuilder.AppendLine("                                 1: Buy.                                               ");
            strBuilder.AppendLine("                                 2: Cart.                                              ");
            strBuilder.AppendLine("                                 3: Go Back.                                           ");
            strBuilder.AppendLine("                                                                                       ");
            strBuilder.AppendLine("+-------+--+----------------------------------------+-----------+---------------------+");
            strBuilder.AppendLine("| Count |Id|                  Name                  |   Price   |   Expiration Date   |");
            strBuilder.AppendLine("+-------+--+----------------------------------------+-----------+---------------------+");

            var counter = 0;
            foreach (var product in products)
            {
                counter += 1;
                strBuilder.AppendLine($"|{product.Quantity,7}|{counter,2}|{product.Name,40}|{product.PricePerQuantity,11}|{String.Format(product is IConsumable ? (product as IConsumable).ExpirationDate.ToString() : "[Non-consumable]"),21}|");
                strBuilder.AppendLine("+-------+--+----------------------------------------+-----------+---------------------+");
            }

            Console.WriteLine(strBuilder.ToString());
        }



        public StateType ParseKey(ConsoleKey key)
        {
            if (key == ConsoleKey.D1)
            {
                Console.Clear();
                Product wantedProduct = TakeProductID();
                Admin currentUser = new Admin("JohnSon", "testpass", "testemail@abv.bg");
                currentUser.AddItem(wantedProduct);
                wantedProduct.Quantity --;
                if (wantedProduct.Quantity == 0)
                {
                    products.Remove(wantedProduct);
                }              
            }

            if (key == ConsoleKey.D2)
                Console.Clear();
            Cart testCart = new Cart();
            testCart.ToString();

            if (key == ConsoleKey.D3)
                return StateType.MainMenu;

            return StateType.NotSet;
        }
        private Product TakeProductID()
        {
            Console.WriteLine("Enter ID of the product you would like to add to your cart: ");
            //validate (should be a number in range from 0 to all available products' count);
            int productID = int.Parse(Console.ReadLine());
            return products.FirstOrDefault(x => x.Id == productID) as Product;
        }
    }
}
