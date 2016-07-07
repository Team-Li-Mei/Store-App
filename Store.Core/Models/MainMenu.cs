namespace Store.Core.Models
{
    using Contracts;
    using System;
    using System.Text;
    using Infrastructure.Enumerations;

    /// <summary>
    /// Singleton
    /// </summary>
    public class MainMenu : IMenu
    {
        private static MainMenu instance;

        private MainMenu() { }

        public static MainMenu Instance
        {
            get
            {
                if (instance == null)
                    instance = new MainMenu();
                return instance;
            }
        }

        public void Draw()
        {
            var strBuilder = new StringBuilder();

            strBuilder.AppendLine("                                                        ");
            strBuilder.AppendLine(" -----------------------------------------------------  ");
            strBuilder.AppendLine("|                                                     | ");
            strBuilder.AppendLine("|    ******   *******    * * *      ****      *****   | ");
            strBuilder.AppendLine("|   *            *      *     *     *   *     *       | ");
            strBuilder.AppendLine("|    ******      *      *     *     *****     ****    | ");
            strBuilder.AppendLine("|          *     *      *     *     *    *    *       | ");
            strBuilder.AppendLine("|    ******      *       * * *      *     *   *****   | ");
            strBuilder.AppendLine("|                                                     | ");
            strBuilder.AppendLine(" -----------------------------------------------------  ");
            strBuilder.AppendLine("                                                        ");
            strBuilder.AppendLine("                M A I N - M E N U:                      ");
            strBuilder.AppendLine("                                                        ");
            strBuilder.AppendLine("                  1: Login - menu.                      ");
            strBuilder.AppendLine("                  2: Register - menu.                   ");
            strBuilder.AppendLine("                  3: Exit.                              ");

            Console.WriteLine(strBuilder.ToString());
        }

        public StateType ParseKey(ConsoleKey key)
        {
            if (key == ConsoleKey.D1)
                return StateType.LoginMenu;
            if (key == ConsoleKey.D2)
                return StateType.RegisterMenu;
            if (key == ConsoleKey.D3)
                Environment.Exit(0);

            return StateType.NotSet;
        }
    }
}
