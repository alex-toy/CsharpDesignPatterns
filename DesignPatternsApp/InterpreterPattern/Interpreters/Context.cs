namespace InterpreterPattern.Interpreters
{
    public class Context
    {
        public string Expression { get; }
        public string Value { get; set; }

        public Context(string expression, string value)
        {
            Expression = expression;
            Value = value;
        }

    }
}
