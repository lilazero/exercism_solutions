using System;
/// <summary>
/// This class contains a method to get the display name of a team support member.
/// </summary>
public class SecurityPassMaker
{
    /// <summary>
    /// Returns the display name of a team support member.
    /// </summary>
    /// <param name="support">The team support member.</param>
    /// <returns>The display name of the team support member.</returns>
    public string GetDisplayName(TeamSupport support)
    {
        if (support is Manager)
        {
            return "Too Important for a Security Pass";
        }
        else if (support is Physio)
        {
            return "The Physio";
        }
        else if (support is Security)
        {
            if (support is SecurityJunior)
            {
                return "Security Junior";
            }
            else if (support is SecurityIntern)
            {
                return "Security Intern";
            }
            else if (support is PoliceLiaison)
            {
                return "Police Liaison Officer";
            }
            else
            {
                return "Security Team Member Priority Personnel";
            }
        }
        else
        {
            throw new NotImplementedException(
                $"Please implement the SecurityPassMaker.GetDisplayName() method for {support.GetType().Name}"
            );
        }
    }
}

/// <summary>
/// Represents a team support member.
/// </summary>
public interface TeamSupport
{
    /// <summary>
    /// The title of the team support member.
    /// </summary>
    string Title { get; }
}

/// <summary>
/// Represents a staff member.
/// </summary>
public abstract class Staff : TeamSupport
{
    /// <summary>
    /// The title of the staff member.
    /// </summary>
    public abstract string Title { get; }
}

/// <summary>
/// Represents a manager.
/// </summary>
public class Manager : TeamSupport
{
    /// <summary>
    /// The title of the manager.
    /// </summary>
    public string Title { get; } = "The Manager";
}

/// <summary>
/// Represents a chairman.
/// </summary>
public class Chairman : TeamSupport
{
    /// <summary>
    /// The title of the chairman.
    /// </summary>
    public string Title { get; } = "The Chairman";
}

/// <summary>
/// Represents a physio.
/// </summary>
public class Physio : Staff
{
    /// <summary>
    /// The title of the physio.
    /// </summary>
    public override string Title { get; } = "The Physio";
}

/// <summary>
/// Represents an offensive coach.
/// </summary>
public class OffensiveCoach : Staff
{
    /// <summary>
    /// The title of the offensive coach.
    /// </summary>
    public override string Title { get; } = "Offensive Coach";
}

/// <summary>
/// Represents a goal keeping coach.
/// </summary>
public class GoalKeepingCoach : Staff
{
    /// <summary>
    /// The title of the goal keeping coach.
    /// </summary>
    public override string Title { get; } = "Goal Keeping Coach";
}

/// <summary>
/// Represents a security team member.
/// </summary>
public class Security : Staff
{
    /// <summary>
    /// The title of the security team member.
    /// </summary>
    public override string Title { get; } = "Security Team Member";
}

/// <summary>
/// Represents a security junior.
/// </summary>
public class SecurityJunior : Security
{
    /// <summary>
    /// The title of the security junior.
    /// </summary>
    public override string Title { get; } = "Security Junior";
}

/// <summary>
/// Represents a security intern.
/// </summary>
public class SecurityIntern : Security
{
    /// <summary>
    /// The title of the security intern.
    /// </summary>
    public override string Title { get; } = "Security Intern";
}

/// <summary>
/// Represents a police liaison officer.
/// </summary>
public class PoliceLiaison : Security
{
    /// <summary>
    /// The title of the police liaison officer.
    /// </summary>
    public override string Title { get; } = "Police Liaison Officer";
}
