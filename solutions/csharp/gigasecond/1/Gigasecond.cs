using System;

/// <summary>
/// Represents a gigasecond (10^9 seconds).
/// </summary>
public static class Gigasecond
{
    /// <summary>
    /// Adds a gigasecond to the specified date and time.
    /// </summary>
    /// <param name="date">The date and time to add a gigasecond to.</param>
    /// <returns>The resulting date and time.</returns>
    public static DateTime Add(DateTime date)
    {
        const long gigasecond = 1_000_000_000;
        return date.AddSeconds(gigasecond);
    }
}
