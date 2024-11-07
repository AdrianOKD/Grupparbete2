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
            if (argument.Contains("note"))
            {
                orangeRoom.PickupNote();
                inventory.Pickup("Note");
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
                System.Console.WriteLine(
                    $"{Colours.BLUE}You picked up{Colours.NORMAL} {Colours.BLUE}the Blue Key{Colours.NORMAL}"
                );
                System.Console.WriteLine(
                    $"{Colours.NORMAL}Underneath the key you see some scratchmarks resembling the numbers {Colours.BLUE}'4' '7' and '3'{Colours.NORMAL}"
                );

                inventory.Pickup("BlueKey");
            }
        }
    }
}
