using Pussel.Commands;
using HorrorEscape;
namespace Grupparbete2.Commands
{
     public class SolveMysteryCommand : Command
    {
        private Player player;

        InventoryPlayer inventory;

        public SolveMysteryCommand(Player player) : base("solve")
        {
            this.player = player;
        }

        public override void Execute(string argument)
        {
            if (argument == "find key")
            {
               
                 if (inventory.Inventory.Contains("Blue Key"));
                 {
                    System.Console.WriteLine("You already have the key. Now find the exit.");
                 }
                 if(!inventory.Inventory.Contains("Blue Key"))
                 {
                    Console.WriteLine("You search carefully... and find the key hidden under a floorboard!");
                   
                }
            }
            else
            {
                Console.WriteLine($"There is no puzzle named: '{argument}'.");
            }
        }
    }
}