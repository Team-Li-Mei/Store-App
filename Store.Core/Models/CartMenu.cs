namespace Store.Core.Models
{
    using Contracts;
    using System;
    using Infrastructure.Enumerations;
    using System.Text;


    public class CartMenu : IMenu
    {
        private static CartMenu instance;

        private CartMenu() { }

        public static CartMenu Instance
        {
            get
            {
                if (instance == null)
                    instance = new CartMenu();
                return instance;
            }
        }
        public void Draw()
        {
            var strBuilder = new StringBuilder();

            strBuilder.AppendLine("                                             ");
            strBuilder.AppendLine(" ------------------------------------------- ");
            strBuilder.AppendLine("|                                           |");
            strBuilder.AppendLine("|   * * *        *        ****     *******  |");
            strBuilder.AppendLine("|  *            * *       *   *       *     |");
            strBuilder.AppendLine("|  *           * * *      *****       *     |");
            strBuilder.AppendLine("|  *          *     *     *    *      *     |");
            strBuilder.AppendLine("|   * * *    *       *    *     *     *     |");
            strBuilder.AppendLine("|                                           |");
            strBuilder.AppendLine(" ------------------------------------------- ");
            strBuilder.AppendLine("                                             ");
            strBuilder.AppendLine("             C A R T - M E N U:              ");
            strBuilder.AppendLine("                                             ");
            strBuilder.AppendLine("             1: .                            ");
            strBuilder.AppendLine("             2: .                            ");
            strBuilder.AppendLine("             3: .                            ");
            strBuilder.AppendLine("             4: Go back.                     ");

            Console.WriteLine(strBuilder.ToString());
        }

        public StateType ParseKey(ConsoleKey key)
        {
            if (key == ConsoleKey.D1)
                return StateType.NotSet;
            if (key == ConsoleKey.D2)
                return StateType.NotSet;
            if (key == ConsoleKey.D3)
                return StateType.NotSet;
            if (key == ConsoleKey.D4)
                return StateType.StoreMenu;

            return StateType.NotSet;
        }
    }
}
