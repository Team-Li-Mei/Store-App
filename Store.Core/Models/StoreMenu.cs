namespace Store.Core.Models
{
    using System;
    using Contracts;
    using Infrastructure.Enumerations;
    using System.Text;
    using Common;
    using System.Collections.Generic;

    public class StoreMenu : IMenu
    {
        private static StoreMenu instance;

        private static List<Item> items;

        private StoreMenu(List<Item> setItems)
        {
            items = setItems;
        }

        public static StoreMenu Instance(List<Item> setItems)
        {
            if (instance == null)
                instance = new StoreMenu(setItems);
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
            foreach (var item in items)
            {
                counter += 1;
                strBuilder.AppendLine($"|{item.Count,7}|{counter,2}|{item.Name,40}|{item.Price,11}|{item.ExpirationDate,21}|");
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
