public class Bob
{
    public static string Response(string userInput)
    {
        // Check if the user input is empty or only contains whitespace
        if (string.IsNullOrWhiteSpace(userInput))
        {
            return "Fine. Be that way!";
        }

        // Check if the user input ends with a question mark
        return userInput.TrimEnd().EndsWith("?") switch
        {
            // Check if the user input is in all uppercase and not all lowercase
            true when userInput == userInput.ToUpper() && userInput != userInput.ToLower() => "Calm down, I know what I'm doing!",
            // Return "Sure." for all other question inputs
            true => "Sure.",
            // Check if the user input is in all uppercase and not all lowercase
            false when userInput == userInput.ToUpper() && userInput != userInput.ToLower() => "Whoa, chill out!",
            // Return "Whatever." for all other inputs
            _ => "Whatever.",
        };

    }
}
