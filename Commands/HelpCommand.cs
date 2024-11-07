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
            Console.WriteLine($"-{Colours.RED} examine{Colours.NORMAL} 'object': examines an object.");
            System.Console.WriteLine($"- {Colours.CYAN}Pickup{Colours.NORMAL} 'object': Picks up object.");
            Console.WriteLine($"- {Colours.YELLOW}inventory{Colours.NORMAL}: show what you have in your inventory.");
            Console.WriteLine(
                $"- {Colours.BLUE}look{Colours.NORMAL} 'argument': looks at a certain thing, such as a room or around etc."
            );
            System.Console.WriteLine($"- {Colours.GREEN}use{Colours.NORMAL} 'argument': uses an object in your inventory.");
            System.Console.WriteLine($"- {Colours.MAGENTA}Hint{Colours.NORMAL} 'arugment': Gives you a hint on what to do next. ");
           
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
            Console.WriteLine("- Type 'green room' To enter the green room  ");
            // Console.WriteLine("- Type 'Exit' or 'stop' to exit the green room");
        }
    }

        public class HelpRedCommand : Command
    {
        public HelpRedCommand()
            : base("help") { }

        public override void Execute(string args)
        {
            Console.WriteLine("Available commands: 'examine', 'start puzzle', 'fill', 'pour', 'empty'.");
        }
    }
}
