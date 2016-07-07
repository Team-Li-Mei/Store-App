namespace Store.Core.Models
{
    using Contracts;
    using Infrastructure.Enumerations;
    using System;
    using System.Text;

    public class PaymentMenu: IMenu
    {
        private static PaymentMenu instance;

        private PaymentMenu() { }

        public static PaymentMenu Instance
        {
            get
            {
                if (instance == null)
                    instance = new PaymentMenu();
                return instance;
            }
        }

        public void Draw()
        {
            var strBuilder = new StringBuilder();

            strBuilder.AppendLine("                                                                                    ");
            strBuilder.AppendLine(" --------------------------------------------------------------------------------   ");
            strBuilder.AppendLine("|                                                                                 | ");
            strBuilder.AppendLine("|   *****       *        *     *       *    *       *****    *      *    *******  | ");
            strBuilder.AppendLine("|   *   *      * *        *   *       *  * * *      *        * *    *       *     | ");
            strBuilder.AppendLine("|   *****     * * *         *        *    *   *     ****     *  *   *       *     | ");
            strBuilder.AppendLine("|   *        *     *        *       *          *    *        *   *  *       *     | ");
            strBuilder.AppendLine("|   *       *       *       *      *            *   *****    *    * *       *     | ");
            strBuilder.AppendLine("|                                                                                 | ");
            strBuilder.AppendLine(" ---------------------------------------------------------------------------------  ");
            strBuilder.AppendLine("                                                                                    ");
            strBuilder.AppendLine("                              P A Y M E N T - M E N U:                              ");
            strBuilder.AppendLine("                                                                                    ");
            strBuilder.AppendLine("                                   1: .                                             ");
            strBuilder.AppendLine("                                   2: .                                             ");
            strBuilder.AppendLine("                                   3: Go back.                                      ");
            strBuilder.AppendLine("                                   4: Exit.                                         ");

            Console.WriteLine(strBuilder.ToString());
        }

        public StateType ParseKey(ConsoleKey key)
        {
            if (key == ConsoleKey.D1)
                return StateType.NotSet;
            if (key == ConsoleKey.D2)
                return StateType.NotSet;
            if (key == ConsoleKey.D2)
                return StateType.CartMenu;
            if (key == ConsoleKey.D4)
                Environment.Exit(0);

            return StateType.NotSet;
        }
    }
}
