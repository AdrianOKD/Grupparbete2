using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pussel;
using Pussel.Commands;


namespace Grupparbete2.Commands
{
    public class HelpOrangeCommand : Command
    {
        public HelpOrangeCommand()
            : base("help") { }

        public override void Execute(string argument)
        {
            Console.WriteLine("Tillgängliga kommandon:");
            Console.WriteLine("- examine 'object': examines an object");
            Console.WriteLine("- inventory: show what you have in your inventory");
            Console.WriteLine(
                "- look 'argument': looks at a certain thing, such as a room or around etc."
            );
            System.Console.WriteLine("- use 'argument': uses an object in your inventory");
            System.Console.WriteLine("- Hint 'arugment': Gives you a hint on what to do next ");
            System.Console.WriteLine("");
        }
    }

    public class HelpBlueCommand : Command
    {
        public HelpBlueCommand()
            : base("help") { }

        public override void Execute(string argument)
        {
            Console.WriteLine("\nAvailable Commands:");
            Console.Write("1. help: shows available commands\t");
            Console.Write("2. solve 'find key': search for the key\t");
            Console.WriteLine("3. examine 'object': examine an object");
            Console.Write("4. inventory: shows your items\t");
            Console.Write("5. unlock 'code': try to unlock the door with a code\t");
            Console.WriteLine("6. escape: attempt to escape ");
            Console.Write("7. inspect: closely examine the room ");
            Console.Write("\nChoose an option: ");
        }
    }

    public class HelpGreenCommand : Command
    {
        public HelpGreenCommand()
            : base("help") { }

        public override void Execute(string argument)
        {
            Console.WriteLine("List of commands:");
            Console.WriteLine("- Type 'help' to View the menu");
            Console.WriteLine("- Type 'room' To enter the green room  ");
            Console.WriteLine("- Type 'inventory' check if you have the key");
            Console.WriteLine("- Type 'Exit' or 'stop' to exit the green room");
        }
    }
     public class HelpMainRoomCommand : Command
    {
        public HelpMainRoomCommand()
            : base("help") { }

        public override void Execute(string argument)
        {
            Console.WriteLine("List of commands:");
            Console.WriteLine("- Type 'Choose Room' to pick a room that you want to enter");
            Console.WriteLine("- Type 'inventory' to check if you have anything in your inventory");
            
        }
    }
}
