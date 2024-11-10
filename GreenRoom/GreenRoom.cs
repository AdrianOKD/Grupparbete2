using Grupparbete2;
using Grupparbete2.Commands;
using Pussel.Commands;

namespace GreenRooms
{
    public class GreenRoom
    {
        private List<Command> commands = new List<Command>();
        static bool stopgame = true;
        MainRoom mainRoom = new MainRoom();

        public void GreenGame()
        {
            commands = new List<Command>
            {
                new StartGreenPussleCommand(),
                new HelpGreenCommand(),
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
            GreenGame();
            Console.WriteLine("Enter 'help' to view the commando.");
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
            Console.WriteLine($"Welcome to {Colours.GREEN}the green room{Colours.NORMAL}...");
            Thread.Sleep(4000);
            Console.Clear();
            Console.WriteLine("This room is connected to an ominous oxygen-sucking machine.");
            Console.WriteLine("You must find a box and guess the code.");
            Thread.Sleep(3000);

            OpenBox();
            Console.Clear();
            Console.WriteLine($"Time is of the essence-oxygen decreases by{Colours.RED} 10%{Colours.NORMAL} every hour.");
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
                    System.Console.WriteLine($"{Colours.RED}Keep looking, time is running out{Colours.NORMAL}");
                }
            }
        }

        public void GuessTheCode()
        {
            System.Console.WriteLine($"\n Now it´s time to guess the last 2 digits of the code");
            System.Console.WriteLine($"Press {Colours.GREEN} X {Colours.NORMAL}  to get a hint or press any other key to ignore it.");
            string hint = Console.ReadLine()!.ToLower();
            if (hint.Equals("x"))
            {
                System.Console.WriteLine("Guess between 54 and 61");
            }
            else
            {
                System.Console.WriteLine("Okey, good luck");
            }
            try

            {
                while (true)
                {
                    int myNum;
                    System.Console.Write("Enter 2 digits to crack the code: ");
                    int numberInput;

                    int GuessAmount = 6;
                    Random slump = new Random();

                    for (int i = GuessAmount - 1; i >= 0; i--)
                    {
                        myNum = 1;

                        int randomNumber = slump.Next(54, 61);
                        numberInput = int.Parse(Console.ReadLine()!);
                        if (numberInput != randomNumber && i > 1)
                        {
                            System.Console.Write($"Wrong, you have {Colours.GREEN}{i}{Colours.NORMAL} guesses left! try again: ");
                        }
                        if (i > 0 && i.Equals(1))
                        {
                            if (numberInput != randomNumber)
                            {
                                System.Console.WriteLine(
                                    $"{Colours.CYAN}Wrong, You feel light headed and oxygen is depletting{Colours.NORMAL}"
                                );
                                System.Console.Write(
                                    $"time is running out. \n {Colours.GREEN}One{Colours.NORMAL} guess left! Enter 2 digits:  "
                                );
                            }
                        }

                        if (i.Equals(0))
                        {
                            if (numberInput != randomNumber)
                            {
                                System.Console.WriteLine();
                                System.Console.Write($"{Colours.RED}Oxygen is too low, You are dead!{Colours.NORMAL}");
                                System.Console.WriteLine();
                                stopgame = false;
                                MainRoom.playerFailRoom = true;
                                return;

                            }
                        }

                        if (numberInput.Equals(randomNumber) || numberInput.Equals(myNum))
                        {
                            System.Console.WriteLine($"{Colours.GREEN}Congratulations!{Colours.NORMAL} you have won the {Colours.GREEN} green key ");
                            MainRoom.hasGreenKey = true;
                            Thread.Sleep(4000);
                            System.Console.WriteLine($"{Colours.NORMAL}");
                            
                            mainRoom.MainRoomStart();
                            System.Console.WriteLine();

                        }
                    }
                }
            }
            catch
            {
                System.Console.WriteLine($"{Colours.RED} Invalid input {Colours.NORMAL}. Type 'help' to restart the greenroom");
            }
        }
    }
}
