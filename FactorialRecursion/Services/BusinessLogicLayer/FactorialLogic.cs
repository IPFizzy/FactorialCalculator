/*
 * Keon Bushman
 * CST - 250
 * 06/07/2026
 * Factorial Recursion
 * Activity 3
 * Activity 3 Guide
 */

using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace FactorialRecursion.Services.BusinessLogicLayer
{
    internal class FactorialLogic
    {
        /// <summary>
        /// Solve the factorial problem using iteration
        /// </summary>
        /// <param name="factorial"></param>
        /// <returns></returns>
        internal BigInteger SolveIterativeFactorial(int factorial)
        {
            // Declare and initialize
            BigInteger result = 1;

            // Loop through each number from the factorial to 1
            for (int i = factorial; i > 0; i--)
            {
                // Multiply the current result by the current number
                result *= i;
            }

            // Return the factorial result
            return result;
        }

        /// <summary>
        /// Solve the factorial problem using recursion
        /// </summary>
        /// <param name="factorial"></param>
        /// <returns></returns>
        internal BigInteger SolveRecursiveFactorial(int factorial)
        {
            // Base case: factorial is 0 or 1
            if (factorial == 0 || factorial == 1)
            {
                return 1;
            }

            // Perform the recursion
            return factorial * SolveRecursiveFactorial(factorial - 1);
        }
    }
}
