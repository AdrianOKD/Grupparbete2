using System;
using Pussel.Commands;

namespace HorrorEscape
{
    public class UnlockCommand : Command
    {
        private Player player;
        private const string Code = "473"; // Sifferkoden för att låsa upp dörren

        public UnlockCommand(Player player) : base("unlock")
        {
            this.player = player;
        }

        public override void Execute(string argument)
        {
            if (argument == Code)
            {
                Console.WriteLine("You enter the code '473'... The lock clicks open with a satisfying sound. The door is now unlocked!");
                player.DoorUnlocked = true; // Ny egenskap som indikerar att dörren är upplåst
            }
            else
            {
                Console.WriteLine("The code is incorrect. You hear an unsettling click, as if something's about to happen.");
            }
        }
    }
}
