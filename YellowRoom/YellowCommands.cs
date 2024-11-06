using System;

namespace yellowRoom
{
public class Commands
{
    public bool WiresCut { get; private set; }

    public void ExecuteCommand(string action, Story story)
        {
        string[] parts = action.Split(' ');
        string verb = parts[0].ToLower();

        switch (verb)
        {
            case "pickup":
                if (parts.Length > 1 && parts[1].ToLower() == "hammer")
                {
                    story.PickupHammer();
                }
                else
                {
                    Console.WriteLine("Invalid command. Try 'pickup hammer'.");
                }
                break;
            case "inspect":
                if (parts.Length > 1 && parts[1].ToLower() == "room")
                {
                    story.InspectRoom();
                }
                else
                {
                    Console.WriteLine("Invalid command. Try 'inspect room'.");
                }
                break;
            case "break":
                if (parts.Length > 1 && parts[1].ToLower() == "chest")
                {
                    story.BreakChest();
                }
                else
                {
                    Console.WriteLine("Invalid command. Try 'break chest'.");
                }
                break;
            case "open":
                if (parts.Length > 1 && parts[1].ToLower() == "box")
                {
                    story.OpenBox();
                }
                else
                {
                    Console.WriteLine("Invalid command. Try 'open box'.");
                }
                break;
            case "cut":
                if (parts.Length > 1)
                {
                    story.CutWire(parts[1].ToLower());
                }
                else
                {
                    Console.WriteLine("Invalid command. Try 'cut <color>'.");
                }
                break;
            default:
            Console.WriteLine("Invalid command. Try 'Help'.");
                break;
            case "help":
                ShowHelp(story);
                break;
            case "exit":
                ExitGame();
                break;
        }
    }

    private void ShowHelp(Story story)
    {
        Console.WriteLine("Available commands:");
        Console.Write ("- inspect: Look around the room.");
        if (!story.HasHammer)
        {
            Console.WriteLine("\n- pickup hammer: Pick up the hammer in front of you.");
        }
        if (story.InspectedWires)
        {
            Console.WriteLine("\n- open box: Open the electric box.");
        }
        if (story.InspectedRoom &&  !story.ChestOpened)
        {
            Console.WriteLine("\n- break chest: Break open the chest you found.");
        }
        if (story.InspectedWires)
        {
            Console.WriteLine("\n- cut <color>: Cut the wires.");
        }
        Console.WriteLine("\n- exit: Give up and sit in the darkness.");
    }
    private void ExitGame()
    {
        Console.WriteLine("You thought it was that easy to escape? It hurts you as a mysterious creature emerges from the shadows and rips one of your eyes out!");
        Console.WriteLine("Your vision worsens, and you realize there’s no easy way out. The darkness closes in around you, but you’re still trapped here.");
    }

    private void CutWires(Story story)
    {
        if (story.ChestOpened)
        {
            Console.WriteLine("You see 5 wires: red, blue, green, yellow, and purple. You need to cut them in the correct order to escape.");
            Console.WriteLine("Enter the order of the wires (e.g., 'red blue green yellow purple'): ");
            string input = Console.ReadLine()!;
            string[] wires = input.Split(' ');
            if (wires.Length == 5 && wires[0] == "blue" && wires[1] == "green" && wires[2] == "red" && wires[3] == "yellow" && wires[4] == "purple")
            {
                WiresCut = true;
                Console.WriteLine("You cut the wires in the correct order. The room begins to shake, and the walls start to close in, but you see a glimmer of light in the distance.");
                Console.WriteLine("Congratulations, you've escaped! You earned a 'Yellow Key'");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("You cut the wires in the wrong order. The room begins to shake, and the walls start to close in. You realize you need to try again.");
            }
        }
        else
        {
            Console.WriteLine("You need to break the chest first.");
        }
    }
}
}