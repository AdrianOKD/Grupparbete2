using System;

public class RedPuzzle
{
    public bool hasRedKey;
    private int jug3 = 0;
    private int jug5 = 0;
    private int jug8 = 0;
    private int maxJug3 = 3;
    private int maxJug5 = 5;
    private int maxJug8 = 8;

    // Time limit for the puzzle
    private int timeLimit = 180;
    private DateTime startTime;


    // Start the drowning trap puzzle
    public void Start()

    {
       // Introduction to the red room
        Console.WriteLine("You enter the red room and a foul, metallic but all-too-familiar scent fills your nostrils.");
        Console.WriteLine("Scanning the room for the source, the dim light only reveals a small platform in the middle, upon which three wooden jugs are placed.");
        Console.WriteLine("And as the door slams shut behind you, steel bars locking it firmly in place, the mechanical voice speaks to you once more... ");
        Console.ReadLine();
        Console.WriteLine("\"Welcome to my next little challenge for you, limbwielder. Here are three containers with 3, 5 and 8 metric liters in capacity respectively.");
        Console.WriteLine("Use your defunct, soon-to-be-rotting head organ to figure out a way to fill the largest jug to exactly the halfway mark.");
        Console.WriteLine("If you can guarantee the right amount without any room for filthy human guesswork, the path back towards safety will open up for you...\"");
        Console.ReadLine();
        Console.WriteLine("\"Something to fill them with? Patience, you worthless sack of meat! They were just about to join us...\"");
        Console.ReadLine();
        Console.WriteLine("You look down as slightly luminescent, crimson fluid flows up from beneath the floor tiles and soaks your bare feet.");
        Console.WriteLine("Its unnatural glow and warmth on your naked flesh offers you no solace. No, only its exact opposite.");
        Console.WriteLine("The smell inside the room intensifies to the point of being unbearable. You know what this is, but you refuse to even let the word enter your mind.");
        Console.ReadLine();
        Console.WriteLine("Meet the final offering of all who met their end here before you. Use the life essence they gifted in failure to stumble your own crooked way towards freedom.");
        Console.WriteLine("But make haste, skinwearer, lest you don't want to become a permanent element in this contraption.\"");
        Console.ReadLine();
        Console.WriteLine("As the mechanical voice chuckles coldly and fades into silence, you desperately wade through the thick liquid to the platform in the center.");
        Console.WriteLine("The vile fluid rises more quickly with each passing second. How many souls met their end here? Either way, time is not your ally.");
        Console.WriteLine("Your final sliver of confidence drains away as you now take notice of the room's agonizingly low ceiling.");
        Console.WriteLine("Within mere minutes, you will drown, another victim of the room's sanguine flood...");
        Console.ReadLine();

        startTime = DateTime.Now;

        Console.WriteLine("Focusing on the task at hand, You estimate that you have about 3 minutes before the room is entirely filled and your grim fate is sealed.");
        Console.WriteLine("You must measure exactly 4 liters in the 8-liter container to survive.");

        // Main game loop
        while (jug8 != 4 && !TimeIsUp())
        {
            DisplayState();
            string action = GetUserAction();
            HandleAction(action);

            if (jug8 == 4 && BloodInsanity())
            {

                Console.WriteLine("\nYou've successfully measured exactly 4 liters into the large jug!");
                Console.WriteLine("You hear a loud clonking sound and the liquid slowly starts draining out of the floor tiles as your panicked breaths echo through the room.");
                Console.ReadLine();
                Console.WriteLine("\"You like cutting things close. Perhaps you enjoyed the ambiance of the red room, or perhaps you simply wanted to soak in the hot bath with your new friends?");
                Console.WriteLine("Nevertheless, you're on the right track, meatsack. If your mind is still functional enough to perceive this, reach into the large container and take the key.\"");
                Console.ReadLine();
                Console.WriteLine("Your hands shake uncontrollably as you reach into the jug and where you could have sworn there was nothing before, you instead find a small red key.");
                Console.WriteLine("You clutch onto it tight enough to hurt and stumble back through the now open door to the main room, almost soaked from head to toe in blood.");
                Console.ReadLine();
                Console.WriteLine("Once outside, all the voices hit you at once. A cacophony of tormented bellows and cries of despair coming from inside the red room."); 
                Console.WriteLine("Even as you rush to close the door and silence the voices, they seem to be following you in whispering wails. Following the blood that now soaks your bones.");
                Console.ReadLine();
                Console.WriteLine("You fight desperately to keep hold of your sanity as cold mechanical laughter joins in with the voices.");
                hasRedKey = true;
                break;
            }

            else if (jug8 == 4)
            {              

                Console.WriteLine("\nYou've successfully measured exactly 4 liters into the large jug! You hear a loud clonking sound and the liquid slowly starts draining out of the floor tiles as you sigh in relief.");
                Console.ReadLine();
                Console.WriteLine("\"I really didn't expect you to succeed. A challenge worthy of a toddler perhaps, but I find that emotional creatures like yours can never be overestimated enough."); 
                Console.WriteLine("But you, meatpile, seem to be on the right track to freedom. Grab the key from the large container and move on to greater things.\"");
                Console.ReadLine();
                Console.WriteLine("As you reach into the jug, you're surprised to find a small key at the bottom. There must have been some hidden compartment to it.");
                Console.WriteLine("You grab the key and return to the main room, relieved to be one step closer to escaping this horrible place.");
                hasRedKey = true;
                break;
            }
        }

        // If time runs out
        if (jug8 != 4 && TimeIsUp())
        {
            Console.WriteLine("\nBlood has now filled the entire room. You try to hold on to your breath and claw your hands pathetically against the steel-barred door.");
            Console.WriteLine("It is obviously futile. Mechanical laughter is the last thing that fills your head as everything else fades into black.");
            Console.WriteLine("GAME OVER");
            Console.WriteLine("(Consider that subtraction could be your key to success)");
        }
    }

    // Show current jug state
    private void DisplayState()
    {
        Console.WriteLine("\nCurrent jug states:");
        Console.WriteLine($"3-liter jug: {jug3} liters");
        Console.WriteLine($"5-liter jug: {jug5} liters");
        Console.WriteLine($"8-liter jug: {jug8} liters");
        Console.WriteLine($"Time left: {timeLimit - (int)(DateTime.Now - startTime).TotalSeconds} seconds");
        Console.WriteLine("\nWhat will you do? (fill, pour, empty)");
    }

    // Function to get user action
    private string GetUserAction()
    {
        Console.Write("Enter command (e.g 'fill 5', 'pour 5 3', 'empty 3'): ");
        return Console.ReadLine()?.ToLower() ?? "";
    }

    // Function to handle user action
    private void HandleAction(string action)
    {
        string[] parts = action.Split(' ');
        if (parts.Length == 2 && parts[0] == "fill")
        {
            FillJug(int.Parse(parts[1]));
        }
        else if (parts.Length == 3 && parts[0] == "pour")
        {
            PourJug(int.Parse(parts[1]), int.Parse(parts[2]));
        }
        else if (parts.Length == 2 && parts[0] == "empty")
        {
            EmptyJug(int.Parse(parts[1]));
        }
        else
        {
            Console.WriteLine("Invalid command. Try again.");
        }
    }

    // Function to fill jug
    private void FillJug(int jug)
    {
        switch (jug)
        {
            case 3:
                jug3 = maxJug3;
                Console.WriteLine("You fill the 3-liter jug.");
                break;
            case 5:
                jug5 = maxJug5;
                Console.WriteLine("You fill the 5-liter jug.");
                break;
            case 8:
                jug8 = maxJug8;
                Console.WriteLine("You fill the 8-liter jug.");
                break;
            default:
                Console.WriteLine("Invalid jug.");
                break;
        }
    }

    // Function to pour from one jug to another
    private void PourJug(int fromJug, int toJug)
    {
        int pourAmount = 0;

        if (fromJug == 3 && toJug == 5)
        {
            pourAmount = Math.Min(jug3, maxJug5 - jug5);
            jug3 -= pourAmount;
            jug5 += pourAmount;
            Console.WriteLine($"You pour {pourAmount} liters from the 3-liter jug into the 5-liter jug.");
        }
        else if (fromJug == 5 && toJug == 3)
        {
            pourAmount = Math.Min(jug5, maxJug3 - jug3);
            jug5 -= pourAmount;
            jug3 += pourAmount;
            Console.WriteLine($"You pour {pourAmount} liters from the 5-liter jug into the 3-liter jug.");
        }
        else if (fromJug == 3 && toJug == 8)
        {
            pourAmount = Math.Min(jug3, maxJug8 - jug8);
            jug3 -= pourAmount;
            jug8 += pourAmount;
            Console.WriteLine($"You pour {pourAmount} liters from the 3-liter jug into the 8-liter jug.");
        }
        else if (fromJug == 5 && toJug == 8)
        {
            pourAmount = Math.Min(jug5, maxJug8 - jug8);
            jug5 -= pourAmount;
            jug8 += pourAmount;
            Console.WriteLine($"You pour {pourAmount} liters from the 5-liter jug into the 8-liter jug.");
        }
        else if (fromJug == 8 && toJug == 3)
        {
            pourAmount = Math.Min(jug8, maxJug3 - jug3);
            jug8 -= pourAmount;
            jug3 += pourAmount;
            Console.WriteLine($"You pour {pourAmount} liters from the 8-liter jug into the 3-liter jug.");
        }
        else if (fromJug == 8 && toJug == 5)
        {
            pourAmount = Math.Min(jug8, maxJug5 - jug5);
            jug8 -= pourAmount;
            jug5 += pourAmount;
            Console.WriteLine($"You pour {pourAmount} liters from the 8-liter jug into the 5-liter jug.");
        }
        else
        {
            Console.WriteLine("Invalid pour command. Try again.");
        }
    }

    // Function to empty jug
    private void EmptyJug(int jug)
    {
        switch (jug)
        {
            case 3:
                jug3 = 0;
                Console.WriteLine("You empty the 3-liter jug.");
                break;
            case 5:
                jug5 = 0;
                Console.WriteLine("You empty the 5-liter jug.");
                break;
            case 8:
                jug8 = 0;
                Console.WriteLine("You empty the 8-liter jug.");
                break;
            default:
                Console.WriteLine("Invalid jug.");
                break;
        }
    }

    // Check time limit and handle insanity

    private bool BloodInsanity()
    {
        double elapsedTime = (DateTime.Now - startTime).TotalSeconds;

        if (elapsedTime >= 120)
        {
            return true;
        }

        else
        {
            return false;
        }
    }
    private bool TimeIsUp()
    {
        return (DateTime.Now - startTime).TotalSeconds >= timeLimit;
    }

    public bool GetRedKey()
    {
        return hasRedKey = true;
    }
    
}
