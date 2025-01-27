Console.WriteLine("Hello, World!");


List<IAbstractExpression> abstractExpressions = new List<IAbstractExpression>();
Context context = new Context(DateTime.Now);


while (true)
{
    System.Console.WriteLine("Enter Your Format?");
    context.Expression = Console.ReadLine();
    string[] formats = context.Expression.Split(' ');
    foreach (var item in formats)
    {
        if (item == "YYYY")
            abstractExpressions.Add(new YearExpression());
        else if (item == "YY")
            abstractExpressions.Add(new YearShortExpression());
        if (item == "MM")
            abstractExpressions.Add(new MonthExpression());
        if (item == "dd")
            abstractExpressions.Add(new DayExpression());
    }

    foreach (var item in abstractExpressions)
    {
        item.Interpret(context);
    }

    System.Console.WriteLine(context.Expression);
    Console.Read();

}
