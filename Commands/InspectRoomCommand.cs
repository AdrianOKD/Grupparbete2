using HorrorEscape;
using Pussel.Commands;

namespace Grupparbete2.Commands
{
    public class InspectRoomCommand : Command
    {
        private Player player;

        public InspectRoomCommand(Player player)
            : base("inspect")
        {
            this.player = player;
        }

        public override void Execute(string argument)
        {
            Console.WriteLine(
      "You scan the room carefully, noting the dampness that clings to the walls. The air smells faintly of decay, a sure sign that this place has been abandoned for a long time."
  );
            Console.WriteLine(
                $"Your attention shifts to the floor. It seems a bit off—one spot doesn't feel right underfoot. {Colours.ORANGE}Maybe there's something secreted away below?{Colours.NORMAL}"
            );

        }
    }
}
