using System;
using System.Collections.Generic;
using System.Threading;
using Grupparbete2;
using yellowRoom;

public class Story
{
    Commands commands = new Commands();

    private string[] storyLines = new string[]
    {
        "\nA cold chill runs down your spine as you realize you're trapped.",
        "The only source of light flickers above, casting eerie shadows on the walls.",
        "Suddenly, a voice echoes in the darkness, 'To escape, you must solve the mystery within.'",
        "You feel the walls closing in as you prepare to take action.",
    };

    public bool HasHammer { get; private set; }
    public bool ChestOpened { get; private set; }
    public bool InspectedRoom { get; private set; }
    public bool InspectedWires { get; private set; }
    public bool YellowCompleted { get; private set; } = false;
    private List<string> wireOrder = new List<string>
    {
        "blue",
        "green",
        "red",
        "yellow",
        "purple",
    };
    private int currentCutIndex = 0;

    public void StartStory()
    {
        Story story = new Story();
        Console.WriteLine(
            "A chilling wind sweeps through the doorway, beckoning you into the darkness beyond."
        );
        Console.WriteLine(
            "Do you dare to enter the room? Type 'yes' to proceed or 'no' to reconsider your choice."
        );

        string userChoice = Console.ReadLine()!.ToLower();

        if (userChoice == "yes")
        {
            Console.WriteLine(
                "You step into the dimly lit room, the door slamming shut behind you."
            );
        }
        else if (userChoice == "no")
        {
            Console.WriteLine(
                "As you hesitate, a shadow looms closer, whispering dark secrets in your ear."
            );
            Console.WriteLine(
                "You realize there's no escape from this fate. You step into the dimly lit room, the door slamming shut behind you."
            );
        }
        else
        {
            Console.WriteLine(
                "Your indecision is met with a sinister laugh, and the door slams shut behind you."
            );
        }
        foreach (string line in storyLines)
        {
            Console.WriteLine(line);
            Console.ReadLine();
        }
        Console.WriteLine("\nBefore you can proceed, you must solve a riddle:");
        Console.WriteLine(
            "I have a heavy head and a sturdy handle, I can build and break, but I'm not a candle. What am I?"
        );

        string riddleAnswer = Console.ReadLine()!.ToLower();

        while (riddleAnswer != "hammer")
        {
            Console.WriteLine("That's not correct. Try again:");
            riddleAnswer = Console.ReadLine()!.ToLower();
        }

        Console.WriteLine(
            "You notice a hammer in front of you. To pick it up, use 'pickup hammer'."
        );
        while (!Commands.WiresCut && !YellowCompleted)
        {
            Console.WriteLine("\nWhat would you like to do? (type 'help' for commands)");
            string action = Console.ReadLine()!.ToLower();
            commands.ExecuteCommand(action, this);
        }

    }

    public void PickupHammer()
    {
        if (!HasHammer)
        {
            HasHammer = true;
            Console.WriteLine("You take the hammer. It feels heavy in your hands.");
            Console.WriteLine("Perhaps you should inspect the room further to find a way out...");
        }
        else
        {
            Console.WriteLine("You already have the hammer.");
        }
    }

    public void InspectRoom()
    {
        if (!InspectedRoom)
        {
            Console.WriteLine("You look around the room and notice a mysterious chest.");
            InspectedRoom = true;
        }
        else if (ChestOpened && InspectedRoom)
        {
            Console.WriteLine(
                "You look around the room and see an electric box beside the exit door."
            );
            Console.WriteLine("To open the box, use the command 'open box'.");
            InspectedWires = true;
        }
        else if (ChestOpened)
        {
            Console.WriteLine(
                "You've already inspected the room. You see the electric box beside the door."
            );
        }
        else
        {
            Console.WriteLine("You've already inspected the room. You see a mysterious chest.");
        }
    }

    public void BreakChest()
    {
        if (HasHammer && !ChestOpened)
        {
            ChestOpened = true;
            Console.WriteLine(
                "You use the hammer to break open the chest. Inside, you find something useful for your escape."
            );
        }
        else if (ChestOpened)
        {
            Console.WriteLine("The chest is already broken open.");
        }
        else
        {
            Console.WriteLine("You need the hammer to break the chest.");
        }
    }

    public void CutWire(string wireColor)
    {
        if (InspectedWires)
        {
            if (wireOrder[currentCutIndex] == wireColor)
            {
                Console.WriteLine($"You cut the {wireColor} wire.");
                currentCutIndex++;
                if (currentCutIndex == 5)
                {
                    Console.WriteLine("\nYou cut the wires in the correct order. The room begins to shake, and the walls start to close in, but you see a glimmer of light in the distance.");
                    Console.WriteLine("Congratulations, you've escaped! You earned a 'Yellow Key'");
                    Console.ReadLine();
                    MainRoom.hasYellowKey = true;

                    YellowCompleted = true;
                    Commands.WiresCut = false;

                    MainRoom mainRoom = new MainRoom();
                    mainRoom.MainRoomStart();
                }
            }
            else
            {
                Console.WriteLine("\nYou cut the wrong wire... The room begins to fill with toxic gas...");
                Console.WriteLine("You slowly suffocate while contemplating your mistakes.");
                Console.ReadLine();
                Console.WriteLine("GAME OVER");
                Environment.Exit(0);
            }
        }
        else
        {
            Console.WriteLine("You haven't inspected the wires yet.");
        }
    }

    public void OpenBox()
    {
        if (InspectedWires)
        {
            Console.WriteLine("You open the electric box. There's a note inside. :");
            Console.WriteLine("- You'll need to cut the wires in the correct order to get out.");
            Console.WriteLine(
                "- The first wire is often associated with calmness and the vastness of the sky."
            );
            Console.WriteLine(
                "- The second wire symbolizes life and nature, commonly found in gardens."
            );
            Console.WriteLine(
                "- The third wire reminds you of a fruit that is often mistaken for a vegetable, frequently seen in salads."
            );
            Console.WriteLine(
                "- The fourth wire is bright and cheerful, linked to a fruit that is both sour and refreshing."
            );
            Console.WriteLine(
                "- The fifth wire is an elegant shade reminiscent of a fragrant flower often found in bouquets."
            );
            Console.WriteLine("Can you cut the wires in the correct order using those hints?");
        }
        else
        {
            Console.WriteLine("You need to inspect the room to find the electric box first .");
        }
    }
}
