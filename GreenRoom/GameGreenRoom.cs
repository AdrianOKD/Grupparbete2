


using Grupparbete2;


public  class GreenGame
{
    private InventoryPlayer inventoryPlayer;
    private List<GreenCommand> commands;
    public List<string> item = new List<string>();


    public GreenGame()
    {
        inventoryPlayer = new InventoryPlayer();
        commands = new List<GreenCommand>
        {
            new HelpGreenCommand(),
            new InventoryGreenCommand(inventoryPlayer),
            new EnterGreenRoomCommand(inventoryPlayer)

        };
    }
    

    public  void Start()
    {
        Console.WriteLine("Enter 'help'  to view the commando.");
    bool stopgame = true;
        while (stopgame)
        {
            Console.Write("> ");
            string input = Console.ReadLine()!;
            ExecuteCommand(input);
            if(input.Equals("stop") || input.Equals("exit"))
            {
                stopgame = false;
            }
        }
    }

    private  void ExecuteCommand(string input)
    {
        string[] parts = input.Split(' ', 2);
        string commandName = parts[0].ToLower();

        foreach (var command in commands)
        {
            if (command.Name == commandName)
            {
                command.Execute(parts.Length > 1 ? parts[1] : "");
                return;
            }
           
        }

    }
}




