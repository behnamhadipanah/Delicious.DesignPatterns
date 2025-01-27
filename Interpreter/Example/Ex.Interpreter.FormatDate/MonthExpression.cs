public class MonthExpression : IAbstractExpression
{
    public void Interpret(Context context)
    {
        string expression = context.Expression;
        context.Expression = expression.Replace("MM", context.Date.Month.ToString());
    }
}
