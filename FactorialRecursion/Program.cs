/*
 * Keon Bushman
 * CST - 250
 * 06/07/2026
 * Factorial Recursion
 * Activity 3
 * Activity 3 Guide
 */

//---------------------------------------------------------------
// Start of the Main Method
//---------------------------------------------------------------

// Declare and initialize
using FactorialRecursion.Services.BusinessLogicLayer;
using System.Numerics;

FactorialLogic factorialLogic = new FactorialLogic();
int input = 0;
BigInteger iterativeAns = 0, recursiveAns = 0;

// Prompt the user
Console.Write("Enter a positive number: ");

// Get the users input
input = Utility.ReadIntFromConsole();

// Solve the factorial using iteration
Console.WriteLine("Solving the factorial using iteration...");
iterativeAns = factorialLogic.SolveIterativeFactorial(input);
Console.WriteLine($"Answer: {iterativeAns}");

// Solve the factorial using recursion
Console.WriteLine("Solving the factorial using recursion...");
recursiveAns = factorialLogic.SolveRecursiveFactorial(input);
Console.WriteLine($"Answer: {recursiveAns}");

//---------------------------------------------------------------
// End of the Main Method
//---------------------------------------------------------------

//---------------------------------------------------------------
// Start of Utility class
//---------------------------------------------------------------

static class Utility
{
    /// <summary>
    /// Read an integer from the console
    /// </summary>
    /// <returns></returns>
    internal static int ReadIntFromConsole()
    {
        // Declare and initialize
        int input = 0;
        string inputString = "";

        // Get the users input
        inputString = Console.ReadLine();

        // See if the user entered valid input
        while (!int.TryParse(inputString, out input))
        {
            Console.WriteLine("Invalid number");

            // Re-Prompt the user for a number
            Console.Write("Enter a number: ");

            // Get the users input
            inputString = Console.ReadLine();
        }

        // Return the users input
        return input;
    }
}

//---------------------------------------------------------------
// End of Utility class
//---------------------------------------------------------------