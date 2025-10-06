using System;
using System.Linq;
using System.Text.RegularExpressions;

public static class Identifier
{
    public static string Clean(string InputString)
    {
        InputString = InputString.Replace(" ", "_"); //replace spaces with underscores

        InputString = InputString.Replace("\0", "CTRL");//replace '0' with 'CTRL'

        InputString = string.Join(
            "",
            InputString
                .Split('-')
                .Select(
                    (word, index) => index == 0 ? word : char.ToUpper(word[0]) + word.Substring(1)
                )
        );//to camelCase

        InputString = InputString.Replace("-", "");

        InputString = string.Join("", InputString.Where(c => !char.IsSurrogate(c))); // emoji remover

        InputString = new string(InputString.Where(c => !char.IsDigit(c)).ToArray()); //remove numbers

        InputString = new string(InputString.Where(c => !char.IsLower(c) || !(c >= '\u03B1' && c <= '\u03C9')).ToArray()); //remove lowercase greek


        return InputString;
    }


}
