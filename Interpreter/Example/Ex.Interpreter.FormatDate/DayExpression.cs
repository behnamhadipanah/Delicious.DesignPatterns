public class DayExpression : IAbstractExpression
{
    public void Interpret(Context context)
    {
        string expression = context.Expression;
        context.Expression = expression.Replace("dd", context.Date.Day.ToString());
    }
}
