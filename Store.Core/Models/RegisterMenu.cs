namespace Store.Core.Models
{
    using System;
    using Contracts;
    using Infrastructure.Enumerations;
    using System.Text;

    public class RegisterMenu : IMenu
    {
        private static RegisterMenu instance;

        private RegisterMenu() { }

        public static RegisterMenu Instance
        {
            get
            {
                if (instance == null)
                    instance = new RegisterMenu();
                return instance;
            }
        }
        public void Draw()
        {
            var strBuilder = new StringBuilder();

            strBuilder.AppendLine("                                                                            ");
            strBuilder.AppendLine(" -------------------------------------------------------------------------  ");
            strBuilder.AppendLine("|                                                                         | ");
            strBuilder.AppendLine("|    ****      *****    * * *    *    ******   *******   *****   ****     | ");
            strBuilder.AppendLine("|    *   *     *       *         *   *            *      *       *   *    | ");
            strBuilder.AppendLine("|    *****     ****    *   * *   *    ******      *      ****    *****    | ");
            strBuilder.AppendLine("|    *    *    *       *     *   *          *     *      *       *    *   | ");
            strBuilder.AppendLine("|    *     *   *****    * * *    *    ******      *      *****   *     *  | ");
            strBuilder.AppendLine("|                                                                         | ");
            strBuilder.AppendLine(" -------------------------------------------------------------------------  ");
            strBuilder.AppendLine("                                                                            ");
            strBuilder.AppendLine("                   R E G I S T E R - M E N U:                               ");
            strBuilder.AppendLine("                                                                            ");
            strBuilder.AppendLine("                       1: Enter username.                                   ");
            strBuilder.AppendLine("                       2: Enter password.                                   ");
            strBuilder.AppendLine("                       3: Register.                                         ");
            strBuilder.AppendLine("                       4: Go back.                                          ");

            Console.WriteLine(strBuilder.ToString());
        }

        public StateType ParseKey(ConsoleKey key)
        {
            if (key == ConsoleKey.D1)
                return StateType.EnterUsername;
            if (key == ConsoleKey.D2)
                return StateType.EnterPassword;
            if (key == ConsoleKey.D3)
                return StateType.Register;
            if (key == ConsoleKey.D4)
                return StateType.GoBack;

            return StateType.NotSet;
        }
    }
}
