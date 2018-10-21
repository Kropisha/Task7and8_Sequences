// <copyright file="Fibonacci.cs" company="My Company Name">
// Copyright (c) 2018 All Rights Reserved
// </copyright>
// <author>Yuliia Kropyvna</author>
namespace Tasks7and8
{
    using System;
    using ShowMenuLib;

    /// <summary>
    /// This class for representing Fibonacci`s task
    /// </summary>
    internal class Fibonacci
    {
        /// <summary>
        /// Current menu with Fibonacci sequence
        /// </summary>
        internal void MenuForFibonacci()
        {
            BusinessLogic.UsersAction action;
            do
            {
                UI menu = new UI();
                Help helper = new Help();
                Console.SetCursorPosition(0, 0);
                Enum.TryParse(menu.ShowMenu(" Welcome to the Fibonacci program!").ToString(), out action);
                Console.WriteLine();
                Console.ResetColor();

                switch (action)
                {
                    case BusinessLogic.UsersAction.Help:
                        Console.WriteLine(helper.References(@"..\..\Files\FibRef.txt"));
                        Console.ReadKey();
                        break;
                    case BusinessLogic.UsersAction.Program:
                        this.FibonacciTask();
                        break;
                    case BusinessLogic.UsersAction.Back:
                        UI user = new UI();
                        Console.Clear();
                        menu.ConsoleMenuPaint(user.X, "Fibonacci algoritm", "Numeric sequence");
                        menu.ColourMenu(user.X);
                        break;
                    case BusinessLogic.UsersAction.Quit:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }

                Console.Clear();
            }
            while (action != BusinessLogic.UsersAction.Quit);
        }

        /// <summary>
        /// Fibonacci implementation
        /// </summary>
        private void FibonacciTask()
        {
            Console.ResetColor();
            bool success = true;
            int left = 1, right = 1;
            try
            {
                Console.WriteLine("Please, enter the left range: ");
                left = int.Parse(Console.ReadLine());
                Console.WriteLine("Please, enter the right range: ");
                right = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                success = false;
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Please write the number!");
                Console.Beep();
                Console.WriteLine("Press any key...");
                Console.ReadKey();
                Console.Clear();
                Console.ResetColor();
            }

            if (success)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The result is: ");
                if (right > left)
                {
                    if (left < 0 && right <= 0)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("The sequence does not exist in negative range.");
                        Console.Beep();
                        Console.WriteLine("Press any key...");
                        Console.ReadKey();
                        Console.ResetColor();
                    }

                    BusinessLogic bl = new BusinessLogic();
                    string result = bl.GetSequenceInRange(left, right);
                    Console.WriteLine(result);
                    Console.WriteLine("Press any key...");
                    Console.ReadKey();
                    Console.ResetColor();
                }
                else
                {
                    success = false;
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("It should be a positive range! [from,to]");
                    Console.Beep();
                    Console.WriteLine("Press any key...");
                    Console.ReadKey();
                    Console.Clear();
                    Console.ResetColor();
                }
            }
        }
    }
}
