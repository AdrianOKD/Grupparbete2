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
        public void MainRoomStart()
        {
            OrangeRoom orangeRoom = new OrangeRoom();
            GreenRoom greenRoom = new GreenRoom();
            RedPuzzle redPuzzle = new RedPuzzle();
            MasterControll blueRoom = new MasterControll();

            Story story = new Story();

            System.Console.WriteLine("You wake up in 'The main room'");

            bool ChooseRoom = true;

            while (ChooseRoom)
            {
                System.Console.WriteLine(
                    "Gör ett val. 1. Adrian. 2 . Cedric. 3. Gustav, 4. Ismael 5. Filip"
                );

                string input = Console.ReadLine()!;
                int.TryParse(input, out int choice);
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
                        //koda för utgången, kolla om spelaren har alla nycklar, om den har det, öppna dörren spela ending, annars berätta för användaren att hen inte har alla nycklar.
                        break;
                    case 7:
                        System.Console.WriteLine("Weakling...Exiting Game");
                        ChooseRoom = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
