namespace InterpreterPattern.Interpreters
{
    public class LowerCaseExpression : IExpression
    {
        public void Evaluate(Context context)
        {
            context.Value = context.Value.ToLower();
        }
    }
}
