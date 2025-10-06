using System.Text;

public static class RotationalCipher
{
    public static string Rotate(string text, int key)
    {
        StringBuilder result = new StringBuilder(); // Initialize a StringBuilder to store the result

        foreach (char character in text)
        {
            if (char.IsLetter(character))
            {
                char rotatedChar = RotateCharacter(character, key); // Rotate the character
                result.Append(rotatedChar); // Append the rotated character to the result
            }
            else
            {
                result.Append(character); // Append non-letter characters as is
            }
        }

        return result.ToString(); // Return the final result string
    }

    private static char RotateCharacter(char character, int key)
    {
        char offset = char.IsUpper(character) ? 'A' : 'a'; // Determine the offset based on the character's case
        int rotatedPos = (character - offset + key) % 26; // Calculate the rotated position of the character
        return (char)(offset + rotatedPos); // Return the rotated character
    }
}
