using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pussel.Commands;

namespace Grupparbete2.Commands
{
     public class InteractCommand : Command
    {
        public InteractCommand(string name)
            : base(name) { }

        public override void Execute(string argument)
        {
            throw new NotImplementedException();
          //  string lowerArgument = argument.ToLower();
        }
    }
}