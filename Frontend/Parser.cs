using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frontend
{
    public static class Parser
    {
        private static readonly string[] operators = { ";", "=", "/", "*", "+", "(", ")", "-", '"'.ToString() };

        /// <summary>
        /// Bu metotta satırı lexeme ile tokenlara ayırdım...
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        public static string[] Lexeme(string line)
        {
            string[] words = line.Split(" ");

            List<string> list = new List<string>();


            foreach (var word in words)
            {
                bool ekle = true;

                foreach (var op in operators)
                {
                    if (word.Contains(op) && word != op)
                    {
                        ekle = false;
                        parse(word, list);
                    }
                }
                if (ekle)
                {
                    list.Add(word);
                }
            }


            string[] result = new string[list.Count];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = list[i];
            }

            return result;
        }

        private static void parse(string word, List<string> list)
        {
            foreach (var op in operators)
            {
                if (word.StartsWith(op))
                {
                    list.Add(op);
                    list.Add(word.Split(op)[1]);
                }
                else if (word.EndsWith(op))
                {
                    list.Add(word.Split(op)[0]);
                    list.Add(op);
                }
            }
        }
    }
}
