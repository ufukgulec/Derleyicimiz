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
        public static void Analysis(string[] words)
        {
            foreach (var word in words)
            {
                foreach (var type in types)
                {
                    if (word == type)
                    {
                        Console.WriteLine("{0} değerinin tipi => {1} değişkeni", word, type);
                    }
                }
                foreach (var op in operators)
                {
                    if (word == op)
                    {
                        Console.WriteLine("{0} değerinin tipi => {1} operatoru", word, op);
                    }
                }
            }
        }
    }
}
