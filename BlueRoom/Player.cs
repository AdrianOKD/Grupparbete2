using System;
using System.Collections.Generic;
using Grupparbete2;
using Pussel;
using Pussel.Commands;

namespace HorrorEscape
{
    public class Player
    {
        private List<string> BlueRoomInventory = new List<string>();
        private List<string> usedCommands = new List<string>();

        private int triesLeft = 12; // Totalt antal försök för spelaren

        public void ReduceTries(int tries)
        {
            triesLeft -= tries; // Minska antalet försök med angivet antal
            Console.WriteLine("Warning: Time decreased by 1 try due to command usage!");

            if (triesLeft <= 0)
            {
                triesLeft = 0;
                Console.WriteLine(
                    "You have run out of tries. The darkness surrounds you, and you fail to escape."
                );
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
            "help",
            "examine",
            "inspect",
            "unlock",
        };

        public bool DoorUnlocked { get; set; } = false;

        public bool HasItem(string item)
        {
            return BlueRoomInventory.Contains(item); // Använd return för att ge tillbaka värdet
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
            return !(usedCommands.Count < requiredCommands.Count);
            // Kontrollera om alla obligatoriska kommandon har använts
        }
    }
}
