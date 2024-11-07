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
        //1. Resultat

//    1. Vad är resultatet?

//    2. Hur ser det ut?

// 2. Planering

//    1. Hur planerade ni arbetet? Bygga fem rum på egen hand, sedan mergea och förbättra. 

//    2. Vem gjorde vad? varje person gjorde ett rum, 

//    3. Hur hanterade ni kommunikation? Avstämningar i dscord veckovis

// 3. Reflektion

//    1. Vad kan förbättras i arbete och planering? BÖRJA GEMENSAMT, planera fler fysiska träffar, kommunicera tydligt vid utebiliven närvaro i skolan och på discordmöten

//    2. Vad var bra gjort?

//    3. Vad tar ni med er till nästa projekt?


     

        public static bool hasOrangeKey = true;
        public static bool hasGreenKey = true;
        public static bool hasRedKey = true;
        public static bool hasBlueKey = true;
        public static bool hasYellowKey = false;

        public static bool playerFailRoom = false;
        public static bool playerFinishedGame = false;


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


     while (!playerFailRoom && !playerFinishedGame)
            {   Console.Clear();
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
                if(hasBlueKey && hasGreenKey && hasOrangeKey && hasRedKey && hasYellowKey)
                {
                    System.Console.WriteLine("You have all the keys.");

                }

                Console.Write("> ");
                string input = Console.ReadLine()!;

                if (input.Equals("Choose Room", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Which door do you enter?\n 1. Orange Door\n 2. Green Door\n 3. Red Door\n 4. Blue Door\n 5. Yellow Door\n 6. Unlock Exit Door");
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