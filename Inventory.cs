using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grupparbete2
{
    public class InventoryPlayer
    {
        public List<string> Inventory { get; private set; }

        public InventoryPlayer()
        {
            Inventory = new List<string>();
        }

        public void Pickup(string item)
        {
            Inventory.Add(item);
            Console.WriteLine($"You picked up: {item}");
        }

        public void ShowInventory()
        {
            if (Inventory.Count == 0)
            {
                Console.WriteLine("Your Inventory is empty");
                return;
            }

            Console.WriteLine("You open your bag to check what's in it, you find the following:");
            foreach (var item in Inventory)
            {
                Console.WriteLine($"- {item}");
            }
        }
    }
}
