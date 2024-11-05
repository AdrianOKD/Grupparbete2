using Grupparbete2;
using Grupparbete2.Commands;
using Pussel.Commands;

namespace Pussel
{
    //Blir med och mer mad, drog från kropppen?
    //Playern börjar se att kroppen twitchar,
    //den börjar följa en med ögonen i rummet, mockar playern.
    public class Cryptogram
    {
        //private Player player;
        private InventoryPlayer inventory;
        private List<Command> commands;

        public Cryptogram()
        {
            //player = new Player();
            commands = new List<Command>
            {
                new ExamineOrangeCommand(),
                new InventoryCommand(inventory!),
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
                { 'A', 'Z' },
                { 'B', 'Y' },
                { 'C', 'X' },
                { 'D', 'W' },
                { 'E', 'V' },
                { 'F', 'U' },
                { 'G', 'T' },
                { 'H', 'S' },
                { 'I', 'R' },
                { 'J', 'Q' },
                { 'K', 'P' },
                { 'L', 'O' },
                { 'M', 'N' },
                { 'N', 'M' },
                { 'O', 'L' },
                { 'P', 'K' },
                { 'Q', 'J' },
                { 'R', 'I' },
                { 'S', 'H' },
                { 'T', 'G' },
                { 'U', 'F' },
                { 'V', 'E' },
                { 'W', 'D' },
                { 'X', 'C' },
                { 'Y', 'B' },
                { 'Z', 'A' },
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
                    System.Console.WriteLine(
                        $"Incorrect guess! You have {10 - count} guesses left."
                    );
                }
                if (count == 2)
                {
                    System.Console.WriteLine(
                        "You hear a thug sound, it sounds like it´s coming from within the walls. In the corner of your eye you see something moving. You look back over your shoulder, it just the corpse.. was it moving?"
                    );
                }

                if (count == 4)
                {
                    System.Console.WriteLine(
                        "The sounds keep getting louder, again you see something moving.. you look back, how? The corpse is sitting up, it's smashed face hanging. Is it looking at you? "
                    );
                }

                if (count == 5)
                {
                    System.Console.WriteLine(
                        "The corpse starts taunting you, 'you disgust me' 'think there's an end to this? There's no point in what your doing.'"
                    );
                    System.Console.WriteLine(
                        "The sounds ecoing in your head, it keeps getting louder..."
                    );
                }

                if (count == 6)
                {
                    System.Console.WriteLine(" ");
                }

                if (count == 8)
                {
                    System.Console.WriteLine("The corpse, keeps taunting, ");
                }

                if (count >= 10)
                {
                    System.Console.WriteLine(
                        "The sounds, THE MAN, it wont leave you alone, you start clawing at your ears, 'STOP!', but it wont stop it escalates, flimmers, you cant breath, it has to stop."
                    );
                    System.Console.WriteLine(
                        "You start smashing your head agains the ground, 'make it stop!'"
                    );
                    System.Console.WriteLine("Thunk.. Thunk.. ");
                    System.Console.WriteLine(
                        "The noice starts to dissepate, yes finally, THUNK THUNK"
                    );
                    System.Console.WriteLine(
                        " Just one more.. In your delierius state you smash your head one last time against the gronund. "
                    );
                    System.Console.WriteLine("It's finally over..");
                    puzzleLoop = false;
                    break;
                }

                string cryptoStr = new string(cryptoSentence);

                if (cryptoStr.ToUpper() == originalSentence.ToUpper())
                {
                    System.Console.WriteLine("x");
                    //orangeRoom.Success = true;
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
