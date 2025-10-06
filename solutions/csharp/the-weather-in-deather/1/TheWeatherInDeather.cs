using System;
using System.Collections.Generic;

public class WeatherStation
{
    private Reading reading;
    private List<DateTime> recordDates = new();
    private List<decimal> temperatures = new();

    /// <summary>
    /// Accepts a new temperature reading and adds it to the record.
    /// </summary>
    /// <param name="reading">The temperature reading to add.</param>
    public void AcceptReading(Reading reading)
    {
        this.reading = reading;
        recordDates.Add(DateTime.Now);
        temperatures.Add(reading.Temperature);
    }

    /// <summary>
    /// Clears all recorded data by resetting the reading object, record dates, and temperatures.
    /// </summary>
    public void ClearAll()
    {
        reading = new Reading();
        recordDates.Clear();
        temperatures.Clear();
    }

    /// <summary>
    /// Gets the latest temperature reading.
    /// </summary>
    public decimal LatestTemperature => reading.Temperature;

    /// <summary>
    /// Gets the latest pressure reading.
    /// </summary>
    public decimal LatestPressure => reading.Pressure;

    /// <summary>
    /// Gets the latest rainfall reading.
    /// </summary>
    public decimal LatestRainfall => reading.Rainfall;

    /// <summary>
    /// Gets a value indicating whether the weather station has historical records.
    /// </summary>
    public bool HasHistory => recordDates.Count > 1;

    /// <summary>
    /// Determines the short-term outlook based on the current weather reading.
    /// </summary>
    /// <returns>The short-term outlook based on the current weather reading.</returns>
    public Outlook ShortTermOutlook
    {
        get
        {
            if (reading.Equals(new Reading()))
            {
                throw new ArgumentException();
            }
            else
            {
                switch (reading.Pressure)
                {
                    case < 10m when reading.Temperature < 30m:
                        return Outlook.Cool;
                    default:
                        if (reading.Temperature > 50)
                        {
                            return Outlook.Good;
                        }
                        else
                        {
                            return Outlook.Warm;
                        }

                }
            }
        }
    }

    public Outlook LongTermOutlook
    {
        get
        {
            switch (reading.WindDirection)
            {
                case WindDirection.Southerly:
                case WindDirection.Easterly when reading.Temperature > 20:
                    return Outlook.Good;
                case WindDirection.Northerly:
                    return Outlook.Cool;
                case WindDirection.Easterly when reading.Temperature <= 20:
                    return Outlook.Warm;
                case WindDirection.Westerly:
                    return Outlook.Rainy;
                default:
                    throw new ArgumentException();
            }
        }
    }

    public State RunSelfTest => reading.Equals(new Reading()) ? State.Bad : State.Good;

}

/*** Please do not modify this struct ***/
public struct Reading
{
    public decimal Temperature { get; }
    public decimal Pressure { get; }
    public decimal Rainfall { get; }
    public WindDirection WindDirection { get; }

    public Reading(decimal temperature, decimal pressure,
        decimal rainfall, WindDirection windDirection)
    {
        Temperature = temperature;
        Pressure = pressure;
        Rainfall = rainfall;
        WindDirection = windDirection;
    }
}

/*** Please do not modify this enum ***/
public enum State
{
    Good,
    Bad
}

/*** Please do not modify this enum ***/
public enum Outlook
{
    Cool,
    Rainy,
    Warm,
    Good
}

/*** Please do not modify this enum ***/
public enum WindDirection
{
    Unknown, // default
    Northerly,
    Easterly,
    Southerly,
    Westerly
}
