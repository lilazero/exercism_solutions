using System;

/// <summary>
/// A class that provides methods for working with resistor colors.
/// </summary>
public class ResistorColor
{
    [Flags]
    private enum Color
    {
        black,
        brown,
        red,
        orange,
        yellow,
        green,
        blue,
        violet,
        grey,
        white
    }

    /// <summary>
    /// Returns the numeric value of the given color band.
    /// </summary>
    /// <param name="color">The color band to get the value of.</param>
    /// <returns>The numeric value of the color band.</returns>
    public static int ColorCode(string color) => (int)Enum.Parse(typeof(Color), color);

    /// <summary>
    /// Returns an array of all possible resistor colors.
    /// </summary>
    /// <returns>An array of all possible resistor colors.</returns>
    public static string[] Colors() => Enum.GetNames(typeof(Color));
}