using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Pussel;
using Pussel.Commands;

namespace Pussel
{
    public class Cryptogram
    {
        private Player player;
        private List<Command> commands;

        public Cryptogram()
        {
            //player = new Player();
            commands = new List<Command>
            {
                new ExamineOrangeCommand(),
                new InventoryCommand(player),
                //new PickupCommand(player),
            };
        }

       
        private void ExecuteCommand(string input)
        {
            string[] parts = input.Split(' ', 2);
            string commandName = parts[0].ToLower();

            foreach (var command in commands)
            {
                if (command.Name == commandName)
                {
                    command.Execute(parts.Length > 1 ? parts[1] : "");
                    return;
                }
            }
        }

        //Gör en bok som innehåller letråd till pusslet, tex. en av orden i meningen för att kunna lista ut hur pusslet fungerar, om det faktiska order är Hello my friends! så kan boken innehålla: ______ my _____!





        public void CryptoPussle()
        {
            
            
             Dictionary<char, char> AtbashCipher = new Dictionary<char, char>()
             {
                 { 'A', 'Z' }, { 'B', 'Y' }, { 'C', 'X' }, { 'D', 'W' },
                 { 'E', 'V' }, { 'F', 'U' }, { 'G', 'T' }, { 'H', 'S' },
                 { 'I', 'R' }, { 'J', 'Q' }, { 'K', 'P' }, { 'L', 'O' },
                 { 'M', 'N' }, { 'N', 'M' }, { 'O', 'L' }, { 'P', 'K' },
                 { 'Q', 'J' }, { 'R', 'I' }, { 'S', 'H' }, { 'T', 'G' },
                 { 'U', 'F' }, { 'V', 'E' }, { 'W', 'D' }, { 'X', 'C' },
                 { 'Y', 'B' }, { 'Z', 'A' },
                 { 'a', 'z' }, { 'b', 'y' }, { 'c', 'x' }, { 'd', 'w' },
                 { 'e', 'v' }, { 'f', 'u' }, { 'g', 't' }, { 'h', 's' },
                 { 'i', 'r' }, { 'j', 'q' }, { 'k', 'p' }, { 'l', 'o' },
                 { 'm', 'n' }, { 'n', 'm' }, { 'o', 'l' }, { 'p', 'k' },
                 { 'q', 'j' }, { 'r', 'i' }, { 's', 'h' }, { 't', 'g' },
                 { 'u', 'f' }, { 'v', 'e' }, { 'w', 'd' }, { 'x', 'c' },
                 { 'y', 'b' }, { 'z', 'a' },
             };
               
            string originalSentence = "Hello my friends!";

            char[] originalCryptoSentence = new char[originalSentence.Length];
            char[] cryptoSentence = new char[originalSentence.Length];

            int i = 0;

            foreach (char c in originalSentence)
            {
                if (char.IsLetter(c))
                {
                    char makeUpperChar = char.ToUpper(c);
                    if (AtbashCipher.ContainsKey(makeUpperChar))
                    {
                        cryptoSentence[i] = AtbashCipher[makeUpperChar];

                        originalCryptoSentence[i] = cryptoSentence[i];
                    }
                    else
                    {
                        cryptoSentence[i] = c;

                        originalCryptoSentence[i] = c;
                    }
                }
                else
                {
                    cryptoSentence[i] = c;
                }

                i++;
            }
            Console.WriteLine(
                "The scrambled letters seem to form some kind of sentence, but what?"
            );
            System.Console.WriteLine();

            int count = 0;
            bool puzzleLoop = true;
            string str = new string(cryptoSentence);
            System.Console.WriteLine(str);

            while (puzzleLoop)
            {
                 
                     Console.WriteLine(cryptoSentence);
                 
      
                string playerInput = Console.ReadLine()!;
                System.Console.WriteLine(count);
                char playerGuess = char.ToUpper(playerInput[0]);
                bool isGuessCorrect = false;
                for (int j = 0; j < cryptoSentence.Length; j++)
                {
                    if (originalCryptoSentence[j].Equals(AtbashCipher[playerGuess]))
                    {
                        cryptoSentence[j] = playerGuess;
                        Console.WriteLine(cryptoSentence);
                        isGuessCorrect = true;
                    }
                  
                }
                  if (isGuessCorrect == false)
                    {
                        count++;
                        System.Console.WriteLine(count);
                    }

                    if (count >= 10)
                    {
                        System.Console.WriteLine("You succumb to the *thing* ");
                        puzzleLoop = false;
                        break;
                    }
                    
               
        
        
        else
        {
            count++;
            System.Console.WriteLine($"Incorrect guess! You have {10 - count} guesses left.");
        }
                string cryptoStr = new string(cryptoSentence);

                if (cryptoStr.ToUpper() == originalSentence.ToUpper())
                {
                    System.Console.WriteLine("Congrats!");
                    puzzleLoop = false;
                    break;
                }
                 
            }
           
           

          

            
        }
       
    }
}


//När counten är noll visa det riktiga ordet.
//Gör en count
//Gör så att man kan gissa hela ordet.
