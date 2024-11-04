using Grupparbete2;
using HorrorEscape;

namespace Pussel;


class Program
{
    static void Main(string[] args)
    {
       
        MainRoom mainRoom = new MainRoom();

        System.Console.WriteLine(@"_    ____ ____ ___    _ _ _ _ ___ _  _ _ _  _ 
|    |  | [__   |     | | | |  |  |__| | |\ | 
|___ |__| ___]  |     |_|_| |  |  |  | | | \| 
                                              ");


      mainRoom.MainRoomStart();

      
    }
}
