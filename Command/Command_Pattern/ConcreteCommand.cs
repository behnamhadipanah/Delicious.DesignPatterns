public class ConcreteCommand : Command
{
    public ConcreteCommand(Receiver receiver) : base(receiver)
    {
    }

    public override void Execute()
    {
        _receiver.Action();
    }
}

public class Invoker
{
    private Command _command;
    //private List<Command> commands;   ComplexInvoker
    public void SetCommand(Command command)
    {
        _command = command;
    }

    public void ExecuteCommand()
    {
        _command.Execute();
    }
}