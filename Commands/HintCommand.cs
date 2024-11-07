using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pussel;
using Pussel.Commands;

namespace Grupparbete2.Commands
{
    public class HintOrangeCommand : Command
    {
        public HintOrangeCommand()
            : base("hint") { }

        public override void Execute(string argument)
        {
          
            OrangeRoom orangeRoom = new OrangeRoom();
            orangeRoom.Hint();
            return;
          
        }
    }
}
