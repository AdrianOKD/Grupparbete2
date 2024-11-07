using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pussel.Commands;
using Pussel;
using GreenRooms;

namespace Grupparbete2.Commands
{
     public class StartOrangePussleCommand : Command
        {
            
            public StartOrangePussleCommand() : base("solve")
            {
            }

        public override void Execute(string argument)
        {
            if (argument.Contains("pussle"))
            {
                OrangeRoom orangeRoom = new OrangeRoom();
                orangeRoom.StartPussle();
                return;

            }
        }
    }

    public class StartGreenPussleCommand : Command
    {

        public StartGreenPussleCommand() : base("green")
        {
        }

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
        public StartRedPuzzleCommand() : base("start")
        {
        }
        
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