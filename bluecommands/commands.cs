using System;

/*namespace HorrorEscape
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

    public class HelpCommand : Command
    {
        public HelpCommand() : base("help") { }


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
    
   

    public class SolveMysteryCommand : Command
    {
        private Player player;

        public SolveMysteryCommand(Player player) : base("solve")
        {
            this.player = player;
        }

        public override void Execute(string argument)
        {
            if (argument == "find key")
            {
                if (player.HasItem("key"))
                {
                    Console.WriteLine("You already have the key. Now find the exit.");
                }
                else
                {
                    Console.WriteLine("You search carefully... and find the key hidden under a floorboard!");
                    player.Pickup("key");
                }
            }
            else
            {
                Console.WriteLine($"There is no puzzle named: '{argument}'.");
            }
        }
    }

    public class InspectRoomCommand : Command
    {
        private Player player;

        public InspectRoomCommand(Player player) : base("inspect") { }

        public override void Execute(string argument)
        {
            Console.WriteLine("You look around the room carefully... The walls are damp, and the smell of mold fills the air.");
            Console.WriteLine("Something feels off about the floor. Perhaps there's something hidden beneath?");
        }


    }

}
*/
