
using Pussel.Commands;
using Pussel;
using HorrorEscape;

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
            string lowerArgument = argument.ToLower();
            OrangeRoom orangeRoom = new OrangeRoom();

            if (lowerArgument.Contains("chest"))
            {
                Console.WriteLine($"You examine the {argument}. ");
                orangeRoom.ExamineChest();
                Console.ReadKey();
                return;
            }

            if (lowerArgument.Equals("bookshelf"))
            {
                Console.WriteLine($"You choose to examine the {argument}. ");
                orangeRoom.ExamineBookshelf();
               
            }
            if (lowerArgument.Equals("body"))
            {

                System.Console.WriteLine($"You choose to examine the {argument}");
                orangeRoom.ExamineBody();
                
            }
            
            else
            {
                Console.WriteLine("Objektet finns inte.");
            }
        }
    }
       public class ExamineBlueCommand : Command
    {
        public ExamineBlueCommand () : base("examine") { }

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

