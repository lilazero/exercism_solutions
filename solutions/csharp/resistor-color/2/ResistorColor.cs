using System;

/// <summary>
/// Provides methods for working with resistor color codes.
/// </summary>
public class ResistorColor
{
    /// <summary>
    /// An array of color codes for resistors.
    /// </summary>
    private static readonly string[] colorCodes = { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };

    /// <summary>
    /// Returns the numeric value of the given color code.
    /// </summary>
    /// <param name="color">The color code to look up.</param>
    /// <returns>The numeric value of the color code.</returns>
    public static int ColorCode(string color)
    {
        return Array.IndexOf(colorCodes, color);
    }

    /// <summary>
    /// Returns an array of all available color codes.
    /// </summary>
    /// <returns>An array of all available color codes.</returns>
    public static string[] Colors()
    {
        return colorCodes;
    }
}