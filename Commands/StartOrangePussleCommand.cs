using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pussel.Commands;
using Pussel;

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
}