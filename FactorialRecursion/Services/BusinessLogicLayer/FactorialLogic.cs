using System.Numerics;

namespace FactorialRecursion.Services.BusinessLogicLayer
{
    internal class FactorialLogic
    {
        /// <summary>
        /// Calculates a factorial using iteration.
        /// </summary>
        internal BigInteger SolveIterativeFactorial(int factorial)
        {
            ValidateInput(factorial);

            BigInteger result = 1;

            for (int i = factorial; i > 1; i--)
            {
                result *= i;
            }

            return result;
        }

        /// <summary>
        /// Calculates a factorial using recursion.
        /// </summary>
        internal BigInteger SolveRecursiveFactorial(int factorial)
        {
            ValidateInput(factorial);

            if (factorial <= 1)
            {
                return 1;
            }

            return factorial * SolveRecursiveFactorial(factorial - 1);
        }

        /// <summary>
        /// Rejects values for which factorial is not defined by this application.
        /// </summary>
        private static void ValidateInput(int factorial)
        {
            if (factorial < 0)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(factorial),
                    "Factorial requires a non-negative integer.");
            }
        }
    }
}
