// <copyright file="BusinessLogic.cs" company="My Company Name">
// Copyright (c) 2018 All Rights Reserved
// </copyright>
// <author>Yuliia Kropyvna</author>

namespace Tasks7and8
{
    using System;
    using System.IO;

    /// <summary>
    /// This class for logic of my program
    /// </summary>
    public class BusinessLogic
    {
        /// <summary>
        /// Types of user choice
        /// </summary>
        public enum UsersAction
        {
            /// <summary>
            /// Represents a reference
            /// </summary>
            Help = 1,

            /// <summary>
            /// Represents a start
            /// </summary>
            Program,

            /// <summary>
            /// Represents a path to main menu
            /// </summary>
            Back,

            /// <summary>
            /// Represents an exit
            /// </summary>
            Quit
        }

        /// <summary>
        /// This is the standard recursive method of the Fibonacci algorithm.
        /// </summary>
        /// <param name="n"> Is current number of sequence</param>///        
        /// <returns> The value of sequence</returns>
        public int Fibb(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            if (n == 1)
            {
                return 1;
            }

            return this.Fibb(n - 1) + this.Fibb(n - 2);
        }

        /// <summary>
        /// Print sequence value in range
        /// </summary>
        /// <param name="left">Min value of range</param>
        /// <param name="right">Max value of range</param>
        /// <param name="currentString">Current string with Fibonacci sequence</param>
        public void PrintInRange(int left, int right, out string currentString)
        {
            currentString = string.Empty;
            for (int k = 0; k < right; k++)
            {
                if (this.Fibb(k) >= left)
                {
                    if (this.Fibb(k) >= right)
                    {
                        break;
                    }

                    currentString += string.Format(this.Fibb(k) + ", ");
                }
            }
        }        
    }
}
