namespace Ex.Command.RedoUndo.Commands;

public class InvokerEditText
{
    private ReceiverEditText _editText;
    private List<Command> commands;
    private int currentCommand = 0;
    public InvokerEditText()
    {
        _editText = new ReceiverEditText();
        commands = new List<Command>();
    }
    public string ExecuteCommand(string input)
    {
        Command command = new ConcreteAddTextToLabel(_editText);
        var result= command.Execute(input);
        commands.Add(command);
        currentCommand++;

        return result;

    }

    public string Undo()
    {
        Command command = commands[--currentCommand];
        return  command.UnExecute(command.CurrentInput);

    }


    public string Redo()
    {
        Command command = commands[currentCommand++];
        return command.Execute(command.CurrentInput);

    }
}