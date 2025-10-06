using System;
using System.Text.RegularExpressions;

public static class Acronym
{
    public static string Abbreviate(string inputPhrase)
    {
        string acronym = "";

        string[] splitWords = Regex.Split(inputPhrase, @"(-|'s|\b)");// Split on hyphens, apostrophes + s but keep em together as one word "'s", and word boundaries
        foreach (string word in splitWords)
        {
            if (string.IsNullOrWhiteSpace(word))
                continue;
            // Remove non-alphabet characters and 's so it does't get included in acronym
            string cleanedWord = Regex.Replace(word, "'s|[^A-Za-z]", "");
            // Take first character and uppercase
            if (cleanedWord.Length > 0)
            {
                acronym += char.ToUpper(cleanedWord[0]);
            }
        }
        return acronym;
    }
}