using System.Text.RegularExpressions;
public class Program
{
    public static bool ValidatePassword(string input)
    {
            if (input == null || input.Length < 6 || input.Length > 24)
                return false;
            
            if (!Regex.IsMatch(input, "[A-Z]"))
                return false;
​
            if (!Regex.IsMatch(input, "[a-z]"))
                return false;
​
            if (!Regex.IsMatch(input, "[0-9]"))
                return false;
​
            // more than 3 repeats of a char
            if (Regex.IsMatch(input, "(.)\\1{2}"))
                return false;
​
            // Check valid characters
            return Regex.IsMatch(input, "^[]a-zA-Z0-9!@#$%^&*()+=_{}[:;”’?<>,.-]+$");
    }
}
