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
            // if (string.IsNullOrEmpty(argument))
            // {
            //     Console.WriteLine("You need to specify an item to pick up");
            //     return;
            // }
            OrangeRoom orangeRoom = new OrangeRoom();

            if (argument.Contains("room"))
            {
                orangeRoom.Hint();
                return;
            }
            throw new NotImplementedException();
            //  string lowerArgument = argument.ToLower();
        }
    }
}
