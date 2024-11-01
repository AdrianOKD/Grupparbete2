using System;
using System.Collections.Generic;
using System.Threading;

namespace HorrorEscape
{
    public class Game
    {
        private Player player;
        private List<Command> commands;
        private int timeLeft = 150; // seconds
        private Timer timer;

        public Game()
        {
            player = new Player();
            commands = new List<Command>
            {
                new HelpCommand(),
                new SolveMysteryCommand(player),
                new ExamineblueCommand(),
                new UnlockCommand(player),
                new InventoryCommand(player),
                new EscapeCommand(player),
                new InspectRoomCommand(player),
            };

            timer = new Timer(CheckTime, null, 0, 1000); // Call every second
        }

        public void Start()
        {
            Console.WriteLine("You wake up in a dark, damp room. You must find a key to escape.");
            Console.WriteLine("To escape, you must complete a series of tasks, each one crucial for your survival. Pay attention to every detail and execute each task with caution.");
            Console.WriteLine("Type 'help' to see available commands.");

            try
            {

            while (true)
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
                    player.ReduceTime(10);
                    Console.WriteLine("Warning: Time decreased by 10 seconds due to command usage!");

                    return;
                }
            }

            Console.WriteLine("Unknown command. Type 'help' for assistance.");
        }

        private void CheckTime(object state)
        {
            timeLeft--;
            if (timeLeft <= 0)
            {
                Console.WriteLine("A terrifying shadow creeps towards you... You failed to escape in time.");
                Environment.Exit(0);
            }
            else if (timeLeft % 60 == 0)
            {
                Console.WriteLine($"You feel the pressure building 'tick-tock' ... only {timeLeft / 60} minutes left!");
            }
        }
    }
}

