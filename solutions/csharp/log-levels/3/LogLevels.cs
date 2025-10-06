using System;
using System.Text.RegularExpressions;


static partial class LogLine
{
    static readonly string pattern = @"\[[A-Za-z]+\]:";
    public static string Message(string logLine) =>  Regex.Replace(logLine,pattern, "").Trim();

    public static string LogLevel(string logLine) => Regex.Replace(logLine,@"\[|\]: .+","").ToLower().Trim();

    public static string Reformat(string logLine) => $"{Message(logLine)} ({LogLevel(logLine)})";
    
};


