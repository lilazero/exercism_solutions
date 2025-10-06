using System.Linq;

public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int n) => Enumerable.Range(1, n).Sum() * Enumerable.Range(1, n).Sum();

    public static int CalculateSumOfSquares(int n) => Enumerable.Range(1, n).Select(x => x * x).Sum();

    public static int CalculateDifferenceOfSquares(int n) =>
        CalculateSquareOfSum(n) - CalculateSumOfSquares(n);
}

