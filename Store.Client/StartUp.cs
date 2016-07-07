//-----------------------------------------------------------------------
// <copyright file="Startup.cs" company="Team Li Mei">
//     Telerik Academy C# OOP Teamwork project.
// </copyright>
//-----------------------------------------------------------------------

namespace Store.Client
{
    using Core.Infrastructure.Enumerations;
    using Core.Models;
    using System;

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
            StateType state = StateType.MainMenu;
            while (true)
            {
                switch (state)
                {
                    case StateType.MainMenu:
                        MainMenu.Instance.Draw();
                        state = MainMenu.Instance.ParseKey(Console.ReadKey().Key);
                        break;
                    case StateType.LoginMenu:
                        LoginMenu.Instance.Draw();
                        state = LoginMenu.Instance.ParseKey(Console.ReadKey().Key);
                        //if state == statetype.bla 
                        //do this
                        break;
                    case StateType.RegisterMenu:
                        RegisterMenu.Instance.Draw();
                        state = RegisterMenu.Instance.ParseKey(Console.ReadKey().Key);
                        break;
                    default:
                        break;
                }

                Console.WriteLine();
                Console.Clear();
            }
        }
    }
}
