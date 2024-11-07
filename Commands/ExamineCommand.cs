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
            else
            {
                Console.WriteLine("Specify what object you want to examine.");
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
                Console.WriteLine("The floor creaks... a plank feels loose.");
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
            if (args == "platform" || args == "jugs")
            {
                Console.WriteLine("In the center of the room, there's a platform with three wooden jugs: 3 liters, 5 liters, and 8 liters.");
                Console.WriteLine("You must find a way to measure exactly 4 liters in the 8-liter jug to unlock the door.");
            }
            else
            {
                Console.WriteLine("The room is dimly lit with a metallic smell in the air. A platform with jugs stands in the center.");
            }
        }
    }



}
