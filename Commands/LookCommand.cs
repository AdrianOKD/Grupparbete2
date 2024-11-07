using Pussel;
using Pussel.Commands;

namespace Grupparbete2.Commands
{
    public class LookOrangeCommand : Command
    {
        public LookOrangeCommand()
            : base("look") { }

        public override void Execute(string argument)
        {
            if (string.IsNullOrEmpty(argument))
            {
                Console.WriteLine("Write the name of what you want to look at.");
                return;
            }
            string lowerArgument = argument.ToLower();
            if (lowerArgument.Contains("around"))
            {
                OrangeRoom orangeRoom = new OrangeRoom();
                orangeRoom.LookAround();
                return;
            }
          
        }
    }
}
