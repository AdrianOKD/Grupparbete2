using System;
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
        static bool hasExaminedBody = false;
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
            if (input == null)
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
            Console.WriteLine(
                $"As you step into the dimly lit room, the heavy wooden door slams shut behind you, the sound echoing through the cold, damp air.\n "
            );
            //Thread.Sleep(4000);
            Console.WriteLine(
                "The only light comes from a faint, flickering glow emanating from the walls, casting eerie shadows on the stone floor.\n"
            );
            //Thread.Sleep(4000);
            Console.WriteLine(
                $"{Colours.GREY}Ah, Nice choice of room meatbag..take a {Colours.BLUE}look around{Colours.NORMAL} {Colours.GREY}and maybe you´ll find a way out..{Colours.NORMAL}\n "
            );
            //Thread.Sleep(4000);
            Console.WriteLine();
            Console.WriteLine($"System: What would you like to do? for options write Help\n");
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
            {
                ClearTerminal();
                Console.WriteLine(
                    $"{Colours.GREY}{Colours.BOLD}ENOUGH! EITHER YOU FIGURE THIS OUT OR STAY HERE AND ROT..{Colours.NOBOLD}*Sigh* I´ve given you all you need to figure this out. I´ll leave you to do what you will..{Colours.NORMAL}"
                );
                hints++;
            }
            if (annoyance && hints == 3)
            {
                ClearTerminal();
                Console.WriteLine(
                    "You ask for a hint but get no response.. Guess they really left.."
                );
                hints++;
                annoyance = false;
            }
            if (!annoyance && hints > 3)
            {
                ClearTerminal();
                Console.WriteLine("No response..");
            }
            if (!lookAround && hints <= 1)
            {
                ClearTerminal();
                Console.WriteLine(
                    $"{Colours.GREY}Use your eyes meatbag.. {Colours.BOLD}{Colours.BLUE}Look Around!{Colours.NOBOLD}{Colours.NORMAL}\n"
                );
            }
            if (lookAround && hints <= 2)
            {
                ClearTerminal();
                Console.WriteLine(
                    $"{Colours.GREY}Why are you asking for hints? You´ve looked around the room, if you don't know what to do look closer,{Colours.RED}examine{Colours.NORMAL} , anything really.. \n a toddler could do a better job than you.. {Colours.NORMAL}\n"
                );
                annoyance = true;
                lookAround = false;
                hints++;
            }
        }

        //Skriv Look Around
        public void LookAround()
        {
            ClearTerminal();

            Console.WriteLine("You look around the room\n");
            Console.WriteLine(
                $"To your left, you notice a series of cryptic symbols etched into the {Colours.RED}wall{Colours.NORMAL}, the letters twisted and distorted as if written by a madman's hand.\n"
            ); //Thread.Sleep(4000);
            Console.WriteLine(
                "The words seem to shift and writhe on the surface, like living things.\n"
            ); //Thread.Sleep(4000);
            Console.WriteLine(
                $"underneath the letters a {Colours.RED}body{Colours.NORMAL}, bent over, it's face resting against the ground\n"
            ); //Thread.Sleep(4000);
            Console.WriteLine(
                $"Too your right , a small crooked {Colours.RED}bookshelf{Colours.NORMAL} lean against the wall, its wooden shelves bowed under the weight of dusty, leatherbound tomes\n"
            ); //Thread.Sleep(4000);
            Console.WriteLine(
                $"In the center of the room you see some kind of {Colours.RED}chest{Colours.NORMAL}, although dusty, underneath its rugged apperance something glimmers, drawing you in\n"
            ); //Thread.Sleep(4000);
            lookAround = true;
            
        }

        //Skriv Examine Chest
        public void ExamineChest()
        {   ClearTerminal();
            Console.WriteLine(
                "As you walk up to the chest, something about it draws you in, but at the same time every fiber of your body tells you to stay away\n"
            );
            Console.WriteLine("Still, you muster courage and walk up to it.\n");
            Console.WriteLine(
                "You lean in, its a metal chest with gold engravings, with what seems like scrambled letters SVOOL NB UIRVMWH!\n"
            );
            chest = true;
            if (wall && hasNote)
            {
                Console.WriteLine(
                    "These scrambled letter remind you of the wall.. Looking at the wall it says SVOOL MY UIRVMWH!\n"
                );
                Console.WriteLine($"Would you like to try and {Colours.ORANGE}solve puzzle{Colours.NORMAL}?");
            }
            if (!wall)
            {
                Console.WriteLine("It feels like you´ve seen these letters somewhere..\n ");
                Console.WriteLine("Maybe you should look around the room some more");
            }
             
        }

        //Skriv Examine Body
        public void ExamineBody()
        {    ClearTerminal();
            Console.WriteLine();
            Console.WriteLine(
                "As you get closer the smell expose that this corpse has been here for some time.\n"
            );
            Console.WriteLine(
                "You turn the corpse face up. What you see is something that ones looked like a face, now more resembling a smashed withered pumpkin..\n "
            );

            if (!hasNote)
            {
                Console.WriteLine(
                    "Looking closer you notice that the body is clutching something.\n"
                );
                Console.WriteLine(
                    $"It looks like some kind of {Colours.CYAN}note{Colours.NORMAL}\n"
                );
            }
            hasExaminedBody = true;
        }

        //Skriv Examine Bookshelf
        public void ExamineBookshelf()
        {
            ClearTerminal();
            Console.WriteLine("You walk up to the crooked shelf\n");
            Console.WriteLine(
                "The books are old and worn, their covers cracked and faded. Some of which would seem to break at the slightest touch\n"
            );
            Console.WriteLine(
                "There doesnt seem to be anything here of interest.. altough you notice that there's a dustfree imprint of a book missing"
            );
          
        }

        public void PickupNote()
        {    ClearTerminal();
            if (!hasNote && hasExaminedBody)
            {
                Console.WriteLine("You bend down to pick up the note \n");
                Console.WriteLine(
                    "The corpse degraded by time still holds the note in a firm grip.. \n"
                );
                Console.WriteLine(
                    "After some tumbling you manage to wrenge it from its clutches.\n"
                );
                Console.WriteLine("You pick it up and put the note in your inventory\n");
                hasNote = true;
            }
            else if (hasNote && hasExaminedBody)
            {
                Console.WriteLine("You´re sure you remember yourself picking up the note..\n");
            }
            else
            {
                Console.WriteLine("What note?");
            }
        }

        public void UseNote()
        {    ClearTerminal();
            Console.WriteLine("You open up the note\n");
            Console.WriteLine("Scribed in what seems like blood");
            Console.WriteLine(
                "He describes the coming puzzle, he tried to figure out the meaning\n"
            );
            Console.WriteLine($"{Colours.RED}A-Z, D-W, M-N{Colours.NORMAL} and {Colours.RED}Y-B{Colours.NORMAL}");
            Console.WriteLine("What does it mean?");
        }

        //Skriv Look Wall
        public void ExamineWall()
        {    ClearTerminal();
            if (!wall)
            {
                Console.WriteLine(
                    "Looking closer you see that it's some kind of writing, words scrambled, SVOOL 'MY' UIRVMWH!\n "
                );
                wall = true;
            }

            if (chest)
            {
                Console.WriteLine(
                    "It's the same as the chest but the etchings seem to actually spell out one of the words, SVOOL 'MY' UIRVMWH!\n "
                );
            }
        
        }

        public void StartPuzzle()
        {
            if (chest && wall)
            {
                Cryptogram cryptogram = new Cryptogram();
                cryptogram.CryptoPuzzle();
            }
            else
            {
                Console.WriteLine("You have a feeling that you should search the room some more");
            }
        }
    }
}
