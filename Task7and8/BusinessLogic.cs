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
        /// Generate the Fibonacci`s sequence.
        /// </summary>
        /// <param name="n"> Is current number of sequence</param>///        
        /// <returns> One of the value of sequence</returns> 
        public int Fibonacci(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("The value should not be less then 0.");
            }

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
            if (left < 1 && right < 1)
            {
                throw new ArgumentException("Range value should not be less then 1.");
            }

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

        /// <summary>
        /// Get sequence of natural numbers
        /// </summary>
        /// <param name="n">max value</param>
        /// <returns>string with sequence</returns>
        public string GetSequence(int n)
        {
            if (n < 1)
            {
                throw new ArgumentException("Max value should not be less then 1.");
            }

            string sequence = string.Empty;
            for (int k = 1; k * k < n; k++)
            {
                sequence += (k + ", ");
            }
            
            return sequence;
        }
    }
}
