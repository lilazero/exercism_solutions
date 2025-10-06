using System;

public static class PlayAnalyzer
{
    public static string AnalyzeOnField(int shirtNum)
    {
        return shirtNum switch
        {
            1 => "goalie",
            2 => "left back",
            3 or 4 => "center back",
            5 => "right back",
            6 or 7 or 8 => "midfielder",
            9 => "left wing",
            10 => "striker",
            11 => "right wing",
            _ => throw new ArgumentOutOfRangeException(nameof(shirtNum), "Unknown shirt number"),
        };
    }

    public static string AnalyzeOffField(object report)
    {
        return report switch
        {
            Foul => "The referee deemed a foul.",
            Injury i => $"Oh no! {i.GetDescription()} Medics are on the field.",
            Incident => "An incident happened.",
            Manager manager => string.IsNullOrWhiteSpace(manager.Club)
                    ? $"{manager.Name}"
                    : $"{manager.Name} ({manager.Club})",
            int attendance => $"There are {attendance.ToString()} supporters at the match.",
            string text => text,
            _ => throw new ArgumentException()
        };
    }

}