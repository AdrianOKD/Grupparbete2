using Pussel;
using Pussel.Commands;

namespace Grupparbete2.Commands
{
    public class UseOrangeCommand : Command
    {
        private InventoryPlayer inventory;

        //private Player player;
        public UseOrangeCommand(InventoryPlayer inventory)
            : base("use")
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
            {
                OrangeRoom orangeRoom = new OrangeRoom();
                orangeRoom.UseBook();
            }
            if (argument.Contains("diary"))
            {
                //System.Console.WriteLine("Detta är invCounter " +player.Inventory.Count);
                if (inventory.Inventory.Contains("diary"))
                {
                    OrangeRoom orangeRoom = new OrangeRoom();
                    orangeRoom.UseDiary();
                }
            }
        }
    }
}
