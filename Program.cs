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
      
        Cryptogram Cryptogram = new Cryptogram();
        OrangeRoom orangeRoom = new OrangeRoom();
        orangeRoom.OrangeRoomGame();

        //cedrics room
        GreenGame greengame = new GreenGame();
        greengame.Start();


        //  // Start the red room puzzle
        // {
        // RedPuzzle redPuzzle = new RedPuzzle();
        // redPuzzle.Start();

        // Console.WriteLine($"Has Red Key: {redPuzzle.GetRedKey()}");
        // Console.WriteLine("What manner of horrors awaits you in the next room?");
        // Console.WriteLine("You silently beg for this nightmare to end.");
        // }
       
    
       
       /*
        // Process input to execute commands
        bool ChooseRoom = true;
        int Val = 0;
        while (ChooseRoom)
        {
        switch(Val)
        {
            case 1: 
              orangeRoom.OrangeRoomGame();
              ChooseRoom = false;
            break;
            case 2: 
            break;
            case 3: 
            break;
            case 4: 
            break;
            case 5: 
            break;
            case 6: 
            break;
            default:
            break;
        }
      
        }
        
     */
    }
    
}
