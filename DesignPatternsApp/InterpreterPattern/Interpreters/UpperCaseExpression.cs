namespace InterpreterPattern.Interpreters
{
    public class UpperCaseExpression : IExpression
    {
        public void Evaluate(Context context)
        {
            context.Value = context.Value.ToUpper();
        }
    }
}
