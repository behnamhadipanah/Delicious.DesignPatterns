public class YearShortExpression : IAbstractExpression
{
    public void Interpret(Context context)
    {
        string expression = context.Expression;
        context.Expression = expression.Replace("YY", context.Date.Year.ToString().Substring(2, 2));
    }
}