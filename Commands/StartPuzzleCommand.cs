using GreenRooms;
using Pussel;
using Pussel.Commands;

namespace Grupparbete2.Commands
{
    public class StartOrangePuzzleCommand : Command
    {
        public StartOrangePuzzleCommand()
            : base("solve") { }

        public override void Execute(string argument)
        {
            if (argument.Contains("puzzle"))
            {
                OrangeRoom orangeRoom = new OrangeRoom();
                orangeRoom.StartPuzzle();
                return;
            }
        }
    }

    public class StartGreenPussleCommand : Command
    {
        public StartGreenPussleCommand()
            : base("green") { }

        public override void Execute(string argument)
        {
            if (argument.Contains("room"))
            {
                GreenRoom greenRoom = new GreenRoom();
                greenRoom.Execute();
                return;
            }
        }
    }

    public class StartRedPuzzleCommand : Command
    {
        public StartRedPuzzleCommand()
            : base("start") { }

        public override void Execute(string argument)
        {
            if (argument == "puzzle")
            {
                RedRoom redRoom = new RedRoom();
                redRoom.StartPuzzle();
                return;
            }
            else
            {
                Console.WriteLine("To start the puzzle, type 'start puzzle'.");
            }
        }
    }
}
