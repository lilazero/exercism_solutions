using System;
using System.Collections.Generic;

/// <summary>
/// Interface for remote control cars
/// </summary>
public interface IRemoteControlCar
{
    /// <summary>
    /// Distance travelled by the car
    /// </summary>
    int DistanceTravelled { get; }

    /// <summary>
    /// Drive the car
    /// </summary>
    void Drive();
}

/// <summary>
/// Production remote control car class that implements IRemoteControlCar and IComparable
/// </summary>
public class ProductionRemoteControlCar : IRemoteControlCar, IComparable<ProductionRemoteControlCar>
{
    /// <summary>
    /// Distance travelled by the car
    /// </summary>
    public int DistanceTravelled { get; private set; }

    /// <summary>
    /// Number of victories of the car
    /// </summary>
    public int NumberOfVictories { get; set; }

    /// <summary>
    /// Drive the car +10
    /// </summary>
    public void Drive()
    {
        DistanceTravelled += 10;
    }

    /// <summary>
    /// Compare the number of victories of two ProductionRemoteControlCar objects
    /// </summary>
    /// <param name="other">The ProductionRemoteControlCar object to compare to</param>
    /// <returns>The result of the comparison</returns>
    public int CompareTo(ProductionRemoteControlCar other)
    {
        return NumberOfVictories.CompareTo(other.NumberOfVictories);
    }
}

/// <summary>
/// Experimental remote control car class that implements IRemoteControlCar
/// </summary>
public class ExperimentalRemoteControlCar : IRemoteControlCar
{
    /// <summary>
    /// Distance travelled by the car
    /// </summary>
    public int DistanceTravelled { get; private set; }

    /// <summary>
    /// Drive the car +20
    /// </summary>
    public void Drive()
    {
        DistanceTravelled += 20;
    }
}

/// <summary>
/// Test track class that contains methods to race and rank remote control cars
/// </summary>
public static class TestTrack
{
    /// <summary>
    /// Drive the remote control car
    /// </summary>
    /// <param name="car">The remote control car to race</param>
    public static void Race(IRemoteControlCar car)
    {
        car.Drive();
    }

    /// <summary>
    /// Get a list of ProductionRemoteControlCar objects ranked by number of victories
    /// </summary>
    /// <param name="prc1">The first ProductionRemoteControlCar object</param>
    /// <param name="prc2">The second ProductionRemoteControlCar object</param>
    /// <returns>A list of ProductionRemoteControlCar objects ranked by number of victories</returns>
    public static List<ProductionRemoteControlCar> GetRankedCars(ProductionRemoteControlCar prc1,
        ProductionRemoteControlCar prc2)
    {
        var cars = new List<ProductionRemoteControlCar> { prc1, prc2 };
        cars.Sort((x, y) => x.NumberOfVictories.CompareTo(y.NumberOfVictories));
        return cars;
    }
}
