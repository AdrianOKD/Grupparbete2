using System;

namespace HorrorEscape
{
    public abstract class BlueCommand
    {
        public string Name { get; }

        protected BlueCommand(string name)
        {
            Name = name;
        }

        public abstract void Execute(string argument);
    }

    public class HelpCommand : BlueCommand 
    {
        public HelpCommand() : base("help") { }


        public override void Execute(string argument)
        {


            /*Console.WriteLine("Available commands:");
            Console.WriteLine("- help: shows available commands");
            Console.WriteLine("- solve 'find key': search for the key");
            Console.WriteLine("- examine 'object': examine an object");
            Console.WriteLine("- inventory: shows your items");
            Console.WriteLine("- unlock 'code': try to unlock the door with a code");
            Console.WriteLine("- escape: attempt to escape");
            Console.WriteLine("- inspect: closely examine the room");*/

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

    public class SolveMysteryCommand : BlueCommand
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

    public class InspectRoomCommand : BlueCommand
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
