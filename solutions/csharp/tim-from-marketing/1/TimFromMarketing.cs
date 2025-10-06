static class Badge
{
    public static string Print(int? id, string name, string? department) => (id, name, department)
    switch
    {
        (null, _, null) => $"{name} - OWNER",
        (null, _, _) => $"{name} - {department?.ToUpper()}",
        (_, _, null) => $"[{id}] - {name} - OWNER",
        _ => $"[{id}] - {name} - {department?.ToUpper()}",
    };
}
