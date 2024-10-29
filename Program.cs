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
