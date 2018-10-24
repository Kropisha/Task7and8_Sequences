// <copyright file="Sequence.cs" company="My Company Name">
// Copyright (c) 2018 All Rights Reserved
// </copyright>
// <author>Yuliia Kropyvna</author>
namespace Tasks7and8
{
    using System;
    using AgainFibonacci;
    using ShowMenuLib;

    /// <summary>
    /// This class for representing Sequence task
    /// </summary>
    internal class Sequence 
    {
        /// <summary>
        /// Current menu with sequence of natural values
        /// </summary>
        internal void MenuForSequence()
        {
            UsersAction action;
            do
            {
                UI menu = new UI();
                Help helper = new Help();
                Console.SetCursorPosition(0, 0);
                Enum.TryParse(menu.ShowMenu(" Welcome to the sequense of natural number program!").ToString(), out action);
                Console.WriteLine();
                Console.ResetColor();

                switch (action)
                {
                    case UsersAction.Help:
                        Console.WriteLine(helper.References(@"..\..\Files\SeqRef.txt"));
                        Console.ReadKey();
                        break;
                    case UsersAction.Program:
                        this.SequenceTask();
                        break;
                    case UsersAction.Back:
                        UI user = new UI();
                        Console.Clear();
                        menu.ConsoleMenuPaint(user.X, "Fibonacci algoritm", "Numeric sequence");
                        menu.ColourMenu(user.X);
                        break;
                    case UsersAction.Quit:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }

                Console.Clear();
            }
            while (action != UsersAction.Quit);
        }

        /// <summary>
        /// Sequence implementation
        /// </summary>
        private void SequenceTask()
        {
            bool success = true;
            Console.ResetColor();
            int n = 1;
            Console.WriteLine("Enter the max value of square: ");
            try
            {
                n = int.Parse(Console.ReadLine());
            }
            catch
            {
                success = false;
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("You should write a positive number!");
                Console.Beep();
                Console.WriteLine("Press any key...");
                Console.ReadKey();
                Console.Clear();
                Console.ResetColor();
            }

            if (n < 1)
            {
                success = false;
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("You should write a positive number!");
                Console.Beep();
                Console.WriteLine("Press any key...");
                Console.ReadKey();
                Console.Clear();
                Console.ResetColor();
            }

            if (success == true)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("Get your sequence: ");
                BusinessLogic bl = new BusinessLogic();
                Console.WriteLine(bl.GetSequence(n));
                Console.WriteLine();
                Console.WriteLine("Press any key...");
                Console.ReadKey();
                Console.ResetColor();
            }
        }
    }
}
