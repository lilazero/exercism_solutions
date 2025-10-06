using System.Linq;
using System.Collections.Generic;

public static class Pangram
{
    public static bool IsPangram(string input) =>"abcdefghijklmnopqrstuvwxyz".All(input.ToLowerInvariant().Contains);
}
