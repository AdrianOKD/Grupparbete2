public abstract class GreenCommand
{
    public string Name { get; protected set; }

    protected GreenCommand(string name)
    {
        Name = name;
    }

    public abstract void Execute(string argument);
}

public class HelpGreenCommand : GreenCommand
{
    public HelpGreenCommand() : base("help") { }

    public override void Execute(string argument)
    {
        Console.WriteLine("List of commands:");
        Console.WriteLine("- Type 'help' to View the menu");
        Console.WriteLine("- Type 'room' To enter the green room  ");
        Console.WriteLine("- Type 'inventory' check if you have the key");
        Console.WriteLine("- Type 'Exit' or 'stop' to exit the green room");
    }
}



public class InventoryGreenCommand : GreenCommand
{
    private PlayerG playerG;

    public InventoryGreenCommand(PlayerG playerG) : base("inventory")
    {
        this.playerG = playerG;
    }

    public override void Execute(string argument)
    {
        // greenRoom.key = "greenkey";
        
         playerG.ShowInventory();
    }
}

