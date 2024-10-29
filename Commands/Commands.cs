using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Pussel;

namespace Pussel.Commands
{
    
    public abstract class Command
    {
        public string Name { get; }

        protected Command(string name)
        {
            Name = name;
        }

        public abstract void Execute(string argument);
    }

    public class HelpOrangeCommand : Command
    {
        public HelpOrangeCommand()
            : base("help") { }

        public override void Execute(string argument)
        {
            Console.WriteLine("Tillgängliga kommandon:");
            Console.WriteLine("- help: show avaliable commands");
            Console.WriteLine("- examine 'object': examines an object");
            Console.WriteLine("- inventory: show what you have in your inventory");
            Console.WriteLine("- look 'argument': looks at a certain thing, such as a room or around etc.");
        }
    }

    public class SolveMysteryCommand : Command
    {
        private Player player;

        public SolveMysteryCommand(Player player)
            : base("solve")
        {
            this.player = player;
        }

        public override void Execute(string argument)
        {
            if (string.IsNullOrEmpty(argument))
            {
                Console.WriteLine("Skriv namnet på mysteriet du vill lösa.");
                return;
            }

            Console.WriteLine($"Du försöker lösa mysteriet: '{argument}'...");
            // Logik för att lösa mysterier
        }
    }

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
             if (lowerArgument.Equals("diary"))
            {

                System.Console.WriteLine($"You choose to examine the {argument}");
                orangeRoom.ExamineDiary();
                
            }
            else
            {
                Console.WriteLine("Objektet finns inte.");
            }
        }
    }

    public class TalkCommand : Command
    {
        public TalkCommand()
            : base("talk") { }

        public override void Execute(string argument)
        {
            if (string.IsNullOrEmpty(argument))
            {
                Console.WriteLine("Skriv meddelandet du vill säga.");
                return;
            }

            Console.WriteLine($"Du säger: '{argument}'. En NPC ger dig information.");
        }
    }

    public class Interact : Command
    {
        public Interact(string name)
            : base(name) { }

        public override void Execute(string argument)
        {
            throw new NotImplementedException();
          //  string lowerArgument = argument.ToLower();
        }
    }

    public class LookOrangeCommand : Command
    {
        public LookOrangeCommand()
            : base("look") { }

        public override void Execute(string argument)
        {
            if (string.IsNullOrEmpty(argument))
            {
                Console.WriteLine("Write the name of what you want to look at.");
                return;
            }
            string lowerArgument = argument.ToLower();
            if (lowerArgument.Contains("around"))
            {
                OrangeRoom orangeRoom = new OrangeRoom();
                orangeRoom.LookAround();
                return;
            }
            if (lowerArgument.Contains("wall"))
            {
                OrangeRoom orangeRoom = new OrangeRoom();
                orangeRoom.LookWall();
                return;
            }
        }
    }

    public class InventoryCommand : Command
    {
        private Player player;

        public InventoryCommand(Player player)
            : base("inventory")
        {
            this.player = player;
        }

        public override void Execute(string argument)
        {
            player.ShowInventory();
        }
    }

    public class PickupCommand : Command
    {
       private OrangeRoom orangeRoom;
        private Player player;

        public PickupCommand(Player player, OrangeRoom orangeRoom)
            : base("pickup")
        {
          
            this.player = player;
        this.orangeRoom = orangeRoom;
    }
        

        public override void Execute(string argument)
        {
          
            if (string.IsNullOrEmpty(argument))
            {
                Console.WriteLine("You need to specify an item to pick up");
                return;
            }
            if (argument.Contains("book"))
            { //Cryptogram cryptogram = new Cryptogram();
            
                orangeRoom.PickupBook();
                player.Pickup(argument);
            }
            if (argument.Contains("diary"))
            {
              orangeRoom.PickupDiary();
              player.Pickup(argument);
            }
            if (argument.Contains("key"))
            {
                orangeRoom.pickupKey();
                player.Pickup(argument);

            }
        }
    }
    public class UseOrangeCommand : Command
    {
         OrangeRoom orangeRoom = new OrangeRoom();
         private Player player;
        public UseOrangeCommand() : base("use")
        {
            

        }


        public override void Execute(string argument)
        {
             if (string.IsNullOrEmpty(argument))
            {
                Console.WriteLine("You need to specify what item you want to use.");
                return;
            }
            if (argument.Contains("book"))
            {
                orangeRoom.UseBook();

            }
        }
    }
        public class StartOrangePussleCommand : Command
        {
            
            public StartOrangePussleCommand() : base("start")
            {
            }

            public override void Execute(string argument)
            {
                if (argument.Contains("pussle"))
                {
                     OrangeRoom orangeRoom = new OrangeRoom();
                    orangeRoom.StartPussle();
                    return;
                    
                }
            }
        }
    
}


/*public class InventoryCommand : Command
{
    private Player player;

    public InventoryCommand(Player player) : base("inventory")
    {
        this.player = player;
    }

    public override void Execute(string argument)
    {
        player.ShowInventory();
    }
}
*/
