//-----------------------------------------------------------------------
// <copyright file="Startup.cs" company="Team Li Mei">
//     Telerik Academy C# OOP Teamwork project.
// </copyright>
//-----------------------------------------------------------------------

namespace Store.Client
{
    using Core.Contracts;
    using Core.Models;
    using System;
    using System.Text;
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
            #region DrawMainMenu
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
            strBuilder.AppendLine("                  1: Login                              ");
            strBuilder.AppendLine("                  2: Register                           ");
            strBuilder.AppendLine("                  3: Exit                               ");

            var mainMenu = strBuilder.ToString();
            strBuilder.Clear();

            #endregion

            while (true)
            {
                Console.WriteLine(mainMenu);

                var input = Console.ReadKey();
                Console.WriteLine();

                switch (input.Key)
                {
                    case ConsoleKey.Escape:
                        break;
                    case ConsoleKey.D1:
                        break;
                    case ConsoleKey.D2:
                        break;
                    case ConsoleKey.D3:
                        Environment.Exit(0);
                        break;
                }
                Console.Clear();
            }
        }
    }
}
