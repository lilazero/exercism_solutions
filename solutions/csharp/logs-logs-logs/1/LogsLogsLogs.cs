/// <summary>
/// Represents the level of severity of a log message.
/// </summary>
public enum LogLevel

{
    Unknown,
    Trace,
    Debug,
    Info,
    Warning,
    Error,
    Fatal
}

/// <summary>
/// Provides methods for parsing and formatting log lines.
/// </summary>
public static class LogLine
{
    /// <summary>
    /// Parses a log line and returns the corresponding LogLevel.
    /// </summary>
    /// <param name="logLine">The log line to parse.</param>
    /// <returns>The LogLevel corresponding to the log line.</returns>
    public static LogLevel ParseLogLevel(string logLine)
    {
        if (logLine.StartsWith("[TRC]")) return LogLevel.Trace;
        if (logLine.StartsWith("[DBG]")) return LogLevel.Debug;
        if (logLine.StartsWith("[INF]")) return LogLevel.Info;
        if (logLine.StartsWith("[WRN]")) return LogLevel.Warning;
        if (logLine.StartsWith("[ERR]")) return LogLevel.Error;
        if (logLine.StartsWith("[FTL]")) return LogLevel.Fatal;
        return LogLevel.Unknown;
    }

    /// <summary>
    /// Returns a short log message with the specified log level and message.
    /// </summary>
    /// <param name="level">The log level.</param>
    /// <param name="message">The log message.</param>
    /// <returns>A short log message with the specified log level and message.</returns>
    public static string OutputForShortLog(LogLevel level, string message)
    {
        switch (level)
        {
            case LogLevel.Unknown:
                return "0:" + message;
            case LogLevel.Trace:
                return "1:" + message;
            case LogLevel.Debug:
                return "2:" + message;
            case LogLevel.Info:
                return "4:" + message;
            case LogLevel.Warning:
                return "5:" + message;
            case LogLevel.Error:
                return "6:" + message;
            case LogLevel.Fatal:
                return "42:" + message;
            default:
                return "0:" + message;
        }
    }
}