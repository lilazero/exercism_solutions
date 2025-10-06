using System;
using System.Collections.Generic;
using System.Linq;

public static class SaddlePoints
{
    //wanted to write clean code, wrote a mess instead
    public static IEnumerable<(int, int)> Calculate(int[,] matrix)
    {
        var rows = matrix.GetLength(0);
        var cols = matrix.GetLength(1);
        var maxInRow = new int[rows];
        var minInCol = new int[cols];

        // Find the maximum value in each row
        MaxInEachRow(matrix, rows, cols, maxInRow);

        // Find the minimum value in each column

        MinInEachColumn(matrix, rows, cols, minInCol);

        // Find the saddle points
        return FindMaxInRowAndMinInCol(matrix, maxInRow,minInCol); 
    }


    /// <summary>
    /// Find the saddle points
    /// </summary>
    /// <param name="matrix"> The input matrix </param>
    /// <param name="maxInRow"> Selbstverstandlich </param>
    /// <param name="minInCol"> Lo capisci da solo </param>
    /// <returns></returns>
    private static IEnumerable<(int, int)> FindMaxInRowAndMinInCol(int[,] matrix, int[] maxInRow, int[] minInCol)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (var row = 0; row < rows; row++)
        {
            for (var col = 0; col < cols; col++)
            {
                if (matrix[row, col] == maxInRow[row] && matrix[row, col] == minInCol[col])
                {
                    yield return (row + 1, col + 1);
                }
            }
        }
    }

    /// <summary>
    /// Finds the maximum value in each row of a given matrix and stores it in an array.
    /// </summary>
    /// <param name="matrix">The matrix to search for maximum values in each row.</param>
    /// <param name="rows">The number of rows in the matrix.</param>
    /// <param name="cols">The number of columns in the matrix.</param>
    /// <param name="maxInRow">The array to store the maximum value in each row.</param>
    private static void MaxInEachRow(int[,] matrix, int rows, int cols, int[] maxInRow)
    {
        for (var row = 0; row < rows; row++)
            {
                maxInRow[row] = Enumerable.Range(0, cols)
                    .Select(col => matrix[row, col])
                    .Max();
            }
    }


    private static void MinInEachColumn(int[,] matrix, int rows, int cols, int[] minInCol)
    {
        for (var col = 0; col < cols; col++)
                {
                    minInCol[col] = Enumerable.Range(0, rows)
                        .Select(row => matrix[row, col])
                        .Min();
                }
            }
}