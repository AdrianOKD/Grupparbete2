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
     

        public static bool hasOrangeKey = false;
        public static bool hasGreenKey = false;
        public static bool hasRedKey = false;
        public static bool hasBlueKey = false;
        public static bool hasYellowKey = false;


        public static bool playerFailRoom = false;


        public void MainRoomStart()
        {
            OrangeRoom orangeRoom = new OrangeRoom();
            GreenRoom greenRoom = new GreenRoom();
            RedRoom redRoom = new RedRoom();
            MasterControll blueRoom = new MasterControll();
            SanityEnding sanityEnding = new SanityEnding();

            Story story = new Story();

            System.Console.WriteLine("You wake up in 'The main room'");
            System.Console.WriteLine("System: Write Choose Room");


     while (!playerFailRoom)
            {
                System.Console.WriteLine("You are in main room");
                if (hasOrangeKey)
                {
                Console.WriteLine("Orange Key");
                }
                if (hasGreenKey)
                {
                Console.WriteLine("Green Key");
                }
                if (hasRedKey)
                {
                Console.WriteLine("Red Key");
                }
                if (hasBlueKey)
                {
                Console.WriteLine("Blue Key");
                }
                if (hasYellowKey)
                {
                Console.WriteLine("Yellow key");
                }

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
                            if (hasOrangeKey == false)
                            {
                               orangeRoom.OrangeRoomGame(); 
                            }
                            else
                            {
                                System.Console.WriteLine("The door wont budge");
                            }
                                break;
                            case 2:
                             if (hasGreenKey == false)
                            {
                              greenRoom.Start();
                            }
                            else
                            {
                                System.Console.WriteLine("The door wont budge");
                            }
                                break;
                            case 3:
                             if (hasRedKey == false)
                            {
                              redRoom.Start();
                            }
                            else
                            {
                                System.Console.WriteLine("The door wont budge");
                            }
                                break;
                            case 4:
                             if (hasBlueKey == false)
                            {
                               blueRoom.Start();
                            }
                            else
                            {
                                System.Console.WriteLine("The door wont budge");
                            }
                                break;
                            case 5:
                             if (hasYellowKey == false)
                            {
                              story.StartStory();
                            }
                            else
                            {
                                System.Console.WriteLine("The door wont budge");
                            }
                                
                                break;
                            case 6:
                            if(hasBlueKey == true && hasGreenKey == true && hasOrangeKey == true && hasRedKey == true && hasYellowKey)
                            {
                                sanityEnding.Start();

                            }
                            else
                            {
                                System.Console.WriteLine("You dont have all the required keys..");
                            }
                                break;
                            case 7:
                                Console.WriteLine("Weakling... you fall into a deep slumber..");
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
            }
        }
    }
}