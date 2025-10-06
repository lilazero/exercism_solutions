using System;

/// <summary>
/// Calculates the Hamming distance between two DNA strands.
/// </summary>
public static class Hamming
{
    /// <summary>
    /// Calculates the Hamming distance between two DNA strands.
    /// </summary>
    /// <param name="firstStrand">The first DNA strand.</param>
    /// <param name="secondStrand">The second DNA strand.</param>
    /// <returns>The Hamming distance between the two DNA strands.</returns>
    /// <exception cref="ArgumentException">Thrown when the two strands are not of equal length.</exception>
    public static int Distance(string firstStrand, string secondStrand)
    {
        if (firstStrand.Length != secondStrand.Length)
        {
            throw new ArgumentException("The two strands must be of equal length.");
        }

        int distance = 0;
        for (int i = 0; i < firstStrand.Length; i++)
        {
            if (firstStrand[i] != secondStrand[i])
            {
                distance++;
            }
        }

        return distance;
    }
}