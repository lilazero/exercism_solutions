using System;
using System.Text.RegularExpressions;

public static class RunLengthEncoding {

  public static string Encode(string input) {
    return Regex.Replace(input, @"(\D)\1+", match => {
      int length = match.Length;
      char value = match.Value[0];
      return length.ToString() + value;
    });
  }

  public static string Decode(string input) {
    return Regex.Replace(input, @"(\d+)(\D)", match => {
      int length = Int32.Parse(match.Groups[1].Value);
      char value = match.Groups[2].Value[0];
      return new String(value, length);
    });
  }

}