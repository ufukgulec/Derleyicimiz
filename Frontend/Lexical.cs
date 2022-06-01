using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frontend
{
    public static class Lexical
    {
        private static readonly List<string> tokens = new List<string>() { "type", "variable", "operator" };
        private static readonly List<string> types = new List<string>() { "int", "string", "double" };
        private static readonly List<string> operators = new List<string>() { ";", "=", "/", "*", "+", "(", ")", "-", '"'.ToString() };
        public static List<string> tokenAlignment = new List<string>();
        public static bool Analysis(List<string> words)
        {
            tokenAlignment.Clear();
            bool b = true;
            foreach (var word in words)
            {
                foreach (var type in types)
                {
                    if (word == type)
                    {
                        Console.WriteLine("{0} değerinin tipi => {1} değişkeni", word, type);
                        tokenAlignment.Add("Type");
                    }
                    else if (word != type && !tokenAlignment.Last().Contains("Variable"))
                    {
                        tokenAlignment.Add("Variable");
                    }
                }
                foreach (var op in operators)
                {
                    if (word == op)
                    {
                        Console.WriteLine("{0} değerinin tipi => {1} operatoru", word, op);
                        tokenAlignment.Add("Operator");
                    }
                }

            }
            return b;
        }
    }
}
