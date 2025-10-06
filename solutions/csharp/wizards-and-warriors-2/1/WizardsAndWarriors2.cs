using System;

/// <summary>
/// The GameMaster class provides methods for describing characters, destinations, and travel methods.
/// </summary>
static class GameMaster
{
    /// <summary>
    /// Describes a character.
    /// </summary>
    /// <param name="character">The character to describe.</param>
    /// <returns>A string describing the character.</returns>
    public static string Describe(Character character) =>
        $"You're a level {character.Level} {character.Class} with {character.HitPoints} hit points.";

    /// <summary>
    /// Describes a destination.
    /// </summary>
    /// <param name="destination">The destination to describe.</param>
    /// <returns>A string describing the destination.</returns>
    public static string Describe(Destination destination) =>
        $"You've arrived at {destination.Name}, which has {destination.Inhabitants} inhabitants.";

    /// <summary>
    /// Describes a travel method.
    /// </summary>
    /// <param name="travelMethod">The travel method to describe.</param>
    /// <returns>A string describing the travel method.</returns>
    public static string Describe(TravelMethod travelMethod) =>
        travelMethod switch
        {
            TravelMethod.Horseback
                => $"You're traveling to your destination on {nameof(TravelMethod.Horseback).ToLower()}.",
            TravelMethod.Walking
                => $"You're traveling to your destination by {nameof(TravelMethod.Walking).ToLower()}.",
            _ => throw new NotImplementedException()
        };

    /// <summary>
    /// Describes a character, destination, and travel method.
    /// </summary>
    /// <param name="character">The character to describe.</param>
    /// <param name="destination">The destination to describe.</param>
    /// <param name="travelMethod">The travel method to describe.</param>
    /// <returns>A string describing the character, destination, and travel method.</returns>
    public static string Describe(
        Character character,
        Destination destination,
        TravelMethod travelMethod
    ) =>
        travelMethod switch
        {
            TravelMethod.Horseback
                => $"{Describe(character)} {Describe(travelMethod)} {Describe(destination)}",
            TravelMethod.Walking
                => $"{Describe(character)} {Describe(travelMethod)} {Describe(destination)}",
            _ => throw new NotImplementedException()
        };

    /// <summary>
    /// Describes a character and destination using the walking travel method.
    /// </summary>
    /// <param name="character">The character to describe.</param>
    /// <param name="destination">The destination to describe.</param>
    /// <returns>A string describing the character and destination using the walking travel method.</returns>
    public static string Describe(Character character, Destination destination) =>
        Describe(character, destination, TravelMethod.Walking);
}

/// <summary>
/// Represents a character in the game.
/// </summary>
class Character
{
    /// <summary>
    /// The class of the character.
    /// </summary>
    public string Class { get; set; }

    /// <summary>
    /// The level of the character.
    /// </summary>
    public int Level { get; set; }

    /// <summary>
    /// The hit points of the character.
    /// </summary>
    public int HitPoints { get; set; }
}

/// <summary>
/// Represents a destination in the game.
/// </summary>
class Destination
{
    /// <summary>
    /// The name of the destination.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The number of inhabitants at the destination.
    /// </summary>
    public int Inhabitants { get; set; }
}

/// <summary>
/// Represents a travel method in the game.
/// </summary>
enum TravelMethod
{
    /// <summary>
    /// The walking travel method.
    /// </summary>
    Walking,

    /// <summary>
    /// The horseback travel method.
    /// </summary>
    Horseback
}
