using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frontend
{
    public static class Lexical
    {
        private static readonly string[] tokens = { "type", "variable", "operator" };
        private static readonly string[] types = { "int", "string", "double" };
        private static readonly string[] operators = { ";", "=", "/", "*", "+", "(", ")", "-", '"'.ToString() };
        public static List<string> tokenAlignment = new List<string>();
        public static bool Analysis(string[] words)
        {
            bool b = true;
            foreach (var word in words)
            {
                foreach (var type in types)
                {
                    if (word == type)
                    {
                        Console.WriteLine("{0} değerinin tipi => {1} değişkeni", word, type);
                        tokenAlignment.Add(tokens[0]);
                    }
                }
                foreach (var op in operators)
                {
                    if (word == op)
                    {
                        Console.WriteLine("{0} değerinin tipi => {1} operatoru", word, op);
                        tokenAlignment.Add(op);
                    }
                }
                var list = new string[operators.Length + types.Length];
                for (int i = 0; i < operators.Length; i++)
                {
                    list[i] = operators[i];
                }
                for (int i = operators.Length; i < list.Length; i++)
                {
                    list[i] = types[i];
                }
                
            }
            return b;
        }
    }
}
