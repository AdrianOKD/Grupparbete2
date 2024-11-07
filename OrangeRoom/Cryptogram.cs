using Grupparbete2;
using Grupparbete2.Commands;
using Pussel.Commands;

namespace Pussel
{
   
    public class Cryptogram
    {
        private InventoryPlayer inventory;
        private List<Command> commands;

        public Cryptogram()
        {
            commands = new List<Command>
            {
                new ExamineOrangeCommand(),
                new InventoryCommand(inventory!),
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

        public void CryptoPuzzle()
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
            Console.WriteLine();

            int count = 0;
            int secretCount = 0;
            bool puzzleLoop = true;
            string str = new string(cryptoSentence);

            while (puzzleLoop)
            {
                Console.WriteLine(cryptoSentence);

                try
                {
                    string playerInput = Console.ReadLine()!;

                    char playerGuess = char.ToUpper(playerInput[0]);

                    bool isGuessCorrect = false;
                    for (int j = 0; j < cryptoSentence.Length; j++)
                    {
                        if (originalCryptoSentence[j].Equals(AtbashCipher[playerGuess]))
                        {
                            cryptoSentence[j] = playerGuess;
                            isGuessCorrect = true;
                        }
                    }

                    if (isGuessCorrect == false)
                    {
                        count++;
                        Console.WriteLine($"Incorrect guess! You have {10 - count} guesses left.");
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                    }
                    if (count == 2 && secretCount == 0)
                    {
                        secretCount++;
                        Console.WriteLine(
                            "You hear a sound, it sounds like it´s coming from within the walls. A sort of hissing.."
                        );
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                    }
                    if (count == 3 && secretCount == 1)
                    {
                        secretCount++;
                        Console.WriteLine(
                            " In the corner of your eye you see something moving. You look back over your shoulder, it just the corpse.. was it moving?"
                        );
                    }
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();

                    if (count == 4 && secretCount == 2)
                    {
                        secretCount++;
                        Console.WriteLine(
                            "The sounds keep getting louder, again you see something moving.. you look back, how? The corpse is sitting up, it's smashed face hanging. Is it looking at you? "
                        );
                           Console.WriteLine("Press any key to continue");
                            Console.ReadKey();
                    }

                    if (count == 5 && secretCount == 3)
                    {
                        secretCount++;
                        Console.WriteLine(
                            "The corpse starts taunting you, 'you disgust me' 'think there's an end to this? There's no point in what your doing.'"
                        );
                        Console.WriteLine(
                            "The sounds ecoing in your head, it keeps getting louder..."
                        );
                         Console.WriteLine("Press any key to continue");
                         Console.ReadKey();
                    }

                    if (count == 6 && secretCount == 4)
                    {
                        secretCount++;
                        Console.WriteLine("The sound escalate, the sound is defening");
                    }
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();

                    if (count == 8 && secretCount == 5)
                    {
                        secretCount++;
                        Console.WriteLine("The corpse, keeps taunting, ");
                    }
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();

                    if (count >= 10 && secretCount == 6)
                    {
                        secretCount++;
                        Console.WriteLine(
                            "The sounds, THE MAN, it wont leave you alone, you start clawing at your ears, 'STOP!', but it wont stop it escalates, flimmers, you cant breath, it has to stop."
                        );
                        Console.WriteLine(
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
                        Console.WriteLine(
                            $"{Colours.BOLD}{Colours.RED}GAME OVER{Colours.NOBOLD}{Colours.NORMAL}"
                        );
                        Console.ReadLine();
                        MainRoom.playerFailRoom = true;
                        OrangeRoom.orangeRoomChoice = false;
                        break;
                    }

                    string cryptoStr = new string(cryptoSentence);

                    if (cryptoStr.ToUpper() == originalSentence.ToUpper())
                    {
                        Console.WriteLine(cryptoSentence);
                        System.Console.WriteLine("You did it!");
                        System.Console.WriteLine(
                            "The sound and mocking dissapates.. you open the chest and find a key.\n"
                        );
                        System.Console.WriteLine("Press any to continue..");
                        Console.ReadLine();

                        MainRoom.hasOrangeKey = true;
                        OrangeRoom.orangeRoomChoice = false;

                        break;
                    }
                }
                catch
                {
                    System.Console.WriteLine("Use valid signs");
                }
            }
        }
    }
}


