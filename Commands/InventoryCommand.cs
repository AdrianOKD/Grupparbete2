using Pussel.Commands;

namespace Grupparbete2.Commands
{

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
}
