// <copyright file="UI.cs" company="My Company">
// Copyright (c) 2018 All Rights Reserved
// </copyright>
// <author>Yuliia Kropyvna</author>
namespace Tasks7and8
{
    using System;
    using ShowMenuLib;

    /// <summary>
    /// Present visualization for user
    /// </summary>   
    public class UI : GetMenu
    { 
        /// <summary>
        /// Show logic depending on the choice
        /// </summary>
        /// <param name="i">position of user choice(from top)</param>
         public override void UserChoice(int i)
        {
            if (i == 4)
            {
                Fibonacci fib = new Fibonacci();
                fib.MenuForFibonacci();
            }

            if (i == 5)
            {
                Sequence seq = new Sequence();
                seq.MenuForSequence();
            }

            if (i == 6)
            {
                Environment.Exit(0);
            }
        }
    }
}
