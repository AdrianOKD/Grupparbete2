using Pussel;
using Pussel.Commands;
namespace Grupparbete2.Commands
{
    public class PickupCommand : Command
    {
        private OrangeRoom orangeRoom;
         
        private InventoryPlayer inventory;


        public PickupCommand(InventoryPlayer inventory, OrangeRoom orangeRoom)
            : base("pick up")
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
            if (argument.Contains("diary"))
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
}
