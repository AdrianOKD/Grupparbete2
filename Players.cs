
using System;
using System.Collections.Generic;

namespace HorrorEscape
{
    public class Player

    {
        private List<string> inventory = new List<string>();
        private List<string> usedCommands = new List<string>();


        private int triesLeft = 2; // Totalt antal försök för spelaren

        public void ReduceTries(int tries)
        {
            triesLeft -= tries; // Minska antalet försök med angivet antal
              Console.WriteLine("Warning: Time decreased by 1 try due to command usage!");

            if (triesLeft <= 0)
            {
                triesLeft = 0;
                Console.WriteLine("You have run out of tries. The darkness surrounds you, and you fail to escape.");
                Environment.Exit(0); // Avsluta spelet
            }
            else if (triesLeft == 1)
            

            {
                Console.WriteLine("Warning: This is your last chance! Only 1 try left to escape!");
            }
            else
            {
                Console.WriteLine($"Tries left: {triesLeft} tries.");
            }
   
        }
         
        // Lista över obligatoriska kommandon
        private readonly List<string> requiredCommands = new List<string>
        {
            "help", "solve", "examine", "inspect", "unlock"
        };

        public bool DoorUnlocked { get; set; } = false;

        public void Pickup(string item)
        {
            inventory.Add(item);

            Console.WriteLine($"You picked up: {item}");

        }

        public void ShowInventory()
        {
            if (inventory.Count == 0)
            {
                Console.WriteLine("Your inventory is empty.");
            }
            else
            {
                Console.WriteLine("You have the following items:");
                foreach (var item in inventory)
                {
                    Console.WriteLine($"- {item}");

                }
            }
        }

        public bool HasItem(string item)
        {
            return inventory.Contains(item); // Använd return för att ge tillbaka värdet
        }

        public void UseCommand(string command)
        {
            // Lägg till kommandot om det är ett av de obligatoriska och inte redan använt
            if (requiredCommands.Contains(command) && !usedCommands.Contains(command))
            {
                usedCommands.Add(command);
                Console.WriteLine($"Command '{command}' used.");
            }

        }

        public bool CanEscape()
        {
            return !(usedCommands.Count < requiredCommands.Count); // Kontrollera om alla obligatoriska kommandon har använts
        }

    }
}


