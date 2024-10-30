public class EnterGreenRoomCommand : GreenCommand
{
    private PlayerG playerG;

    public EnterGreenRoomCommand(PlayerG playerG) : base (" green room")
    {
        this.playerG = playerG;
        this.Name = "room"; 
    }

    public override void Execute(string argument)
    {
        GreenRoom greenRoom = new GreenRoom(playerG);
        greenRoom.Execute(); // Call the execute method of GreenRoom
    }
}
