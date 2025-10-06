using System;

/// <summary>
/// Represents a weighing machine that can measure weight with a given precision.
/// </summary>
class WeighingMachine
{
    private int _precision; // The precision of the weighing machine.
    private double _weight; // The current weight on the weighing machine.
    private double _tareAdjustment =5; // The tare adjustment value for the weighing machine.

    /// <summary>
    /// Initializes a new instance of the <see cref="WeighingMachine"/> class with the given precision.
    /// </summary>
    /// <param name="precision">The precision of the weighing machine.</param>
    public WeighingMachine(int precision)
    {
        this._precision = precision;
    }

    /// <summary>
    /// Gets or sets the precision of the weighing machine.
    /// </summary>
    public int Precision
    {
        get { return _precision; }
        set { _precision = value; }
    }

    /// <summary>
    /// Gets or sets the weight on the weighing machine.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the weight is negative.</exception>
    public double Weight
    {
        // Get the weight on the weighing machine.
        get { return _weight; }

        // Set the weight on the weighing machine.
        set
        {
            // Check if the weight is negative.
            if (value < 0)
            {
                // Throw an exception if the weight is negative.
                throw new ArgumentOutOfRangeException("Weight cannot be negative.");
            }
            else
            {
                // Set the weight on the weighing machine.
                _weight = value;
            }
        }
    }

    /// <summary>
    /// Gets the weight on the weighing machine after subtracting the tare adjustment value.
    /// </summary>
    public string DisplayWeight
    {
        get { return (_weight - _tareAdjustment).ToString("F" + _precision) + " kg"; }
    }

    /// <summary>
    /// Gets or sets the tare adjustment value for the weighing machine.
    /// </summary>
    public double TareAdjustment
    {
        get { return _tareAdjustment; }
        set { _tareAdjustment = value; }
    }
}
