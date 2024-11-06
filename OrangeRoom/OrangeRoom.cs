using Grupparbete2;
using Grupparbete2.Commands;
using Pussel.Commands;

namespace Pussel
{
    public class OrangeRoom
    {
     
      
        private InventoryPlayer inventory;
        private List<Command> commands;
        bool wall = false;
        bool chest = false;
        bool lookAround = false;
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
                new StartOrangePussleCommand(),
                new UseOrangeCommand(inventory),
                new HintOrangeCommand(),
            };
        }

        private void ExecuteCommand(string input)
        {
            if(input.Equals(null))
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
                    command.Execute(parts.Length > 1 ? parts[1] : "");
                    return;
                }
            }
        }
        

        public void OrangeRoomGame()
        { ClearTerminal();
            System.Console.WriteLine(
                $"{Colours.ORANGE}As you step into the dimly lit room, the heavy wooden door slams shut behind you, the sound echoing through the cold, damp air. "
            );
            //Thread.Sleep(4000);
            Console.WriteLine(
                "The only light comes from a faint, flickering glow emanating from the walls, casting eerie shadows on the stone floor."
            );
            //Thread.Sleep(4000);
            System.Console.WriteLine("Ah, Nice choice of room meatbag.. ");
            System.Console.WriteLine("");
            //Thread.Sleep(4000);
            System.Console.WriteLine($"system: What would you like to do? for options write Help{Colours.NORMAL}");
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
                Console.ReadLine();
            }
        }

        public void Hint()
        {  ClearTerminal();
            System.Console.WriteLine("You ask for Hint");
            if (lookAround == false)
            {
                System.Console.WriteLine($"Use your eyes meatbag.. {Colours.BOLD}Look Around!{Colours.NOBOLD}");
            }
            if (lookAround == true)
           {
            System.Console.WriteLine("Why are you asking for hints? You´ve look around the room, you should try and examine shit");
           } 
           
        }

        //Skriv Look Around
        public void LookAround()
        {
             ClearTerminal();

            System.Console.WriteLine("You look around the room");
            System.Console.WriteLine(
                "To your left, you notice a series of cryptic symbols etched into the wall, the letters twisted and distorted as if written in a madman's hand."
            );
            System.Console.WriteLine(
                "The words seem to shift and writhe on the surface, like living things."
            );
            System.Console.WriteLine("");
            System.Console.WriteLine(
                "underneath the letters a body, bent over and resting upon its head"
            );
            System.Console.WriteLine("");
            System.Console.WriteLine(
                "Too your right , a small crooked bookshelf lean against the wall, its wooden shelves bowed under the weight of dusty, leatherbound tomes"
            );
            System.Console.WriteLine();
            System.Console.WriteLine(
                "In the center of the room you see some kinde of wooden chest, something is reflecting the light, drawing you in"
            );
            System.Console.WriteLine("\n\n");
            System.Console.WriteLine("Press any key to continue..");
            Console.ReadLine();
        }

        //Skriv Examine Chest
        public void ExamineChest()
        {
            System.Console.WriteLine(
                "As you walk up to the chest, something about it draws you in, but at the same time every fiber of your body tells you to stay away"
            );
            System.Console.WriteLine("Still, you muster courage and walk up to it.");
            System.Console.WriteLine(
                "Coming closer you notice that the chest actually doesnt seem that old, compared to the rest of the room, this one seem like its been looked after. "
            );
            System.Console.WriteLine(
                "You lean in, its a metal chest with gold engravings, with what seems like scrambled letters"
            );
            chest = true;
            if (wall == true)
            {
                System.Console.WriteLine(
                    "These scrambled letter remind you of the wall, the etchings resembles the chests"
                );
                System.Console.WriteLine(
                    "It's the same but the etchings seem to actually spell out a word, 'my' "
                );
            }
            if (wall == false)
            {
                System.Console.WriteLine("It feels like you´ve seen these letters somewhere.. ");
            }
        }

        //Skriv Examine Body
        public void ExamineBody()
        {
            string RED = Console.IsOutputRedirected ? "" : "\x1b[91m";
            string NORMAL = Console.IsOutputRedirected ? "" : "\x1b[39m";
            System.Console.WriteLine("You walk up to examine the body..");
            System.Console.WriteLine(
                "as you get closer you the smell expose that this corpse has been here for some time."
            );
            System.Console.WriteLine(
                "You turn the corpse face up. What you see is something that ones look like a face, now smashed and twisted.. "
            );
            System.Console.WriteLine(
                "Looking closer you notice that the body is clutching something."
            );
            System.Console.WriteLine($"It looks like some kind of {RED}diary{NORMAL}");
        }

        //Skriv Examine Bookshelf
        public void ExamineBookshelf()
        {
            System.Console.WriteLine("You walk up to the crooked shelf");
            System.Console.WriteLine(
                "The books are old and worn, their covers cracked and faded. Some of which would seem to break at the slitest touch"
            );
            Console.ReadKey();
            return;
        }

        public void PickupDiary()
        {
            System.Console.WriteLine("You bend down to pick up the diary");
            System.Console.WriteLine(
                "The corpse degraded by time still holds the book in a fast grip.. "
            );
            System.Console.WriteLine(
                "After some tumbling you manage to wrenge the diary from its clutches."
            );
            System.Console.WriteLine(
                "You pick it up , dust it of and put the diary in your inventory"
            );
        }

        public void UseBook()
        {
            System.Console.WriteLine("You open up the  ");
        }

        public void UseDiary()
        {
            System.Console.WriteLine("You open up the leatherbound diary");
            System.Console.WriteLine("It describes the plight of the old man");
            System.Console.WriteLine(
                "He too seemed to have been put in the same unsavoury spot as you.."
            );
            System.Console.WriteLine(
                "He describes the coming pussle, he tried to figure out the meaning"
            );
            System.Console.WriteLine("A-Z and D-W");
            System.Console.WriteLine("But what does it mean?");
        }

        //Skriv Look Wall
        public void LookWall()
        {
            
            wall = true;
            if (wall == true)
            {
                System.Console.WriteLine("Wall is set to true");
            }
            System.Console.WriteLine(
                "Looking closer you se that it's some kind of writing, words scrambled "
            );
            System.Console.WriteLine();
            System.Console.WriteLine(
                "System: Would you like to try and read out what it says? if so write Read Word"
            );
        }

        public void pickupKey()
        {
            // string pickupKey = "key";
            //pickupCommand.Execute(pickupKey);
            System.Console.WriteLine("You bend over and pick up the key");
        }

        public void StartPussle()
        {
            Cryptogram cryptogram = new Cryptogram();
            cryptogram.CryptoPussle();
        }
    }
}
