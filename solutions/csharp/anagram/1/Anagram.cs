using System;
using System.Linq;

public class Anagram
{
    private string _subject;
    
    public Anagram(string subject)
    {
        _subject = subject.ToLower();   
    }

    public string[] FindAnagrams(string[] candidates) 
    {
        return candidates
            .Where(c => IsAnagram(c.ToLower(), _subject))
            .ToArray();
    }

    private bool IsAnagram(string candidate, string subject)
    {
        if (candidate == subject) return false;
        
        var candidateLetters = candidate.ToCharArray();
        Array.Sort(candidateLetters);
        var subjectLetters = subject.ToCharArray();
        Array.Sort(subjectLetters);

        return new string(candidateLetters) == new string(subjectLetters);
    }
}