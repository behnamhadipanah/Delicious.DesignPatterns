// See https://aka.ms/new-console-template for more information
public class NonTerminalExpression : AbstractExpression
{
    public override void Interpret(Context context)
    {
        System.Console.WriteLine("Called NonTerminal.Interpret()");
    }
}