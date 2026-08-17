# Factorial Calculator

A compact **C# .NET console application** that calculates factorials using both iterative and recursive approaches and verifies that the two implementations produce the same result.

<p>
  <img src="https://img.shields.io/badge/C%23-512BD4?style=flat-square&logo=dotnet&logoColor=white" alt="C#" />
  <img src="https://img.shields.io/badge/.NET-10.0-512BD4?style=flat-square&logo=dotnet&logoColor=white" alt=".NET 10" />
  <img src="https://img.shields.io/badge/BigInteger-Arbitrary%20Precision-238636?style=flat-square" alt="BigInteger" />
  <img src="https://img.shields.io/badge/Status-Complete-238636?style=flat-square" alt="Project status: Complete" />
</p>

## Overview

Factorial Calculator is a focused practice project for comparing two ways to solve the same mathematical problem. The user enters a non-negative integer, the application calculates its factorial once with a loop and once with recursion, and the final output confirms whether the results match.

`BigInteger` is used instead of fixed-width integer types so the application can represent factorial values far beyond the range of `int` or `long`.

## Features

- Iterative factorial calculation
- Recursive factorial calculation
- Side-by-side result verification
- Non-negative integer validation
- Defensive argument validation inside the factorial service
- `BigInteger` support for large results
- Explicit handling of the `0! = 1` base case
- Console input limited to a practical range for the recursive demonstration

## Factorial Definition

For a non-negative integer `n`, factorial is defined as:

```text
n! = n × (n - 1) × (n - 2) × ... × 1
```

with the base case:

```text
0! = 1
```

For example:

```text
5! = 5 × 4 × 3 × 2 × 1 = 120
```

## Two Implementations

### Iterative

The iterative version starts with a result of `1` and multiplies it by each value from `n` down to `2`.

```text
result = 1
result *= n
result *= n - 1
...
```

It performs a linear number of multiplication steps and does not require a growing call stack.

### Recursive

The recursive version expresses the problem in terms of a smaller factorial:

```text
factorial(n) = n × factorial(n - 1)
```

until reaching `0` or `1`.

This also performs a linear number of recursive steps, but each pending call occupies stack space until the base case is reached.

## Input Safety

The console accepts values from `0` through `500`.

The upper bound is intentional. `BigInteger` can represent much larger factorials, but a recursive implementation consumes stack space for every nested call. Keeping the interactive range bounded makes the project a safe recursion demonstration rather than encouraging unnecessarily deep recursion.

The business-logic class also rejects negative arguments directly, so the factorial methods remain protected even when called independently of the console interface.

## Example

```text
Factorial Calculator
--------------------
Enter a whole number from 0 to 500: 5

Solving with iteration...
5! = 120

Solving with recursion...
5! = 120

Results match: True
```

## Technology

| Area | Technology |
| --- | --- |
| Language | C# |
| Runtime | .NET 10 |
| Numeric Type | `System.Numerics.BigInteger` |
| Interface | Console |
| Concepts | Iteration, recursion, validation, base cases |

## Project Structure

```text
FactorialRecursion/
├── FactorialRecursion/
│   ├── Services/
│   │   └── BusinessLogicLayer/
│   │       └── FactorialLogic.cs
│   ├── Program.cs
│   └── FactorialRecursion.csproj
└── FactorialRecursion.slnx
```

## Running the Project

### Requirements

- .NET 10 SDK, or
- Visual Studio with .NET development support

Clone the repository:

```bash
git clone https://github.com/IPFizzy/FactorialRecursion.git
cd FactorialRecursion
```

Run from the repository root:

```bash
dotnet run --project FactorialRecursion/FactorialRecursion.csproj
```

Or open `FactorialRecursion.slnx` in Visual Studio and run the project.

## Practice Project Context

This repository is preserved as a completed recursion and iteration exercise. It demonstrates two implementations of the same calculation, explicit base cases, input contracts, arbitrary-precision arithmetic, result verification, and the practical difference between loop-based and recursive control flow.

## Recommended Repository Name

For a public portfolio, **`FactorialCalculator`** is clearer than `FactorialRecursion` because the project demonstrates both recursive and iterative approaches rather than recursion alone.

The internal project, solution, folder, and namespace names can remain unchanged after the GitHub repository itself is renamed.

## Author

**Keon Bushman**  
Software Development Student & IT Professional  
[GitHub Profile](https://github.com/IPFizzy)
