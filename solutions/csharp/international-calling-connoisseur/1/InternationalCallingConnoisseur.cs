using System.Collections.Generic;
using System.Linq; // the ugliest piece of shit i've ever written.
public class DialingCodes{
    public static Dictionary<int, string> GetEmptyDictionary() => new();
    public static Dictionary<int, string> GetPrePopulatedDictionary() => new() { { 1, "United States of America" }, { 55, "Brazil" }, { 91, "India" } };
    public static Dictionary<int, string> GetExistingDictionary() => GetPrePopulatedDictionary();
    public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName) => new Dictionary<int, string> { { countryCode, countryName } };
    public static Dictionary<int, string> AddCountryToExistingDictionary(Dictionary<int, string> prePopulatedDictionary, int countryCode, string countryName) =>prePopulatedDictionary.ContainsKey(countryCode) ? prePopulatedDictionary : prePopulatedDictionary.Append(new KeyValuePair<int, string>(countryCode, countryName)).ToDictionary(x => x.Key, x => x.Value);
    public static string GetCountryNameFromDictionary(Dictionary<int, string> prePopulatedDictionary,int countryCode) => prePopulatedDictionary.ContainsKey(countryCode) ? prePopulatedDictionary[countryCode] : "";
    public static bool CheckCodeExists(Dictionary<int, string> prePopulatedDictionary,int countryCode) => prePopulatedDictionary.ContainsKey(countryCode);
    public static Dictionary<int, string> UpdateDictionary(Dictionary<int, string> existingDictionary,int countryCode, string countryName) =>existingDictionary.ContainsKey(countryCode) ? existingDictionary.Select(x => x.Key == countryCode ? new KeyValuePair<int, string>(countryCode, countryName) : x).ToDictionary(x => x.Key, x => x.Value) : existingDictionary;
    public static Dictionary<int, string> RemoveCountryFromDictionary(Dictionary<int, string> prePopulatedDictionary,int countryCode) => prePopulatedDictionary.Where(x => x.Key != countryCode).ToDictionary(x => x.Key, x => x.Value);
    public static string FindLongestCountryName(Dictionary<int, string> prePopulatedDictionary) =>prePopulatedDictionary.Aggregate(string.Empty,(current, pair) => current.Length > pair.Value.Length ? current : pair.Value);}