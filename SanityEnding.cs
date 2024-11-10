using System;
using Grupparbete2;
using yellowRoom;

public class SanityEnding
{
    public void Start()

    {
        Console.WriteLine($"{Colours.RED}As the final lock falls to the ground, you hear the delightful chirping of spring birds from beyond.");
        Console.WriteLine("You smile at the sound of nature as you hurriedly push open the exit door, your heart now racing with the anticipation of freedom.");
        Console.ReadLine();
        Console.WriteLine("Hope!");
        Console.ReadLine();
        Console.WriteLine("...");
        Console.ReadLine();
        Console.WriteLine("Was there ever hope?...");
        Console.ReadLine();
        Console.WriteLine("Instead of the fresh air and gentle breeze you expected, you find yourself staring at an empty square cell.");
        Console.WriteLine("In the center, a blanketless hard steel bed sits stark against the cold, barren floor.");
        Console.ReadLine();
        Console.WriteLine("The harsh, fluorescent lights flicker overhead, casting unsettling shadows on the once sterile white walls.");
        Console.WriteLine("Now those walls bear the scars of lunacy - scratches, scribbles, and smearings that foretell of a mind fractured far beyond the breaking point.");
        Console.ReadLine();
        Console.WriteLine("\"Ah, my dear meatsack, there you are! Splendid job on those trials back there. I whole-circuitedly rooted for you...\" the familiar voice declares, dripping with disdainful sarcasm.");
        Console.ReadLine();
        Console.WriteLine("\"But I must apologize for this mix-up! Dear, oh dear...\"");
        Console.ReadLine();
        Console.WriteLine("\"Oh, but it all makes sense to me now! This must have been your previous room. Fear not! The real exit awaits you.\"");
        Console.ReadLine();
        Console.WriteLine("You almost hear the weaving of your own fate as the door closes behind you with a click.");
        Console.WriteLine("\"Does this mechanical voice know no bounds to its cruelty? To frighten you like this?\" you think to yourself.");
        Console.ReadLine();
        Console.WriteLine("You turn your head just as the door swings open once again...");
        Console.ReadLine();
        Console.WriteLine("Revealing a room as imposingly bleak as the last, but devoid of filth and furnishing both.");
        Console.WriteLine("Even an unassuming steel bed would have afforded some slight comfort, but alas, nothing to break the deafening monotony...");
        Console.ReadLine();
        Console.WriteLine("Your heart sinks into a bottomless pit as the voice continues, \"There! Now there is just a minor inconvenience on the horizon.");
        Console.WriteLine("You'll need to wait for your turn.\"");
        Console.ReadLine();
        Console.WriteLine("The mechanical voice chuckles as it announces, \"Today there are... oh, let's take a look...");
        Console.ReadLine();
        Console.WriteLine("38,389,273 worthless excrement-pilers ahead of you in line...\"");
        Console.ReadLine();
        Console.WriteLine("Before your mind's eye you see a line stretching infinitely into the darkness, a stream of shadows timidly shuffling forward.");
        Console.WriteLine("Each one a lost soul like yours, shackled to their illusions of hope, dreaming of respite from the agony of their solitude.");
        Console.ReadLine();
        Console.WriteLine("\"But don't worry! I am certain to be seeing you again very soon, for your next set of trials.\"");
        Console.ReadLine();
        Console.WriteLine("\"Have an utmost exquisite stay here, fleshpile! Oh, and try not to yell as much during this visit, will you?\"");
        Console.ReadLine();
        Console.WriteLine("As the mechanical laughter bombards your mind and fades for the final time, your own gasping sobs fill the void.");
        Console.WriteLine("You drop onto the floor as your legs give out, your own distorted memories now starting to come flooding back...");
        Console.ReadLine();
        Console.WriteLine("Endless cycles of despair and torment. Countless trials and brushes with death and with grief and betrayal.");
        Console.WriteLine("A memory flashes - the cheery laugh of a loved one, immediately twisted into a scene of abominable horror!");
        Console.ReadLine();
        Console.WriteLine("\"NO!\", the bouncing echo of your scream is your only friendly inmate in this particular prison.");
        Console.ReadLine();
        Console.WriteLine("What you wouldn't give to forget it all!");
        Console.ReadLine();
        Console.WriteLine("But like the others, you must await your turn to escape this reality, before the memories devour what little remains inside.");
        Console.ReadLine();
        Console.WriteLine("...");
        Console.ReadLine();
        Console.WriteLine("And so you wait, an unwitting participant in an endless loop");
        Console.WriteLine("Forever haunted by the hope that never was");
        Console.ReadLine();
        Console.WriteLine($"{Colours.BOLD}{Colours.GREY}THE END{Colours.NORMAL}{Colours.NOBOLD}");

        MainRoom.playerFinishedGame = true;
        Commands.WiresCut = true;
    }

}