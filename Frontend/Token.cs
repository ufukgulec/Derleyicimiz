using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frontend
{
    public static class Token
    {
        private static readonly string[] tokens = { "int", "string", "double" };
        private static readonly string[] operators = { "+", "-", "/", "*", "=", "(", ")", ";" };
        public static string Control(string[] line)
        {
            string info = String.Empty;
            foreach (var item in line)
            {
                foreach (var token in tokens)
                {
                    if (item.Contains(token))
                    {
                        info = token;
                    }
                }
            }
            return info;
        }
    }
}
