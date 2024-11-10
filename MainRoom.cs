using GreenRooms;
using HorrorEscape;
using Pussel;

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
        public static bool playerFinishedGame = false;

        public void MainRoomStart()
        {
            OrangeRoom orangeRoom = new OrangeRoom();
            GreenRoom greenRoom = new GreenRoom();
            RedRoom redRoom = new RedRoom();
            MasterControll blueRoom = new MasterControll();
            Story story = new Story();
            SanityEnding sanityEnding = new SanityEnding();


            while (!playerFailRoom && !playerFinishedGame)
            {
                Console.Clear();
                System.Console.WriteLine($"You are in the main room. '{Colours.CYAN}Choose Room{Colours.NORMAL}' to proceed.");

                if (hasBlueKey && hasGreenKey && hasOrangeKey && hasRedKey && hasYellowKey)
                {
                    System.Console.WriteLine($"{Colours.GREY}You have all the keys.{Colours.NORMAL}");
                }

                Console.Write("> ");
                string input = Console.ReadLine()!;

                if (input.Equals("Choose Room", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("");
                    Console.WriteLine(

                        $"Which door do you enter?\n {Colours.ORANGE}1. Orange Door{Colours.NORMAL}\n {Colours.GREEN}2. Green Door{Colours.NORMAL}\n {Colours.RED}3. Red Door{Colours.NORMAL}\n {Colours.BLUE}4. Blue Door{Colours.NORMAL}\n {Colours.YELLOW}5. Yellow Door{Colours.NORMAL} \n {Colours.GREY}6. Locked Door{Colours.NORMAL}"
                    );
                    input = Console.ReadLine() ?? "";
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
                                    System.Console.WriteLine("The door wont budge...\n");
                                    System.Console.WriteLine("Press any key to continue");
                                    Console.ReadKey();
                                }
                                break;
                            case 2:
                                if (hasGreenKey == false)
                                {
                                    greenRoom.Start();
                                }
                                else
                                {
                                    System.Console.WriteLine("The door wont budge...\n");
                                    System.Console.WriteLine("Press any key to continue");
                                    Console.ReadKey();
                                }
                                break;
                            case 3:
                                if (hasRedKey == false)
                                {
                                    redRoom.Start();
                                }
                                else
                                {
                                    System.Console.WriteLine("The door wont budge...\n");
                                    System.Console.WriteLine("Press any key to continue");
                                    Console.ReadKey();
                                }
                                break;
                            case 4:
                                if (hasBlueKey == false)
                                {
                                    blueRoom.Start();
                                }
                                else
                                {
                                    System.Console.WriteLine("The door wont budge...\n");
                                    System.Console.WriteLine("Press any key to continue");
                                    Console.ReadKey();
                                }
                                break;
                            case 5:
                                if (hasYellowKey == false)
                                {
                                    story.StartStory();
                                }
                                else
                                {
                                    System.Console.WriteLine("The door wont budge...\n");
                                    System.Console.WriteLine("Press any key to continue");
                                    Console.ReadKey();
                                }

                                break;
                            case 6:
                                if (
                                    hasBlueKey
                                    && hasGreenKey
                                    && hasOrangeKey
                                    && hasRedKey
                                    && hasYellowKey
                                )
                                {
                                    sanityEnding.Start();
                                }
                                else
                                {
                                    System.Console.WriteLine(
                                        "You dont have all the required keys..."
                                    );
                                    Console.ReadKey();
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
