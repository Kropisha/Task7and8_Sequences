// <copyright file="Program.cs" company="My Company">
// Copyright (c) 2018 All Rights Reserved
// </copyright>
// <author>Yuliia Kropyvna</author>
namespace Tasks7and8
{
    using System;

    /// <summary>
    /// This class is for User Interface
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Entry point to the program
        /// </summary>
        /// <param name="args">Args of command line</param>
        public static void Main(string[] args)
        {
            Console.Title = "Fibonacci";
            UI user = new UI();
            user.ConsoleMenuPaint(user.X, "Fibonacci algoritm", "Numeric sequence");
            user.ColourMenu(user.X);
        }     
    }
}
