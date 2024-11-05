using Pussel.Commands;
using HorrorEscape;
namespace Grupparbete2.Commands
{
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
}