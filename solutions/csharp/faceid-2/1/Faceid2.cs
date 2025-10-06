using System;
using System.Collections.Generic;

public class FacialFeatures
{
    public string EyeColor { get; }
    public decimal PhiltrumWidth { get; }

    
    public FacialFeatures(string eyeColor, decimal philtrumWidth)
    {
        EyeColor = eyeColor;
        PhiltrumWidth = philtrumWidth;
    }

    public override bool Equals(object obj)
    {
        if (obj is not FacialFeatures other)
        {
            return false;
        }

        return EyeColor == other.EyeColor && PhiltrumWidth == other.PhiltrumWidth;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(EyeColor, PhiltrumWidth);
    }
}

public class Identity
{
    public string Email { get; }
    public FacialFeatures FacialFeatures { get; }

    public Identity(string email, FacialFeatures facialFeatures)
    {
        Email = email;
        FacialFeatures = facialFeatures;
    }

    public override bool Equals(object obj)
    {
        if (obj is not Identity other)
        {
            return false;
        }

        return Email == other.Email && FacialFeatures.Equals(other.FacialFeatures);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Email, FacialFeatures);
    }
}

public class Authenticator
{
    private readonly FacialFeatures admin = new("green", 0.9m);
    public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB)
    {
        return faceA.Equals(faceB);
    }
    public bool IsAdmin(Identity identity)
    {
        const string adminEmail = "admin@exerc.ism";

        return identity.Email == adminEmail
            && AreSameFace(identity.FacialFeatures, admin);
    }

    private List<Identity> registeredIdentities = new();

    public bool Register(Identity identity)
    {
        if (identity is null || IsRegistered(identity))
        {
            return false;
        }

        registeredIdentities.Add(identity);
        return true;
    }

    public bool IsRegistered(Identity identity)
    {
        return identity is not null && registeredIdentities.Contains(identity);
    }

    public static bool AreSameObject(Identity identityA, Identity identityB)
    {
        return !ReferenceEquals(identityA, null) && ReferenceEquals(identityA, identityB);
    }
}
