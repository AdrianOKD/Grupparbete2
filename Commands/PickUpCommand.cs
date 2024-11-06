using HorrorEscape;
using Pussel;
using Pussel.Commands;
namespace Grupparbete2.Commands
{
    public class PickupCommand : Command
    {
        private OrangeRoom orangeRoom;
         
        private InventoryPlayer inventory;


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
            if (argument.Contains("diary"))
            {
                orangeRoom.PickupDiary();
                inventory.Pickup(argument);
            }
            if (argument.Contains("key"))
            {
                orangeRoom.pickupKey();
                inventory.Pickup("Orange Key");
            }
        }
    }

      public class PickupBlueCommand : Command
    {
        private MasterControll masterControll;
         
        private InventoryPlayer inventory;

        public PickupBlueCommand(InventoryPlayer inventory, MasterControll masterControll)
            : base("pickup")
        {
            this.inventory = inventory;
            this.masterControll = masterControll;
        }

        public override void Execute(string argument)
        {
            if (string.IsNullOrEmpty(argument))
            {
                Console.WriteLine("You need to specify an item to pick up");
                return;
            }
            if (argument.Contains("key"))
            {
                System.Console.WriteLine("you pick up Blue Key");
                inventory.Pickup("Blue Key");


            }
           
        }
    }
}
