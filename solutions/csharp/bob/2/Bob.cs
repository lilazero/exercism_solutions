public class Bob{ 
    public static string Response(string userInput) => userInput.TrimEnd().EndsWith("?") // Check if the user input ends with a question mark
        switch{
            true when userInput == userInput.ToUpper() && userInput != userInput.ToLower()=> "Calm down, I know what I'm doing!",// Check if the user input is in all uppercase(SCREAMING)
            true => "Sure.",  // Return "Sure." for all other question inputs(Just a regular question)
            false when userInput == userInput.ToUpper() && userInput != userInput.ToLower() => "Whoa, chill out!", // Check if the user input is in all uppercase and not all lowercase(Shouting)
            false when string.IsNullOrWhiteSpace(userInput) => "Fine. Be that way!", // Check if the user input is empty or only contains whitespace
            _ => "Whatever.", /* Return "Whatever." for all other inputs*/};}