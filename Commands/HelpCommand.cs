using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pussel.Commands;
using Pussel;


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
            Console.WriteLine("- look 'argument': looks at a certain thing, such as a room or around etc.");
            System.Console.WriteLine("- use 'argument': uses an object in your inventory");
            System.Console.WriteLine("");
        }
    }
     public class HelpBlueCommand : Command
    {
        public HelpBlueCommand() : base("help") { }


        public override void Execute(string argument)
        {


            Console.WriteLine("Available commands:");
            Console.WriteLine("- help: shows available commands");
            Console.WriteLine("- solve 'find key': search for the key");
            Console.WriteLine("- examine 'object': examine an object");
            Console.WriteLine("- inventory: shows your items");
            Console.WriteLine("- unlock 'code': try to unlock the door with a code");
            Console.WriteLine("- escape: attempt to escape");
            Console.WriteLine("- inspect: closely examine the room");

        }

    }
    
    public class HelpGreenCommand : Command
{
    public HelpGreenCommand() : base("help") { }

    public override void Execute(string argument)
    {
        Console.WriteLine("List of commands:");
        Console.WriteLine("- Type 'help' to View the menu");
        Console.WriteLine("- Type 'room' To enter the green room  ");
        Console.WriteLine("- Type 'inventory' check if you have the key");
        Console.WriteLine("- Type 'Exit' or 'stop' to exit the green room");
    }
} 
}