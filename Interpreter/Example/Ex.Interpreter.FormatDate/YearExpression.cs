public class YearExpression : IAbstractExpression
{
    public void Interpret(Context context)
    {
        string expression = context.Expression;
        context.Expression = expression.Replace("YYYY", context.Date.Year.ToString());
    }
}
