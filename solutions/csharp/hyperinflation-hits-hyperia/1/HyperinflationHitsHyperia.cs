using System;

/// <summary>
/// Provides methods for displaying monetary values and salaries after hyperinflation.
/// </summary>
public static class CentralBank
{
    /// <summary>
    /// Displays the denomination of a monetary value.
    /// </summary>
    /// <param name="base">The base value of the money.</param>
    /// <param name="multiplier">The multiplier value.</param>
    /// <returns>The new denomination of the monetary value.</returns>
    public static string DisplayDenomination(long @base, long multiplier)
    {
        if (@base > long.MaxValue / multiplier)
        {
            return "*** Too Big ***";
        }
        else
        {
            return $"{@base * multiplier}";
        }
    }

    /// <summary>
    /// Displays the GDP (Gross Domestic Product) of a country.
    /// </summary>
    /// <param name="base">The base value.</param>
    /// <param name="multiplier">The multiplier value.</param>
    /// <returns>The GDP of the country.</returns>
    public static string DisplayGDP(float @base, float multiplier)
    {
        if (@base > float.MaxValue / multiplier)
        {
            return "*** Too Big ***";
        }
        else
        {
            return $"{@base * multiplier}";
        }
    }

    /// <summary>
    /// Displays the salary of a chief economist.
    /// </summary>
    /// <param name="salaryBase">The base salary.</param>
    /// <param name="multiplier">The multiplier value.</param>
    /// <returns>The salary of the chief economist.</returns>
    public static string DisplayChiefEconomistSalary(decimal salaryBase, decimal multiplier)
    {
        if (salaryBase > decimal.MaxValue / multiplier)
        {
            return "*** Much Too Big ***";
        }
        else
        {
            return $"{salaryBase * multiplier}";
        }
    }
}
