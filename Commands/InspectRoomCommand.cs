using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pussel.Commands;
using HorrorEscape;

namespace Grupparbete2.Commands
{
  public class InspectRoomCommand : Command
    {
        private Player player;

        public InspectRoomCommand(Player player) : base("inspect") { }

        public override void Execute(string argument)
        {
            Console.WriteLine("You look around the room carefully... The walls are damp, and the smell of mold fills the air.");
            Console.WriteLine("Something feels off about the floor. Perhaps there's something hidden beneath?");
        }

    }
}