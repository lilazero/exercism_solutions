using System;
using System.Text.RegularExpressions;


static partial class LogLine
{
    public static string Message(string logLine)
    {
        logLine = MyRegex().Replace(logLine, "");
        return logLine.Trim();
    }

    public static string LogLevel(string logLine) => logLine switch
    {
        var _ when logLine.Contains("INFO") => "info",
        var _ when logLine.Contains("WARNING") => "warning",
        var _ when logLine.Contains("ERROR") => "error",
        _ => "Info",
    };

    public static string Reformat(string logLine) => logLine switch
    {
        var _ when logLine.Contains("Segmentation") => "Segmentation fault (error)",
        var _ when logLine.Contains("Decreased") => "Decreased performance (warning)",
        var _ when logLine.Contains("Disk defragmented") => "Disk defragmented (info)",
        var _ when logLine.Contains("Corrupt") => "Corrupt disk (error)",
        _ => "Info",
    };

    [GeneratedRegex("\\[[A-Za-z]+\\]:")]
    private static partial Regex MyRegex();

}
