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
}
