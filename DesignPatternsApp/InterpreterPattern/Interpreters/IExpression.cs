namespace InterpreterPattern.Interpreters
{
    public interface IExpression
    {
        void Evaluate(Context context);
    }
}
