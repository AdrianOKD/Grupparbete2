
using Grupparbete2;

public class EnterGreenRoomCommand : GreenCommand
{
    // private PlayerG playerG;
    private InventoryPlayer inventoryPlayer;

    public EnterGreenRoomCommand(InventoryPlayer inventoryPlayer) : base (" green room")
    {
        this.inventoryPlayer = inventoryPlayer;
        this.Name = "room"; 
    }

    public override void Execute(string argument)
    {

        GreenRoom greenRoom = new GreenRoom(inventoryPlayer);
        greenRoom.Execute(); // Call the execute method of GreenRoom
    }
}
