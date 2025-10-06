using System.Collections.Generic;
using System.Linq;
public static class Languages
{
    private static readonly List<string> RepeatedLanguages = new(){"C#","Clojure","Elm"};
    public static List<string> NewList() => new();
    public static List<string> GetExistingLanguages() => RepeatedLanguages;
    public static List<string> AddLanguage(List<string> languages, string language) =>
        languages.Append(language).ToList();
    public static int CountLanguages(List<string> languages) => languages.Count;
    public static bool HasLanguage(List<string> languages, string language) =>
        languages.Contains(language);
    public static List<string> ReverseList(List<string> languages) =>
        languages.Reverse<string>().ToList();
    public static bool IsExciting(List<string> languages) => languages.Contains("C#") && languages.Count >= 1 && languages.Count <= 3;
    public static List<string> RemoveLanguage(List<string> languages, string language) =>
        languages.Where(x => x != language).ToList();
    public static bool IsUnique(List<string> languages) =>
        languages.Distinct().Count() == languages.Count;
}