using System;
/// <summary>
/// Provides methods for basic math operations.
/// </summary>
public static class SimpleCalculator  
{
    /// <summary>
    /// Calculates the result of the given math operation on two numbers.
    /// </summary>
    /// <param name="a">The first number.</param>
    /// <param name="b">The second number.</param>
    /// <param name="op">The operation to perform.</param>
    /// <returns>A string with the equation and result.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="op"/> is null.</exception>
    /// <exception cref="ArgumentException">Thrown when <paramref name="op"/> is empty.</exception>
    /// <exception cref="DivideByZeroException">Thrown when dividing by 0.</exception>
  public static string Calculate(int a, int b, string op)
  {
    if (op == null) 
      throw new ArgumentNullException(nameof(op));

    if (op == "")
      throw new ArgumentException("Operation cannot be empty", nameof(op));

    try 
    {
      return CalculateInternal(a, b, op);
    }
    catch(DivideByZeroException)
    {
      return "Division by zero is not allowed.";
    }
  }

  private static string CalculateInternal(int a, int b, string op)
  {
    switch(op)
    {
      case "+":
        return $"{a} + {b} = {a + b}";
      case "*":  
        return $"{a} * {b} = {a * b}";
      case "/":
          return $"{a} / {b} = {a / b}";
      default:
        throw new ArgumentOutOfRangeException(nameof(op), $"Unknown operation: {op}");
    }
  }
}