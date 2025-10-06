using System.Collections.Generic;
using System.Linq;

public class DialingCodes
{
    public static Dictionary<int, string> GetEmptyDictionary() => new();

    public static Dictionary<int, string> GetPrePopulatedDictionary() => new()
    {
        { 1, "United States of America" },
        { 55, "Brazil" },
        { 91, "India" }
    };

    public static Dictionary<int, string> GetExistingDictionary() => GetPrePopulatedDictionary();

    public static Dictionary<int, string> AddCountryToEmptyDictionary(
        int countryCode,
        string countryName
    ) => new Dictionary<int, string> { { countryCode, countryName } };

    public static Dictionary<int, string> AddCountryToExistingDictionary(
        Dictionary<int, string> prePopulatedDictionary,
        int countryCode,
        string countryName
    )
    {
        if (!prePopulatedDictionary.ContainsKey(countryCode))
        {
            prePopulatedDictionary.Add(countryCode, countryName);
        }
        return prePopulatedDictionary;
    }

    public static string GetCountryNameFromDictionary(
        Dictionary<int, string> prePopulatedDictionary,
        int countryCode
    ) => prePopulatedDictionary.ContainsKey(countryCode) ? prePopulatedDictionary[countryCode] : "";

    public static bool CheckCodeExists(
        Dictionary<int, string> prePopulatedDictionary,
        int countryCode
    ) => prePopulatedDictionary.ContainsKey(countryCode);

    public static Dictionary<int, string> UpdateDictionary(Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        if (existingDictionary.ContainsKey(countryCode))
        {
            existingDictionary[countryCode] = countryName;
        }
        return existingDictionary;
    }

    public static Dictionary<int, string> RemoveCountryFromDictionary(
        Dictionary<int, string> prePopulatedDictionary,
        int countryCode
    )
    {
        prePopulatedDictionary.Remove(countryCode);
        return prePopulatedDictionary;
    }

    public static string FindLongestCountryName(Dictionary<int, string> prePopulatedDictionary) =>
        prePopulatedDictionary.Aggregate(
            string.Empty,
            (current, pair) => current.Length > pair.Value.Length ? current : pair.Value
        );
}
