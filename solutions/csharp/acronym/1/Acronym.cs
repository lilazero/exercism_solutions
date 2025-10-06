using System;
using System.Text.RegularExpressions;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        string acronym = "";
        string presplit = Regex.Replace(phrase, "'s", ""); //because otherwise ' and S would be different split words and be ignored by the cleanedWord below
        // Split on word boundaries and hyphens
        string[] words = Regex.Split(presplit, @"(-|\b)");
        foreach (string word in words)
        {
            if (string.IsNullOrWhiteSpace(word))
                continue;

            // Remove non-alphabet characters
            string cleanedWord = Regex.Replace(word, "[^A-Za-z]", "");

            // Take first character and uppercase
            if (cleanedWord.Length > 0)
            {
                acronym += char.ToUpper(cleanedWord[0]);
            }
        }
        return acronym;
    }
}