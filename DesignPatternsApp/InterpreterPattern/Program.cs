using InterpreterPattern.Interpreters;
using System;

namespace InterpreterPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Provide a word with expression :");
            string word = Console.ReadLine();

            string value = word.Substring(0, word.IndexOf("-"));
            string expressions = word.Substring(word.IndexOf("-"));

            Interpreter interpreter = new Interpreter();
            interpreter.Interpret(new Context(expressions, value));

            Console.ReadLine();
        }
    }
}
