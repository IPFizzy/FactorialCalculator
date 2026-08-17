using FactorialRecursion.Services.BusinessLogicLayer;
using System.Numerics;

const int MaxInput = 500;

FactorialLogic factorialLogic = new FactorialLogic();

Console.WriteLine("Factorial Calculator");
Console.WriteLine("--------------------");
Console.Write($"Enter a whole number from 0 to {MaxInput}: ");

int input = Utility.ReadIntFromConsole(0, MaxInput);

Console.WriteLine("\nSolving with iteration...");
BigInteger iterativeAnswer = factorialLogic.SolveIterativeFactorial(input);
Console.WriteLine($"{input}! = {iterativeAnswer}");

Console.WriteLine("\nSolving with recursion...");
BigInteger recursiveAnswer = factorialLogic.SolveRecursiveFactorial(input);
Console.WriteLine($"{input}! = {recursiveAnswer}");

Console.WriteLine($"\nResults match: {iterativeAnswer == recursiveAnswer}");

static class Utility
{
    /// <summary>
    /// Reads an integer within the requested inclusive range.
    /// </summary>
    internal static int ReadIntFromConsole(int minimum, int maximum)
    {
        while (true)
        {
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int value) &&
                value >= minimum && value <= maximum)
            {
                return value;
            }

            Console.WriteLine($"Please enter a whole number from {minimum} to {maximum}.");
            Console.Write("Try again: ");
        }
    }
}
