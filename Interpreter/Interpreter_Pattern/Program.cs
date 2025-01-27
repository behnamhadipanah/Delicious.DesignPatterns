// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Context context = new Context();
List<AbstractExpression> list = new List<AbstractExpression>();
list.Add(new TerminalExpression());
list.Add(new NonTerminalExpression());
list.Add(new TerminalExpression());
list.Add(new TerminalExpression());
list.Add(new TerminalExpression());
list.Add(new NonTerminalExpression());

foreach (var item in list)
{
    item.Interpret(context);
}
Console.Read();