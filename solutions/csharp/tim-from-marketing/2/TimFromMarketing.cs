static class Badge
{
    // just to show the different coding styles, so unreadable JS devs will love it
    public static string Print(int? id, string name, string? department)
    {
        string departmentString = department?.ToUpper() ?? "OWNER";
        return id == null
            ? $"{name} - {departmentString}"
            : $"[{id}] - {name} - {departmentString}";
    }
}
