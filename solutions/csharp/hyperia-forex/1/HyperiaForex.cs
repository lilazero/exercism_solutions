using System;

/// <summary>
/// Represents a currency amount with a specified amount and currency code.
/// </summary>
public struct CurrencyAmount
{
    private decimal amount;
    private string currency;

    /// <summary>
    /// Initializes a new instance of the CurrencyAmount struct with the specified amount and currency.
    /// </summary>
    /// <param name="amount">The amount of the currency.</param>
    /// <param name="currency">The currency code.</param>
    public CurrencyAmount(decimal amount, string currency)
    {
        this.amount = amount;
        this.currency = currency;
    }

 


    /// <summary>
    /// Determines whether two CurrencyAmount objects are equal.
    /// </summary>
    /// <param name="a">The first CurrencyAmount object to compare.</param>
    /// <param name="b">The second CurrencyAmount object to compare.</param>
    /// <returns>true if the two CurrencyAmount objects are equal; otherwise, false.</returns>
    public static bool operator ==(CurrencyAmount a, CurrencyAmount b)
    {
        if (a.currency != b.currency)
        {
            throw new ArgumentException();
        }

        return a.amount == b.amount;
    }

    /// <summary>
    /// Determines whether two CurrencyAmount objects are not equal.
    /// </summary>
    /// <param name="a">The first CurrencyAmount object to compare.</param>
    /// <param name="b">The second CurrencyAmount object to compare.</param>
    /// <returns>true if the two CurrencyAmount objects are not equal; otherwise, false.</returns>
    public static bool operator !=(CurrencyAmount a, CurrencyAmount b)
    {
        if (a.currency != b.currency)
        {
            throw new ArgumentException();
        }

        return a.amount != b.amount;
    }

    /// <summary>
    /// Determines whether one CurrencyAmount object is greater than another.
    /// </summary>
    /// <param name="a">The first CurrencyAmount object to compare.</param>
    /// <param name="b">The second CurrencyAmount object to compare.</param>
    /// <returns>true if the first CurrencyAmount object is greater than the second; otherwise, false.</returns>
    /// <exception cref="ArgumentException">Thrown when the currency codes do not match.</exception>
    public static bool operator >(CurrencyAmount a, CurrencyAmount b)
    {
        if (a.currency != b.currency)
        {
            throw new ArgumentException("Currency codes do not match.");
        }

        return a.amount > b.amount;
    }

    /// <summary>
    /// Determines whether one CurrencyAmount object is less than another.
    /// </summary>
    /// <param name="a">The first CurrencyAmount object to compare.</param>
    /// <param name="b">The second CurrencyAmount object to compare.</param>
    /// <returns>true if the first CurrencyAmount object is less than the second; otherwise, false.</returns>
    /// <exception cref="ArgumentException">Thrown when the currency codes do not match.</exception>
    public static bool operator <(CurrencyAmount a, CurrencyAmount b)
    {
        if (a.currency != b.currency)
        {
            throw new ArgumentException("Currency codes do not match.");
        }

        return a.amount < b.amount;
    }

    /// <summary>
    /// Adds two CurrencyAmount objects.
    /// </summary>
    /// <param name="a">The first CurrencyAmount object to add.</param>
    /// <param name="b">The second CurrencyAmount object to add.</param>
    /// <returns>A new CurrencyAmount object that represents the sum of the two CurrencyAmount objects.</returns>
    /// <exception cref="ArgumentException">Thrown when the currency codes do not match.</exception>
    public static CurrencyAmount operator +(CurrencyAmount a, CurrencyAmount b)
    {
        if (a.currency != b.currency)
        {
            throw new ArgumentException("Currency codes do not match.");
        }

        return new CurrencyAmount(a.amount + b.amount, a.currency);
    }

    /// <summary>
    /// Subtracts one CurrencyAmount object from another.
    /// </summary>
    /// <param name="a">The CurrencyAmount object to subtract from.</param>
    /// <param name="b">The CurrencyAmount object to subtract.</param>
    /// <returns>A new CurrencyAmount object that represents the difference between the two CurrencyAmount objects.</returns>
    /// <exception cref="ArgumentException">Thrown when the currency codes do not match.</exception>
    public static CurrencyAmount operator -(CurrencyAmount a, CurrencyAmount b)
    {
        if (a.currency != b.currency)
        {
            throw new ArgumentException("Currency codes do not match.");
        }

        return new CurrencyAmount(a.amount - b.amount, a.currency);
    }

    /// <summary>
    /// Multiplies a CurrencyAmount object by a decimal value.
    /// </summary>
    /// <param name="a">The CurrencyAmount object to multiply.</param>
    /// <param name="b">The decimal value to multiply by.</param>
    /// <returns>A new CurrencyAmount object that represents the result of the multiplication.</returns>
    public static CurrencyAmount operator *(CurrencyAmount a, decimal b)
    {
        return new CurrencyAmount(a.amount * b, a.currency);
    }

    /// <summary>
    /// Multiplies a decimal value by a CurrencyAmount object.
    /// </summary>
    /// <param name="b">The decimal value to multiply.</param>
    /// <param name="a">The CurrencyAmount object to multiply by.</param>
    /// <returns>A new CurrencyAmount object that represents the result of the multiplication.</returns>
    public static CurrencyAmount operator *(decimal b, CurrencyAmount a)
    {
        return new CurrencyAmount(a.amount * b, a.currency);
    }

    /// <summary>
    /// Divides a CurrencyAmount object by a decimal value.
    /// </summary>
    /// <param name="a">The CurrencyAmount object to divide.</param>
    /// <param name="b">The decimal value to divide by.</param>
    /// <returns>A new CurrencyAmount object that represents the result of the division.</returns>
    public static CurrencyAmount operator /(CurrencyAmount a, decimal b)
    {
        return new CurrencyAmount(a.amount / b, a.currency);
    }

    /// <summary>
    /// Converts a CurrencyAmount object to a double value.
    /// </summary>
    /// <param name="currencyAmount">The CurrencyAmount object to convert.</param>
    /// <returns>The double value that represents the CurrencyAmount object.</returns>
    public static explicit operator double(CurrencyAmount currencyAmount)
    {
        return (double)currencyAmount.amount;
    }

    /// <summary>
    /// Converts a CurrencyAmount object to a decimal value.
    /// </summary>
    /// <param name="currencyAmount">The CurrencyAmount object to convert.</param>
    /// <returns>The decimal value that represents the CurrencyAmount object.</returns>
    public static implicit operator decimal(CurrencyAmount currencyAmount)
    {
        return currencyAmount.amount;
    }
}