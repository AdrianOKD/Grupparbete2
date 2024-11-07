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
            //   if (string.IsNullOrEmpty(argument))
            // {
            //     Console.WriteLine("What do you want kind of hint");
            //     return;
            // }
            // else{
            OrangeRoom orangeRoom = new OrangeRoom();
            orangeRoom.Hint();
            return;
            //  }


            //throw new NotImplementedException();
            //  string lowerArgument = argument.ToLower();
        }
    }
}
