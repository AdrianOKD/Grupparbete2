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
            Console.WriteLine("Available commands:");
            Console.WriteLine($"- {Colours.MAGENTA}help{Colours.NORMAL}: shows available commands");
            Console.WriteLine($"- {Colours.BLUE}pickup{Colours.NORMAL} 'blue key': search for the key");
            Console.WriteLine($"- {Colours.GREEN}examine{Colours.NORMAL} 'object': examine an object");
            Console.WriteLine($"- {Colours.ORANGE}inventory{Colours.NORMAL}: shows your items");
            Console.WriteLine($"- {Colours.YELLOW}unlock{Colours.NORMAL} 'code': try to unlock the door with a code");
            Console.WriteLine($"- {Colours.GREEN}escape{Colours.NORMAL}: attempt to escape");
            Console.WriteLine($"- inspect: closely examine the room");



           






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
