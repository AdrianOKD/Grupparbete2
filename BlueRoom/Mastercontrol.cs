using System;
using System.Collections.Generic;
using System.Threading;
using Grupparbete2;
using Grupparbete2.Commands;
using Pussel.Commands;


namespace HorrorEscape
{
    public class MasterControll
    {
        private Player player;


        private InventoryPlayer inventory;
        public static bool insideBlueRoom = true;
        private List<Command> commands;
        //  private int timeLeft = 10; // seconds
        // private Timer timer;

        public MasterControll()
        {
            player = new Player();
            InventoryPlayer inventory = new InventoryPlayer();
            commands = new List<Command>
            {
                new HelpBlueCommand(),
                new SolveMysteryCommand(player),
                new ExamineBlueCommand(),
                new UnlockCommand(player),
                new InventoryCommand(inventory),
                new EscapeCommand(player),
                new InspectRoomCommand(player),
                new PickupBlueCommand(inventory, this),
            };

        }

        public void Start()
        {
        
            DisplayText("You wake up in a dark, damp room. You must find a key to escape.");
            DisplayText("To escape, you must complete a series of tasks, each one crucial for your survival.");
            DisplayText("Pay attention to every detail and execute each task with caution.");
            DisplayText("Type 'help' to see available commands.");


            try
            {

                while (insideBlueRoom)
                {
                    Console.Write("\n> ");
                    System.Console.WriteLine();
                    string input = Console.ReadLine();
                    ExecuteCommand(input);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }

        private void ExecuteCommand(string input)
        {
            string[] parts = input.Split(' ', 2);
            string commandName = parts[0].ToLower();

            foreach (var command in commands)
            {
                if (command.Name == commandName)
                {
                    command.Execute(parts.Length > 1 ? parts[1] : "");
                    player.UseCommand(command.Name); // Logga använt kommando

                    // Minska tid med 10 sekunder när ett kommando används
                    player.ReduceTries(1);
                    System.Console.WriteLine();
                    //  Console.WriteLine("Warning: Time decreased by 1 try due to command usage!");

                    return;
                }
            }

            Console.WriteLine("Unknown command. Type 'help' for assistance.");
        }

        public void DisplayText(string text)
        {
            Console.WriteLine($"Displaying text: {text}"); // Debugging output för att se om metoden anropas
            string[] lines = text.Split(new[] { ". " }, StringSplitOptions.None);

            foreach (var line in lines)
            {
                Console.WriteLine(line.Trim() + ".");
                Thread.Sleep(1000);
            }
        }



    }
}

