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
        /// Types of menu
        /// </summary>
        public enum Menu
        {
            /// <summary>
            /// Represents a Fibonacci task
            /// </summary>
            Fibonacci = 4,

            /// <summary>
            /// Represents task with natural sequence
            /// </summary>
            Sequence,

            /// <summary>
            /// Represents an exit
            /// </summary>
            Quit
        }

        /// <summary>
        /// Generate the Fibonacci`s sequence.
        /// </summary>
        /// <param name="n"> Is current number of sequence</param>///        
        /// <returns> One of the value of sequence</returns> 
        public int Fibonacci(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            if (n == 1)
            {
                return 1;
            }

            return this.Fibonacci(n - 1) + this.Fibonacci(n - 2);
        }

        /// <summary>
        /// Print sequence values in range
        /// </summary>
        /// <param name="left">Min value of range</param>
        /// <param name="right">Max value of range</param>
        /// <returns>String with sequence</returns>
        public string GetSequenceInRange(int left, int right)
        {
            string currentString = string.Empty;
            for (int k = 0; k < right; k++)
            {
                if (this.Fibonacci(k) >= left)
                {
                    if (this.Fibonacci(k) >= right)
                    {
                        break;
                    }

                   currentString += string.Format(this.Fibonacci(k) + ", ");
                }
            }

            return currentString;
        }        
    }
}
