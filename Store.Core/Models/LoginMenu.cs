namespace Store.Core.Models
{
    using System;
    using Contracts;
    using Infrastructure.Enumerations;
    using System.Text;

    public class LoginMenu : IMenu
    {
        private static LoginMenu instance;

        private LoginMenu() { }

        public static LoginMenu Instance
        {
            get
            {
                if (instance == null)
                    instance = new LoginMenu();
                return instance;
            }
        }
        public void Draw()
        {
            var strBuilder = new StringBuilder();

            strBuilder.AppendLine("                                                        ");
            strBuilder.AppendLine(" -----------------------------------------------------  ");
            strBuilder.AppendLine("|                                                     | ");
            strBuilder.AppendLine("|   *          * * *     * * *     *    *      *      | ");
            strBuilder.AppendLine("|   *         *     *   *          *    * *    *      | ");
            strBuilder.AppendLine("|   *         *     *   *   * *    *    *  *   *      | ");
            strBuilder.AppendLine("|   *         *     *   *     *    *    *   *  *      | ");
            strBuilder.AppendLine("|   *******    * * *     * * *     *    *    * *      | ");
            strBuilder.AppendLine("|                                                     | ");
            strBuilder.AppendLine(" -----------------------------------------------------  ");
            strBuilder.AppendLine("                                                        ");
            strBuilder.AppendLine("              L O G I N - M E N U:                      ");
            strBuilder.AppendLine("                                                        ");
            strBuilder.AppendLine("                  1: Enter username.                    ");
            strBuilder.AppendLine("                  2: Enter password.                    ");
            strBuilder.AppendLine("                  3: Login.                             ");
            strBuilder.AppendLine("                  4: Go back.                           ");

            Console.WriteLine(strBuilder.ToString());
        }

        public StateType ParseKey(ConsoleKey key)
        {
            if (key == ConsoleKey.D1)
                return StateType.EnterUsername;
            if (key == ConsoleKey.D2)
                return StateType.EnterPassword;
            if (key == ConsoleKey.D3)
                return StateType.Login;
            if (key == ConsoleKey.D4)
                return StateType.MainMenu;

            return StateType.NotSet;
        }
    }
}
