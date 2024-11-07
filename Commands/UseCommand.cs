using Pussel;
using Pussel.Commands;

namespace Grupparbete2.Commands
{
    public class UseOrangeCommand : Command
    {
        private InventoryPlayer inventory;

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
            
            if (argument.Contains("note"))
            {
                if (inventory.Inventory.Contains("Note"))
                {
                    OrangeRoom orangeRoom = new OrangeRoom();
                    orangeRoom.UseNote();
                }
                else
                {
                    System.Console.WriteLine("There's no note in your inventory");
                }
            }
        }
    }
}
