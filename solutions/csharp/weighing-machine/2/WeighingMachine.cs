using System;

/// <summary>
/// Represents a weighing machine that can measure weight with a given precision.
/// </summary>
class WeighingMachine
{
    private double weight;


    /// <summary>
    /// Initializes a new instance of the <see cref="WeighingMachine"/> class with the given precision.
    /// </summary>
    /// <param name="precision">The precision of the weighing machine.</param>
    public WeighingMachine(int precision)
    {
        this.Precision = precision;
    }

    /// <summary>
    /// Gets or sets the precision of the weighing machine.
    /// </summary>
    public int Precision { get; private set; }

    /// <summary>
    /// Gets or sets the weight on the weighing machine.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the weight is negative.</exception>
    public double Weight
    {
        get => weight;
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(Weight), "Weight cannot be negative.");
            }

            weight = value;
        }
    }

    /// <summary>
    /// Gets the weight on the weighing machine after subtracting the tare adjustment value.
    /// </summary>
    public string DisplayWeight => $"{(Weight - TareAdjustment).ToString($"F{Precision}")} kg";

    /// <summary>
    /// Gets or sets the tare adjustment value for the weighing machine with a default of 5
    /// </summary>
    public double TareAdjustment { get; set; } = 5;
}
