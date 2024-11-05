
using System;
using System.Collections.Generic;

namespace HorrorEscape
{
    //Ismaels player, försök kombinera med andra playerclassen eller göra så att inventoryt delas av båda playersna så att man kan få med key från olika rum.
    public class Player
    {
        private List<string> inventory = new List<string>();
        private List<string> usedCommands = new List<string>();

         private int timeLeft = 180; // Total tid för spelaren

    public void ReduceTime(int seconds)
    {
        timeLeft -= seconds; // Minska tiden med angivet antal sekunder
        if (timeLeft < 0)
        {
            timeLeft = 0; // Se till att tiden inte blir negativ
        }

        Console.WriteLine($"Time left: {timeLeft} seconds."); // Visa kvarvarande tid
    }

         

        // Lista över obligatoriska kommandon
        private readonly List<string> requiredCommands = new List<string>
        {
            "help", "solve", "examine", "inspect", "unlock"
        };

      // public bool HasFlashlight { get; set; } = true;
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


