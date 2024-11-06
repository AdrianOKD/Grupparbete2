using Grupparbete2;
using Grupparbete2.Commands;
using Pussel.Commands;

namespace GreenRooms
{
    public class GreenRoom
    {
        private InventoryPlayer inventory;
        private List<Command> commands;

        public void GreenGame()
        {
            inventory = new InventoryPlayer();
            commands = new List<Command>
            {
                new HelpGreenCommand(),
                new InventoryCommand(inventory),
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

        public void Start()
        {
            Console.WriteLine("Enter 'help'  to view the commando.");
            bool stopgame = true;
            while (stopgame)
            {
                Console.Write("> ");
                string input = Console.ReadLine()!;
                ExecuteCommand(input);
                if (input.Equals("stop") || input.Equals("exit"))
                {
                    stopgame = false;
                }
                Console.ReadLine();
                
            }
        }

        public void Execute()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the green room...");
            Thread.Sleep(4000);
            Console.Clear();
            Console.WriteLine("This room is connected to an ominous oxygen-sucking machine.");
            Console.WriteLine("You must find a box and guess the code.");
            Thread.Sleep(3000);

            OpenBox();
            Console.Clear();
            Console.WriteLine("Time is of the essence-oxygen decreases by 10% every hour.");
            Console.WriteLine(
                "You have 3 hours and 6 trials before your oxygen levels reach a critical point."
            );
            Console.WriteLine("If you succeed, you will collect a green key.");
            Thread.Sleep(4000);
            GuessTheCode();
        }

        public static void OpenBox()
        {
            System.Console.WriteLine();
            System.Console.WriteLine(
                "Don´t wait around, get the ladder in the corner and climb the shelf-"
            );
            System.Console.WriteLine("in front of you and grab a box in your view. ");
            System.Console.WriteLine("That´s the box that contains the door key. ");
            while (true)
            {
                Thread.Sleep(2000);
                System.Console.WriteLine("Have you found the box yet? type yes/no");
                string answer = Console.ReadLine()!.ToLower();

                if (answer.Equals("yes"))
                {
                    System.Console.WriteLine("* Great");
                    break;
                }
                else if (answer.Equals("no"))
                {
                    System.Console.WriteLine("Keep looking, time is running out");
                }
            }
        }

        public void GuessTheCode()
        {
            System.Console.WriteLine("\nNow it´s time to guess the last 2 digits of the code");
            System.Console.WriteLine("Press X to get a hint or press any other key to ignore it.");
            string hint = Console.ReadLine()!.ToLower();
            if (hint.Equals("x"))
            {
                System.Console.WriteLine("Guess between 54 and 61");
            }
            else
            {
                System.Console.WriteLine("Okey, good luck");
            }

            while (true)
            {
                System.Console.Write("Enter 2 digits to crack the code: ");
                int numberInput;
                int GuessAmount = 6;
                Random slump = new Random();

                for (int i = GuessAmount - 1; i >= 0; i--)
                {
                    int randomNumber = slump.Next(54, 61);
                    numberInput = int.Parse(Console.ReadLine()!);
                    if (numberInput != randomNumber && i > 1)
                    {
                        System.Console.Write($"Wrong, you have {i} guesses left! try again: ");
                    }
                    if (i > 0 && i.Equals(1))
                    {
                        if (numberInput != randomNumber)
                        {
                            System.Console.WriteLine(
                                "Wrong, You feel light headed and oxygen is depletting"
                            );
                            System.Console.Write(
                                $"time is running out. \n One guess left! Enter 2 digits:  "
                            );
                        }
                    }

                    if (i.Equals(0))
                    {
                        if (numberInput != randomNumber)
                        {
                            System.Console.WriteLine();
                            System.Console.Write("Oxygen is too low, You are dead!");
                            System.Console.WriteLine();
                            return;
                        }
                    }

                    if (numberInput.Equals(randomNumber))
                    {
                        System.Console.WriteLine($"Congratulations! you have won the green key ");

                        //inventory.Pickup("greenkey");

                        System.Console.WriteLine();
                        return;
                    }
                }
            }
        }
    }
}
