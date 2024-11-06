using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using GreenRooms;
using Grupparbete2;
using Grupparbete2.Commands;
using HorrorEscape;
using Pussel;
using Pussel.Commands;

namespace Grupparbete2
{
    public class MainRoom
    {
         private InventoryPlayer inventory;
        private List<Command> commands;
      

        public void MainRoomCommands()
        {
              inventory = new InventoryPlayer();
            commands = new List<Command>
            {
                new InventoryCommand(inventory),
            };
            

        }
         private void ExecuteCommand(string input)
        {
            if(input.Equals(null))
            {
                System.Console.WriteLine("Please write a new command");
                return;
            }
            string[] parts = input.Split(' ', 2);
            string commandName = parts[0].ToLower();
            
            foreach (var command in commands)
            {
                if (command.Name == commandName)
                {
                    command.Execute(parts.Length > 1 ? parts[1] : "");
                    return;
                }
            }
        }
        public static bool playerFailRoom = false;
       

        public void MainRoomStart()
        {
            MainRoomCommands();
            OrangeRoom orangeRoom = new OrangeRoom();
            GreenRoom greenRoom = new GreenRoom();
            RedPuzzle redPuzzle = new RedPuzzle();
            MasterControll blueRoom = new MasterControll();

            Story story = new Story();

            System.Console.WriteLine("You wake up in 'The main room'");

    
            



     while (!playerFailRoom)
            {
                Console.Write("> ");
                string input = Console.ReadLine()!;

                if (input.Equals("Choose Room", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Gör ett val. 1. Adrian. 2. Cedric. 3. Gustav, 4. Ismael 5. Filip");
                    input = Console.ReadLine();
                    if (int.TryParse(input, out int choice))
                    {
                        switch (choice)
                        {
                            case 1:
                                orangeRoom.OrangeRoomGame();
                                break;
                            case 2:
                                greenRoom.Start();
                                break;
                            case 3:
                                redPuzzle.Start();
                                break;
                            case 4:
                                blueRoom.Start();
                                break;
                            case 5:
                                story.StartStory();
                                break;
                            case 6:
                                // Check if the player has all keys to exit
                                // This logic needs to be implemented
                                break;
                            case 7:
                                Console.WriteLine("Weakling... Exiting Game");
                                playerFailRoom = false;
                                break;
                            default:
                                Console.WriteLine("Invalid choice. Please select a valid room.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a number.");
                    }
                }
                else
                {
                    ExecuteCommand(input);
                }
            }
        }
    }
}