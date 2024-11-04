
public class MorseCode
{
    public static void Run()
    {
Dictionary<char, string> morseCode = new Dictionary<char, string>()
        {
            { 'A', ".-" }, { 'B', "-..." }, { 'C', "-.-." }, { 'D', "-.." },
            { 'E', "." }, { 'F', "..-." }, { 'G', "--." }, { 'H', "...." },
            { 'I', ".." }, { 'J', ".---" }, { 'K', "-.-" }, { 'L', ".-.." },
            { 'M', "--" }, { 'N', "-." }, { 'O', "---" }, { 'P', ".--." },
            { 'Q', "--.-" }, { 'R', ".-." }, { 'S', "..." }, { 'T', "-" },
            { 'U', "..-" }, { 'V', "...-" }, { 'W', ".--" }, { 'X', "-..-" },
            { 'Y', "-.--" }, { 'Z', "--.." },
            { '1', ".----" }, { '2', "..---" }, { '3', "...--" }, { '4', "....-" },
            { '5', "....." }, { '6', "-...." }, { '7', "--..." }, { '8', "---.." },
            { '9', "----." }, { '0', "-----" },
        };
        string word = Console.ReadLine()!;
        
        
       
        foreach (char letter in word)
        {
            if (morseCode.ContainsKey(letter))
            {
                Console.Write(morseCode[letter] + " ");
            }
        }
    }
}
    