using System;

class Program
{
    static void Main()
    {
        Story story = new Story();
        Commands commands = new Commands();

        story.StartStory();

        while (!commands.WiresCut)
        {
            Console.WriteLine("\nWhat would you like to do? (type 'help' for commands)");
            string action = Console.ReadLine()!.ToLower();
            commands.ExecuteCommand(action, story);
        }

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}