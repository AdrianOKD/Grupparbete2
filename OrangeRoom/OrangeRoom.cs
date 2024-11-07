using Grupparbete2;
using Grupparbete2.Commands;
using Pussel.Commands;

namespace Pussel
{
    public class OrangeRoom
    {
        private InventoryPlayer inventory;
        private List<Command> commands;
        static bool wall = false;
        static bool chest = false;
        static bool lookAround = false;
        static bool hasNote = false;
        static bool annoyance = false;
        static int hints = 0;
        public static bool orangeRoomChoice = true;


        public void ClearTerminal()
        {
            Console.Clear();
            System.Console.WriteLine("\n\n");
        }

        public OrangeRoom()
        {
            inventory = new InventoryPlayer();
            commands = new List<Command>
            {
                new HelpOrangeCommand(),
                new LookOrangeCommand(),
                new ExamineOrangeCommand(),
                new InventoryCommand(inventory),
                new PickupCommand(inventory, this),
                new StartOrangePuzzleCommand(),
                new UseOrangeCommand(inventory),
                new HintOrangeCommand(),
            };
        }

        private void ExecuteCommand(string input)
        {
            if (input.Equals(null))
            {
                System.Console.WriteLine("Please write a new command");
                return;
            }
            string[] parts = input.Split(' ', 2);
            string commandName = parts[0].ToLower();

            foreach (var command in commands)
            {
                if (command.Name == commandName)
                {
                    command.Execute(parts.Length > 1 ? parts[1].ToLower() : "");
                    return;
                }
            }
        }

        public void OrangeRoomGame()
        {
            ClearTerminal();
            System.Console.WriteLine(
                $"As you step into the dimly lit room, the heavy wooden door slams shut behind you, the sound echoing through the cold, damp air.\n "
            );
            //Thread.Sleep(4000);
            Console.WriteLine(
                "The only light comes from a faint, flickering glow emanating from the walls, casting eerie shadows on the stone floor.\n"
            );
            //Thread.Sleep(4000);
            System.Console.WriteLine(
                $"{Colours.GREY}Ah, Nice choice of room meatbag..take a {Colours.BLUE}look around{Colours.NORMAL} {Colours.GREY}and maybe you´ll find a way out..{Colours.NORMAL}\n "
            );
            //Thread.Sleep(4000);
            System.Console.WriteLine();
            System.Console.WriteLine($"System: What would you like to do? for options write Help\n");
            //Thread.Sleep(4000);



            while (orangeRoomChoice)
            {   
                Console.Write("> ");
                string input = Console.ReadLine()!;
                ExecuteCommand(input);
                if (input.Equals("stop"))
                {
                    orangeRoomChoice = false;
                    System.Console.WriteLine("You are exiting the game..");
                }
                
            }
        }

        public void Hint()
        {
           
             System.Console.WriteLine("You ask for Hint\n");
            
            
            if (annoyance && hints < 3)
            {ClearTerminal();
                System.Console.WriteLine($"{Colours.GREY}{Colours.BOLD}ENOUGH! EITHER YOU FIGURE THIS OUT OR STAY HERE AND ROT..{Colours.NOBOLD}*Sigh* I´ve given you all you need to figure this out. I´ll leave you to do what you will..{Colours.NORMAL}");
                hints ++;
                
            }
            if (annoyance && hints == 3)
            {ClearTerminal();
                System.Console.WriteLine("You ask for a hint but get no response.. Guess they really left..");
                hints ++;
                annoyance = false;

            }
            if (!annoyance && hints > 3)
            {ClearTerminal();
                System.Console.WriteLine("No response..");

            }
            if (!lookAround && hints <=1)
            {ClearTerminal();
                System.Console.WriteLine(
                    $"{Colours.GREY}Use your eyes meatbag.. {Colours.BOLD}{Colours.BLUE}Look Around!{Colours.NOBOLD}{Colours.NORMAL}\n"
                ); 
            }
            if (lookAround && hints <= 2)
            {ClearTerminal();
                System.Console.WriteLine(
                    $"{Colours.GREY}Why are you asking for hints? You´ve looked around the room, if you dont know what to do look closer,{Colours.RED}examine{Colours.NORMAL} , anything really.. \n a toddler could do a better job than you.. {Colours.NORMAL}\n"
                ); annoyance = true;
                lookAround = false;
                hints ++;
            }
            
            
        }

        //Skriv Look Around
        public void LookAround()
        {
            ClearTerminal();

            System.Console.WriteLine("You look around the room\n");
            System.Console.WriteLine(
                $"To your left, you notice a series of cryptic symbols etched into the {Colours.RED}wall{Colours.NORMAL}, the letters twisted and distorted as if written by a madman's hand.\n"
            );//Thread.Sleep(4000);
            System.Console.WriteLine(
                "The words seem to shift and writhe on the surface, like living things.\n"
            );//Thread.Sleep(4000);
            System.Console.WriteLine(
                $"underneath the letters a {Colours.RED}body{Colours.NORMAL}, bent over, it's face resting against the ground\n"
            );//Thread.Sleep(4000);
            System.Console.WriteLine(
                $"Too your right , a small crooked {Colours.RED}bookshelf{Colours.NORMAL} lean against the wall, its wooden shelves bowed under the weight of dusty, leatherbound tomes\n"
            );//Thread.Sleep(4000);
            System.Console.WriteLine(
                $"In the center of the room you see some kinde of {Colours.RED}chest{Colours.NORMAL}, altough dusty underneath its rugged apperance something glimmers, drawing you in\n"
            );//Thread.Sleep(4000);
            System.Console.WriteLine(" ");
            System.Console.WriteLine("Press any key to continue..");
            Console.ReadLine();
            lookAround = true;
            ClearTerminal();
           
        }

        //Skriv Examine Chest
        public void ExamineChest()
        {
            System.Console.WriteLine(
                "As you walk up to the chest, something about it draws you in, but at the same time every fiber of your body tells you to stay away\n"
            );
            System.Console.WriteLine("Still, you muster courage and walk up to it.\n");
            System.Console.WriteLine(
                "You lean in, its a metal chest with gold engravings, with what seems like scrambled letters SVOOL NB UIRVMWH!\n"
            );
            chest = true;
            if (wall == true)
            {
                System.Console.WriteLine("These scrambled letter remind you of the wall.. Looking at the wall it says SVOOL MY UIRVMWH!\n");
                System.Console.WriteLine("");
            }
            if (wall == false)
            {
                System.Console.WriteLine("It feels like you´ve seen these letters somewhere..\n ");
                System.Console.WriteLine("Maybe you should look around the room some more");
            }
        }

        //Skriv Examine Body
        public void ExamineBody()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("You walk up to examine the body..\n");
            System.Console.WriteLine(
                "as you get closer you the smell expose that this corpse has been here for some time.\n"
            );
            System.Console.WriteLine(
                "You turn the corpse face up. What you see is something that ones looked like a face, now more resembling a smashed witherd pumpkin..\n "
            );

            if (hasNote == false)
            {
                System.Console.WriteLine(
                    "Looking closer you notice that the body is clutching something.\n"
                );
                System.Console.WriteLine(
                    $"It looks like some kind of {Colours.CYAN}note{Colours.NORMAL}\n"
                );
            }
        }

        //Skriv Examine Bookshelf
        public void ExamineBookshelf()
        {
            System.Console.WriteLine("You walk up to the crooked shelf\n");
            System.Console.WriteLine(
                "The books are old and worn, their covers cracked and faded. Some of which would seem to break at the slitest touch\n"
            );
            Console.ReadKey();
            return;
        }

        public void PickupNote()
        {
            if (hasNote == false)
            {
                System.Console.WriteLine("You bend down to pick up the diary\n");
                System.Console.WriteLine(
                    "The corpse degraded by time still holds the book in a fast grip.. \n"
                );
                System.Console.WriteLine(
                    "After some tumbling you manage to wrenge the diary from its clutches.\n"
                );
                System.Console.WriteLine(
                    "You pick it up , dust it of and put the diary in your inventory\n"
                );
                hasNote = true;
            }
            else
            {
                System.Console.WriteLine(
                    "You are sure you remember yourself picking up the diary..\n"
                );
            }
        }

        public void UseNote()
        {
            System.Console.WriteLine("You open up the note\n");
            System.Console.WriteLine("Scribed in what seems like blood");
            System.Console.WriteLine(
                "He describes the coming pussle, he tried to figure out the meaning\n"
            );
            System.Console.WriteLine("A-Z, D-W, M-N and Y-B");
            System.Console.WriteLine("What does it mean?");
        }

        //Skriv Look Wall
        public void ExamineWall()
        {
            wall = true;
            System.Console.WriteLine(
                "Looking closer you see that it's some kind of writing, words scrambled\n "
            );
            if (chest == true)
            {
                System.Console.WriteLine(
                    "It's the same as the chest but the etchings seem to actually spell out one of the words word, SVOOL 'MY' UIRVMWH!\n "
                );
            }
            else { }
        }

        public void StartPuzzle()
        {
            Cryptogram cryptogram = new Cryptogram();
            cryptogram.CryptoPuzzle();
        }
    }
}
