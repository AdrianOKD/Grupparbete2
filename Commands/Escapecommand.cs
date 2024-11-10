using Grupparbete2;
using Pussel.Commands;

namespace HorrorEscape
{
    public class EscapeCommand : Command
    {
        private Player player;

        public EscapeCommand(Player player)
            : base("escape")
        {
            this.player = player;
        }

        public override void Execute(string argument)
        {
            if (!player.CanEscape())
            {
                Console.WriteLine(
                    "You feel unprepared. There are still important things you need to do before you can escape."
                );
            }
            else if (player.DoorUnlocked)
            {
                Console.WriteLine(
                    $"Congratulations! You use the key to unlock the {Colours.GREEN}door{Colours.NORMAL}."
                );

                MainRoom.hasBlueKey = true;
                MasterControll.insideBlueRoom = false;
            }
            else
            {
                Console.WriteLine(
                    "The door is locked. You need to unlock it before you can escape."
                );
            }
        }
    }
}
