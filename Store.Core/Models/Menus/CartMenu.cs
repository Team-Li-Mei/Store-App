namespace Store.Core.Models.Menus
{
    using Contracts;
    using System;
    using Infrastructure.Enumerations;
    using System.Text;

    public class CartMenu : IMenu
    {
        private static CartMenu instance;

        private static ICart cart;

        private CartMenu(ICart setCart)
        {
            cart = setCart;
        }

        public static CartMenu Instance(ICart setCart)
        {
            if (instance == null)
                instance = new CartMenu(setCart);
            return instance;
        }
        public void Draw()
        {
            var strBuilder = new StringBuilder();
            strBuilder.AppendLine("                                                                                       ");
            strBuilder.AppendLine("                -----------------------------------------------------                  ");
            strBuilder.AppendLine("               |                                                     |                 ");
            strBuilder.AppendLine("               |     *******        **        *****   *********      |                 ");
            strBuilder.AppendLine("               |   *               *  *       *    *  *   *   *      |                 ");
            strBuilder.AppendLine("               |   *              ******      *****       *          |                 ");
            strBuilder.AppendLine("               |   *             *      *     **          *          |                 ");
            strBuilder.AppendLine("               |   *            *        *    * *         *          |                 ");
            strBuilder.AppendLine("               |     *******   *          *   *  ***      *          |                 ");
            strBuilder.AppendLine("               |                                                     |                 ");
            strBuilder.AppendLine("                -----------------------------------------------------                  ");
            strBuilder.AppendLine("                             S H O P P I N G - C A R T:                                ");
            strBuilder.AppendLine("                                                                                       ");
            strBuilder.AppendLine("                                   M E N U:                                            ");
            strBuilder.AppendLine("                                                                                       ");
            strBuilder.AppendLine("                                   1: .                                                ");
            strBuilder.AppendLine("                                   2: .                                                ");
            strBuilder.AppendLine("                                   3: Pay.                                             ");
            strBuilder.AppendLine("                                   4: Go back.                                         ");
            strBuilder.AppendLine("                                                                                       ");
            strBuilder.AppendLine("+----------+--------------------------------------------------------------------------+");
            strBuilder.AppendLine("|    Id    |                             Name                                         |");
            strBuilder.AppendLine("+----------+--------------------------------------------------------------------------+");
            strBuilder.AppendLine(cart.ToString());

            Console.WriteLine(strBuilder.ToString());
        }

        public StateType ParseKey(ConsoleKey key)
        {
            if (key == ConsoleKey.D1)
                return StateType.NotSet;
            if (key == ConsoleKey.D2)
                return StateType.NotSet;
            if (key == ConsoleKey.D3)
                return StateType.PaymentMenu;
            if (key == ConsoleKey.D4)
                return StateType.StoreMenu;

            return StateType.NotSet;
        }
    }
}
