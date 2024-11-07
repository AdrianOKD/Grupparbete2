using System.Runtime.InteropServices;
using Pussel;
using Pussel.Commands;

namespace Grupparbete2.Commands
{
    public class ExamineOrangeCommand : Command
    {
        public ExamineOrangeCommand()
            : base("examine") { }

        public override void Execute(string argument)
        {
            if (string.IsNullOrEmpty(argument))
            {
                Console.WriteLine("Skriv namnet på objektet du vill undersöka.");
                return;
            }

            OrangeRoom orangeRoom = new OrangeRoom();

            if (argument.Contains("chest"))
            {
                Console.WriteLine($"You examine the {argument}. ");
                orangeRoom.ExamineChest();
            }

            if (argument.Equals("bookshelf"))
            {
                Console.WriteLine($"You choose to examine the {argument}. ");
                orangeRoom.ExamineBookshelf();
            }
            if (argument.Equals("body"))
            {
                System.Console.WriteLine($"You choose to examine the {argument}");
                orangeRoom.ExamineBody();
            }
            if (argument.Equals("wall"))
            {
                System.Console.WriteLine($"You choose to examine the {argument}");
                orangeRoom.ExamineWall();
            }
        }
    }

    public class ExamineBlueCommand : Command
    {
        public ExamineBlueCommand()
            : base("examine") { }

        public override void Execute(string argument)
        {
            if (argument == "door")
            {
                Console.WriteLine("The door is locked. You need a key.");
            }
            else if (argument == "floor")
            {
                Console.WriteLine($"You examine the {Colours.GREEN}floor{Colours.NORMAL}.");
                Console.WriteLine("The floor creaks... a plank feels loose.");
                System.Console.WriteLine("You pull up the board, and find a small blue key..");
            }
            else
            {
                Console.WriteLine($"Nothing special about '{argument}'.");
            }
        }
    }

    public class ExamineRedCommand : Command
    {
        public ExamineRedCommand()
           : base("examine") { }

        public override void Execute(string args)
        {
            if (args == "platform")
            {
                Console.WriteLine("");
                Console.WriteLine($"As you approach the platform, you see that there are three {Colours.CYAN}jugs{Colours.NORMAL} in ominous uneven shapes placed upon it.");
                Console.WriteLine($"How could these {Colours.CYAN}jugs{Colours.NORMAL} possibly help you escape this place? Perhaps you should look at them a bit closer...");
            }
            if (args == "jugs")
            {
                Console.WriteLine("");
                Console.WriteLine($"As your gaze travels along the shapes of the jugs and colour, you notice markings on their sides. '{Colours.RED}3{Colours.NORMAL}', '{Colours.RED}5{Colours.NORMAL}, and '{Colours.RED}8{Colours.NORMAL}'.");
                Console.WriteLine("You reach out your finger and touch their surface for a brief moment. It's strangely sticky and slightly warm to the touch.");
                Console.WriteLine("Something about them makes you incredibly uneasy and you turn away in disgust.");
                Console.ReadLine();
                Console.WriteLine($"These jugs seem like they will be used for something important. Perhaps the time has come to '{Colours.ORANGE}Start Puzzle{Colours.NORMAL}'?");

            }
            if (args == "door")
            {
                Console.WriteLine("");
                Console.WriteLine($"The door is shut, steel bars locking it firmly in place. You will need to find another way to exit this {Colours.CYAN}room{Colours.NORMAL}.");
            }
            if (args == "room")
            {
                Console.WriteLine("");
                Console.WriteLine($"The room is almost fully dark with an strange metallic smell in the air.");
                Console.WriteLine($"A very dim light reveal a {Colours.CYAN}platform{Colours.NORMAL} in the center with something placed on it.");
            }
        }
    }

}
