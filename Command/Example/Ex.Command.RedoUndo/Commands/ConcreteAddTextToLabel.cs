namespace Ex.Command.RedoUndo.Commands;

public class ConcreteAddTextToLabel : Command
{
    public ConcreteAddTextToLabel(ReceiverEditText receiverEditText) : base(receiverEditText)
    {
    }

    public override string Execute(string input)
    {
        CurrentInput = input;
        return _receiverEditText.AddText(input);
    }

    public override string UnExecute(string input)
    {
        CurrentInput = input;
        return _receiverEditText.RemoveText(input);
    }
}