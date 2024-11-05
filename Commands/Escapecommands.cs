
using System;
using Pussel;
using Pussel.Commands;

namespace HorrorEscape
{
    public class EscapeCommand : Command
    {
        private Player player;
        private Player player1;

        public EscapeCommand(Player player) : base("escape")
        {
            this.player = player;
        }

      
        public override void Execute(string argument)
        {
            if (!player.CanEscape())
            {
                Console.WriteLine("You feel unprepared. There are still important things you need to do before you can escape.");
            }
            else if (player.DoorUnlocked)
            {
                Console.WriteLine("You use the key to unlock the door. Run! You are free!");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("The door is locked. You need to unlock it before you can escape.");
            }
        }
    }
}


