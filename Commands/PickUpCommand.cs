using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grupparbete2;
using Pussel;
using Pussel.Commands;

namespace Grupparbete2.Commands
{
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
