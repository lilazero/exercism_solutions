using System;
using System.Linq;

public class Anagram
{
    private string subject;

    public Anagram(string subject) => this.subject = subject.ToLower();

    public string[] FindAnagrams(string[] candidates) =>
        candidates.Where(c => IsAnagram(c.ToLower(), subject)).ToArray();

    private bool IsAnagram(string a, string b) =>
        !a.Equals(b) && a.ToLower().OrderBy(c => c).SequenceEqual(b.ToLower().OrderBy(c => c));
}
