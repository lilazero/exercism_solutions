using System;

/// <summary>
/// The types of accounts that can be created.
/// </summary>
enum AccountType
{
    /// <summary>
    /// A guest account.
    /// <para> Guests can read but not write or delete.</para>
    /// </summary>
    Guest,
    /// <summary>
    /// A user account.
    /// <para> Users can read and write but not delete.</para>
    /// </summary>
    User,
    /// <summary>
    /// A moderator account.
    /// <para> Moderators can read, write, and delete.</para>
    /// </summary>
    Moderator,
    /// <summary>
    /// An unknown account type.
    /// </summary>
    Unknown
}

/// <summary>
/// The permissions that can be granted to an account.
/// </summary>
[Flags]
enum Permission
{
    None = 0,
    Read = 1,
    Write = 2,
    Delete = 4,
    All = Read | Write | Delete
}

/// <summary>
/// A static class that provides methods for working with permissions.
/// </summary>
static class Permissions
{
    /// <summary>
    /// Gets the default permissions for the specified account type.
    /// </summary>
    /// <param name="accountType">The type of account to get the default permissions for.</param>
    /// <returns>The default permissions for the specified account type.</returns>
    public static Permission Default(AccountType accountType)
    {
        switch (accountType)
        {
            case AccountType.Guest:
                return Permission.Read;
            case AccountType.User:
                return Permission.Read | Permission.Write;
            case AccountType.Moderator:
                return Permission.Read | Permission.Write | Permission.Delete;
            default:
                return Permission.None;
        }
    }

    /// <summary>
    /// Grants the specified permissions to the current permissions.
    /// </summary>
    /// <param name="current">The current permissions.</param>
    /// <param name="grant">The permissions to grant.</param>
    /// <returns>The updated permissions.</returns>
    public static Permission Grant(Permission current, Permission grant)
    {
        return current | grant;
    }

    /// <summary>
    /// Revokes the specified permissions from the current permissions.
    /// </summary>
    /// <param name="current">The current permissions.</param>
    /// <param name="revoke">The permissions to revoke.</param>
    /// <returns>The updated permissions.</returns>
    public static Permission Revoke(Permission current, Permission revoke)
    {
        return current & ~revoke;
    }

    /// <summary>
    /// Checks if the current permissions contain the specified permissions.
    /// </summary>
    /// <param name="current">The current permissions.</param>
    /// <param name="check">The permissions to check for.</param>
    /// <returns>True if the current permissions contain the specified permissions, false otherwise.</returns>
    public static bool Check(Permission current, Permission check)
    {
        return (current & check) == check;
    }
} /* I'm reading Clean Code */
