namespace Store.Core.Models.Menus
{
    using System;
    using Contracts;
    using Infrastructure.Enumerations;
    using System.Text;
    using System.Collections.Generic;

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

                //command for buy
                return StateType.EnterUsername;
            if (key == ConsoleKey.D2)
                return StateType.CartMenu;
            if (key == ConsoleKey.D3)
                return StateType.MainMenu;

            return StateType.NotSet;
        }
    }
}
