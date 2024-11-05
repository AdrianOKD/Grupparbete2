using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grupparbete2;
using HorrorEscape;
using Pussel;

namespace Grupparbete2
{
    public class MainRoom
    {
        public void MainRoomStart()
        {
            OrangeRoom orangeRoom = new OrangeRoom();
            GreenGame greengame = new GreenGame();
            RedPuzzle redPuzzle = new RedPuzzle();
            Game blueGame = new Game();
            Story story = new Story();
            
            System.Console.WriteLine("You wake up in 'The main room'");

            bool ChooseRoom = true;

            while (ChooseRoom)
            {
                System.Console.WriteLine(
                    "Gör ett val. 1. Adrian. 2 . Cerdric. 3. Gustav, 4. Ismael 5. Filip"
                );
                string input = Console.ReadLine()!;
                int.TryParse(input, out int choice);
                switch (choice)
                {
                    case 1:
                        orangeRoom.OrangeRoomGame();
                        break;
                    case 2:
                        greengame.Start();
                        break;
                    case 3:
                        redPuzzle.Start();
                        break;
                    case 4:
                        blueGame.Start();
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
