namespace Pussel;

//Vad som behövs, Cryptogram.
//Let the user type in the coded message,
//Keep track of which letters might match with which
//Count how ofter each letter appears ni the message

//Tips how to decipher, Look at how often letters are used, check for common word patterns.

//Display what is happpeneing, make array or something to show the random lettters.
//Maybe make a count on how many tries the user has.

class Program
{
    static void Main(string[] args)
    {
        OrangeRoom orangeRoom = new OrangeRoom();

        //cedrics room
        GreenGame greengame = new GreenGame();
        RedPuzzle redPuzzle = new RedPuzzle();

        //  // Start the red room puzzle
        // {
        // RedPuzzle redPuzzle = new RedPuzzle();
        // redPuzzle.Start();

        // Console.WriteLine($"Has Red Key: {redPuzzle.GetRedKey()}");
        // Console.WriteLine("What manner of horrors awaits you in the next room?");
        // Console.WriteLine("You silently beg for this nightmare to end.");
        // }
        System.Console.WriteLine(@"_    ____ ____ ___    _ _ _ _ ___ _  _ _ _  _ 
|    |  | [__   |     | | | |  |  |__| | |\ | 
|___ |__| ___]  |     |_|_| |  |  |  | | | \| 
                                              ");

        bool ChooseRoom = true;
        
        while (ChooseRoom)
        {
            System.Console.WriteLine("Gör ett val. 1. Adrian. 2 . Cerdric. 3. Gustav");
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
                    break;
                case 5:
                    break;
                case 6:
                    //koda för utgången, kolla om spelaren har alla nycklar, om den har det, öppna dörren spela ending, annars berätta för användaren att hen inte har alla nycklar.
                    break;
                case 7:
                    System.Console.WriteLine("Exiting Game");
                    ChooseRoom = false;
                    break;
                default:
                    break;
            }
        }
    }
}
