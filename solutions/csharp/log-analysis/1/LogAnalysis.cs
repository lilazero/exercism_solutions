using System;

public static class LogAnalysis
{
    public static string SubstringAfter(this string str, string delimiter) => str[(str.IndexOf(delimiter) + delimiter.Length)..];

    public static string SubstringBetween(this string str, string startDelimiter, string endDelimiter) => str.Substring(str.IndexOf(startDelimiter) + startDelimiter.Length, str.IndexOf(endDelimiter) - str.IndexOf(startDelimiter) - startDelimiter.Length);



    public static string Message(this string str) => str.SubstringAfter("]: ");

    public static string LogLevel(this string str) => str.SubstringBetween("[", "]: ");

}