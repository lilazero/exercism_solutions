using System;

public static class Grains
{
    /// <summary>
    /// Calculate the number of grains of wheat on a chessboard given that the number on each square doubles.
    /// </summary>
    /// <param name="n"></param>
    /// <returns> the number of grains of wheat per square </returns>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public static ulong Square(int n)
    {
        if (n < 1 || n > 64)
        {
            throw new ArgumentOutOfRangeException();
        }
        return (ulong)Math.Pow(2, n - 1);
    }

    /// <summary>
    /// Calculate the TOTAL number of grains of wheat on the chessboard given that the number on each square doubles.
    /// </summary>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public static ulong Total()
    {
        ulong total = 0;
        for (int i = 1; i <= 64; i++)
        {
            total += Square(i);
        }
        return total;
    }
}