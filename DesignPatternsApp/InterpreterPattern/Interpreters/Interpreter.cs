using System;
using System.Collections.Generic;

namespace InterpreterPattern.Interpreters
{
    public class Interpreter
    {
        public void Interpret(Context context)
        {
            string[] expressions = context.Expression.Split(' ');
            List<IExpression> expressionTypes = new List<IExpression>();

            foreach (string expression in expressions)
            {
                if (expression == "-l") expressionTypes.Add(new LowerCaseExpression());
                else if (expression == "-u") expressionTypes.Add(new UpperCaseExpression());
            }

            foreach (var item in expressionTypes)
            {
                item.Evaluate(context);
            }

            Console.WriteLine(context.Value);
        }
    }
}
