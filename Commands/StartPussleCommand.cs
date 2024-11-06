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
            
            public StartOrangePussleCommand() : base("start")
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
}