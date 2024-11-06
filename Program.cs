using Grupparbete2;
namespace Pussel;
class Program
{
    static void Main(string[] args)
    {

        MainRoom mainRoom = new MainRoom();

        Console.WriteLine($"{Colours.RED}");
        System.Console.WriteLine(@"_    ____ ____ ___    _ _ _ _ ___ _  _ _ _  _ 
|    |  | [__   |     | | | |  |  |__| | |\ | 
|___ |__| ___]  |     |_|_| |  |  |  | | | \| 
                                              ");
        Console.WriteLine($"{Colours.NORMAL}");
        mainRoom.MainRoomStart();
    }
}
