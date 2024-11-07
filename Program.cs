using Grupparbete2;
namespace Pussel;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        MainRoom mainRoom = new MainRoom();

        Console.WriteLine($"{Colours.RED}");
        System.Console.WriteLine(@"_    ____ ____ ___    _ _ _ _ ___ _  _ _ _  _ 
|    |  | [__   |     | | | |  |  |__| | |\ | 
|___ |__| ___]  |     |_|_| |  |  |  | | | \| 
                                              ");
        Console.WriteLine("You wake up alone in a cold, sterile room, groggy and with no memory of who you are or how you got there.");
        Console.WriteLine("The room is empty, except for the numerous doors around you, each in a different colour.");
        Console.WriteLine();
        Console.WriteLine("A mechanical voice breaks through the deafening silence...");
        Console.WriteLine();
        Console.WriteLine("\"Rise and shine, you pathetic worm. It's your turn next... If freedom is your desire, then follow my instructions, get it?");
        Console.WriteLine("The gate to your salvation is locked. You will have to survive the trials inside these other rooms in order to get the keys you need.");
        Console.WriteLine($"Now... Show me just how far you are willing to go to escape this place...\"{Colours.NORMAL}");
        Console.ReadLine();
        mainRoom.MainRoomStart();
    }
}
