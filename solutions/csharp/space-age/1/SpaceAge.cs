using System;
using System.Collections.Generic;

public class SpaceAge
{
    private enum Planet
    {
        Earth,
        Mercury,
        Venus,
        Mars,
        Jupiter,
        Saturn,
        Uranus,
        Neptune
    }

    private readonly int _seconds;
    private readonly Dictionary<Planet, double> _earthYearToPlanetPeriod = new Dictionary<Planet, double>
    {
        [Planet.Earth] = 1,
        [Planet.Mercury] = 0.2408467,
        [Planet.Venus] = 0.61519726,
        [Planet.Mars] = 1.8808158,
        [Planet.Jupiter] = 11.862615,
        [Planet.Saturn] = 29.447498,
        [Planet.Uranus] = 84.016846,
        [Planet.Neptune] = 164.79132,
    };

    private const double EarthOrbitInSeconds = 31557600;

    public SpaceAge(int seconds)
    {
        _seconds = seconds;
    }

    private double CalculateAge(double periodInEarthYears)
    {
        return Math.Round(_seconds / (EarthOrbitInSeconds * periodInEarthYears), 2);
    }

    public double OnEarth() => CalculateAge(_earthYearToPlanetPeriod[Planet.Earth]);

    public double OnMercury() => CalculateAge(_earthYearToPlanetPeriod[Planet.Mercury]);

    public double OnVenus() => CalculateAge(_earthYearToPlanetPeriod[Planet.Venus]);

    public double OnMars() => CalculateAge(_earthYearToPlanetPeriod[Planet.Mars]);

    public double OnJupiter() => CalculateAge(_earthYearToPlanetPeriod[Planet.Jupiter]);

    public double OnSaturn() => CalculateAge(_earthYearToPlanetPeriod[Planet.Saturn]);

    public double OnUranus() => CalculateAge(_earthYearToPlanetPeriod[Planet.Uranus]);

    public double OnNeptune() => CalculateAge(_earthYearToPlanetPeriod[Planet.Neptune]);
}