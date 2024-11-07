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
    /*
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
    
      
    
        public class InteractCommand : Command
        {
            public InteractCommand(string name)
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
            //private Player player;
              
            private InventoryPlayer inventory;
    
            public InventoryCommand(InventoryPlayer inventory)
                : base("inventory")
            {
                this.inventory = inventory;
            }
        
            public override void Execute(string argument)
            {
                inventory.ShowInventory();
            }
        }
    
        public class PickupCommand : Command
        {
           private OrangeRoom orangeRoom;
    
           private InventoryPlayer inventory;
            //private Player player;
    
            public PickupCommand(InventoryPlayer inventory, OrangeRoom orangeRoom)
                : base("pickup")
            {
              
                this.inventory = inventory;
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
                    inventory.Pickup(argument);
                }
                if (argument.Contains("diary") )
                {
                  orangeRoom.PickupDiary();
                  inventory.Pickup(argument);
                }
                if (argument.Contains("key"))
                {
                    orangeRoom.pickupKey();
                    inventory.Pickup(argument);
    
                }
            }
        }
        public class UseOrangeCommand : Command
        {
            private InventoryPlayer inventory;
             //private Player player;
            public UseOrangeCommand(InventoryPlayer inventory) : base("use")
            {
                
                this.inventory = inventory;
    
            }
    
    
            public override void Execute(string argument)
            {
                 if (string.IsNullOrEmpty(argument))
                {
                    Console.WriteLine("You need to specify what item you want to use.");
                    return;
                }
                InventoryPlayer inventory = new InventoryPlayer();
               
                if (argument.Contains("book"))
                {  OrangeRoom orangeRoom = new OrangeRoom();
                    orangeRoom.UseBook();
    
                }
                if (argument.Contains("diary"))
                {
                    //System.Console.WriteLine("Detta är invCounter " +player.Inventory.Count);
                    if(inventory.Inventory.Contains("diary"))
                      {
                     OrangeRoom orangeRoom = new OrangeRoom();
                    orangeRoom.UseDiary();
                       }
                     
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
        */
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
